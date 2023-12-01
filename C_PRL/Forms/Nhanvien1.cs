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
    public partial class Nhanvien1 : Form
    {
        Nhanvienservice _service = new Nhanvienservice();
        public Nhanvien1()
        {
            _service = new Nhanvienservice();
            InitializeComponent();
        }
        int idCellClick = -1;
        private void txtTensach_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhanvien1_Load(object sender, EventArgs e)
        {
            cxbTrangthai.Items.Add("Hoạt động");
            cxbTrangthai.Items.Add("Dừng hoạt động");
            cbxVaitro.Items.Add("Quản lý");
            cbxVaitro.Items.Add("Thủ thư");
            loatData(_service.GetAll());
            Sua.Enabled = false;
            xoa.Enabled = false;

        }
        public void loatData(dynamic data)
        {
            dgv.Rows.Clear();
            int stt = 1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 8;
            dgv.Columns[0].Name = "Stt";
            dgv.Columns[1].Name = "Mã nhân viên";
            dgv.Columns[2].Name = "họ tên";
            dgv.Columns[3].Name = "SĐT";
            dgv.Columns[4].Name = "Vai trò";
            dgv.Columns[5].Name = "Email";
            dgv.Columns[6].Name = "Pass";
            dgv.Columns[7].Name = "Trang thái";

            foreach (var nv in data)
            {
                var x = "";
                if (nv.Trangthai == 1)
                {
                    x = "Hoạt động";
                }
                else
                {
                    x = "Dừng hoạt động";
                }
                dgv.Rows.Add(stt++, nv.Id, nv.Hoten, nv.Sdt, nv.Vaitro, nv.Email, nv.Pass, x);
            }

        }
        public void reset()
        {
            txtTen.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            cbxVaitro.ResetText();
            txtPass.Text = "";
            cxbTrangthai.ResetText();
            idCellClick = -1;
            them.Enabled = true;
            Sua.Enabled = false;
            xoa.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            var nv = new Nhanvien();
            nv.Hoten = txtTen.Text; ;
            nv.Sdt = txtSdt.Text;
            nv.Vaitro = cbxVaitro.Text;
            nv.Email = txtEmail.Text;
            nv.Pass = txtPass.Text;
            if (cxbTrangthai.Text == "Dừng hoạt động")
            {
                nv.Trangthai = 0;
            }
            else if (cxbTrangthai.Text == "Hoạt động")
            {
                nv.Trangthai = 1;
            }
            else
            {
                nv.Trangthai = null;
            }

            var thongBao = MessageBox.Show("Xác nhận thêm sinh viên", "Xác nhận", MessageBoxButtons.YesNo);
            if (thongBao == DialogResult.Yes)
            {
                MessageBox.Show(_service.add(nv));
                loatData(_service.GetAll());
                reset();
            }
            else
            {
                return;
            }

        }

        private void Sua_Click(object sender, EventArgs e)
        {
            string x = "";
            if (cxbTrangthai.Text == "Dừng hoạt động")
            {
                x = "0";
            }
            else if (cxbTrangthai.Text == "Hoạt động")
            {
                x = "1";
            }
            else
            {
                x = null;
            }
            var result = _service.Update(idCellClick, new Nhanvien()
            {
                Hoten = txtTen.Text,
                Sdt = txtSdt.Text,
                Vaitro = cbxVaitro.Text,
                Email = txtEmail.Text,
                Pass = txtPass.Text,
                Trangthai = Convert.ToInt32(x)

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                loatData(_service.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                loatData(_service.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn

            txtTen.Text = selectChild.Cells[2].Value.ToString();
            txtSdt.Text = selectChild.Cells[3].Value.ToString();

            cbxVaitro.Text = selectChild.Cells[4].Value.ToString();
            txtEmail.Text = selectChild.Cells[5].Value.ToString();
            txtPass.Text = selectChild.Cells[6].Value.ToString();
            cxbTrangthai.Text = selectChild.Cells[7].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            Sua.Enabled = true;
            xoa.Enabled = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn

            txtTen.Text = selectChild.Cells[2].Value.ToString();
            txtSdt.Text = selectChild.Cells[3].Value.ToString();
            txtEmail.Text = selectChild.Cells[5].Value.ToString();
            cbxVaitro.Text = selectChild.Cells[4].Value.ToString();
            txtPass.Text = selectChild.Cells[6].Value.ToString();
            cxbTrangthai.Text = selectChild.Cells[7].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            Sua.Enabled = true;
            xoa.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var result = _service.Delete(idCellClick);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                loatData(_service.GetAll());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = _service.GetSearch1(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = _service.GetSearch1(textBox1.Text);
        }
    }
}
