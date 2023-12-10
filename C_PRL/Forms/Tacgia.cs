using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Models;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class Tacgia : Form
    {
        Tacgiaservice _service = new Tacgiaservice();
        SachtacgiaService _stgservice = new SachtacgiaService();
        int idWhenclick = -1;
        public Tacgia()
        {
            _stgservice = new SachtacgiaService();
            _service = new Tacgiaservice();
            InitializeComponent();
        }

        private void Tacgia_Load(object sender, EventArgs e)
        {
            LoadData(_service.GetAll());
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = false;
        }
        public void reset()
        {
            txtTentl.Text = "";
            txtVitri.Text = "";
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
            luoi.ColumnCount = 4;
            luoi.Columns[0].Name = "Stt";
            luoi.Columns[1].Name = "Mã tác giả";
            luoi.Columns[2].Name = "Tên tác giả";
            luoi.Columns[3].Name = "Ghi chú";

            foreach (var tacgia in data)
            {
                luoi.Rows.Add(stt++, tacgia.Id, tacgia.Tentacgia, tacgia.Ghichu);
            }
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //luoi.AllowUserToAddRows = false;
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            if (Convert.ToString((selectChild.Cells[3].Value)) == null)
            {
                txtVitri.Text = "";
            }
            else
            {
                txtVitri.Text = Convert.ToString(selectChild.Cells[3].Value);
            }
            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
           
            sua.Enabled = true;
            xoa.Enabled = true;


        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            if (Convert.ToString(selectChild.Cells[3].Value )== null)
            {
                txtVitri.Text = "";
            }
            else
            {
                txtVitri.Text = Convert.ToString(selectChild.Cells[3].Value);
            }

            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            
            xoa.Enabled = true;
            sua.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(_service.GetSearch(textBox1.Text));
        }

        private void them_Click(object sender, EventArgs e)
        {
            var tg = new Tacgium();
            tg.Tentacgia = txtTentl.Text; ;
            tg.Ghichu = txtVitri.Text;

            MessageBox.Show(_service.add(tg));
            LoadData(_service.GetAll());
            reset();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var result = _service.Update(idWhenclick, new Tacgium()
            {
                Tentacgia = txtTentl.Text,
                Ghichu = txtVitri.Text

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
            foreach (var i in _stgservice.GetAll())
            {
                if (i.Idtacgia==idWhenclick)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                var thongBao = MessageBox.Show("Tác giả đã có sách, bạn có muốn xóa tác giả không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (thongBao == DialogResult.Yes)
                {
                   _stgservice.Delete1(idWhenclick);
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

        private void txtTentl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTentl, "Tên tác giả không được nhập số");

            }
            else
            {
                errorProvider1.Clear();
                e.Handled = false;
               
            }
        }
    }
}
