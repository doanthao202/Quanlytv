using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Models1;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class NXB : Form
    {
        NxbService _service = new NxbService();
        SachctService _sch = new SachctService();
        int idWhenclick = -1;
        public NXB()
        {
             _service = new NxbService();
             _sch = new SachctService();
            InitializeComponent();
        }
        public void reset()
        {
            txtTentl.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            idWhenclick = -1;
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = false;
        }
        private void LoadData(dynamic data)
        {
            luoi.Rows.Clear();
            int stt = 1;
            luoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luoi.ColumnCount = 6;
            luoi.Columns[0].Name = "Stt";
            luoi.Columns[1].Name = "Mã nhà xuất bản";
            luoi.Columns[2].Name = "Tên nhà xuất bản";
            luoi.Columns[3].Name = "Ghi chú";
            luoi.Columns[4].Name = "Địa chỉ";
            luoi.Columns[5].Name = "SĐT";

            foreach (var NXB in data)
            {
                luoi.Rows.Add(stt++, NXB.Id, NXB.Tennxb, NXB.Ghichu, NXB.Diachi, NXB.Sdt);
            }
        }
        private void txtTentl_TextChanged(object sender, EventArgs e)
        {

        }

        private void NXB_Load(object sender, EventArgs e)
        {
            LoadData(_service.GetAll());
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = false;
        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            if (selectChild.Cells[3].Value == null)
            {
                textBox4.Text = "";
            }
            else
            {
                textBox4.Text = Convert.ToString(selectChild.Cells[3].Value);
            }
            if (selectChild.Cells[4].Value == null)
            {
                textBox3.Text = "";
            }
            else
            {
                textBox3.Text = Convert.ToString(selectChild.Cells[4].Value);
            }
            if (selectChild.Cells[5].Value == null)
            {
                textBox2.Text = "";
            }
            else
            {
                textBox2.Text = Convert.ToString(selectChild.Cells[5].Value);
            }
    

            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            

                xoa.Enabled = true;
            
            sua.Enabled = true;
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            textBox4.Text = selectChild.Cells[3].Value.ToString();
            textBox3.Text = selectChild.Cells[4].Value.ToString();
            textBox2.Text = selectChild.Cells[5].Value.ToString();

            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
           

                xoa.Enabled = true;
            
            sua.Enabled = true;
        }

        private void them_Click(object sender, EventArgs e)
        {
            var nxb = new Nxb();
            nxb.Tennxb = txtTentl.Text;
            nxb.Ghichu = textBox4.Text;
            nxb.Diachi = textBox3.Text;
            nxb.Sdt = textBox2.Text;

            MessageBox.Show(_service.add(nxb));
            LoadData(_service.GetAll());
            reset();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var result = _service.Update(idWhenclick, new Nxb()
            {
                Tennxb = txtTentl.Text,
                Ghichu = textBox4.Text,
                Diachi = textBox3.Text,
                Sdt = textBox2.Text,

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_service.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                LoadData(_service.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var x = 0;
            foreach (var i in _sch.GetAll())
            {
                if (i.Idnxb == idWhenclick)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                var thongBao = MessageBox.Show("Đã có sách từ NXB này. Bạn có muốn tiếp tục xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (thongBao == DialogResult.Yes)
                {
                    _sch.Delete1(idWhenclick);
                    var result = _service.Delete(idWhenclick);
                    if (result)
                    {

                        MessageBox.Show("Xóa thành công");
                        LoadData(_service.GetAll());
                    }

                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                var result = _service.Delete(idWhenclick);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData(_service.GetAll());
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien1();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(_service.GetSearch(textBox1.Text));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                // errorProvider1.SetError(txtSdt, null);

            }
            else
            {
                //errorProvider1.SetError(txtSdt, "Không được nhập chữ");
                e.Handled = true;
            }
        }
    }
}
