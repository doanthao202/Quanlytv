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
        int idWhenclick = -1;
        public Tacgia()
        {
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
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            txtVitri.Text = selectChild.Cells[3].Value.ToString();

            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            xoa.Enabled = true;
            sua.Enabled = true;
        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            txtVitri.Text = selectChild.Cells[3].Value.ToString();

            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            xoa.Enabled = true;
            sua.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            luoi.DataSource = _service.GetSearch(textBox1.Text);
        }

        private void them_Click(object sender, EventArgs e)
        {
            var tg = new Tacgium();
            tg.Tentacgia = txtTentl.Text; ;
            tg.Ghichu = txtVitri.Text;

            var thongBao = MessageBox.Show("Xác nhận thêm ", "Xác nhận", MessageBoxButtons.YesNo);
            if (thongBao == DialogResult.Yes)
            {
                MessageBox.Show(_service.add(tg));
                LoadData(_service.GetAll());
                reset();
            }
            else
            {
                return;
            }
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

            reset();

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien();
            f.Show();
        }

        private void txtTentl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;


            }
            else
            {

                e.Handled = false;
            }
        }
    }
}
