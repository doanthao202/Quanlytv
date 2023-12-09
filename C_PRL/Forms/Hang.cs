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
    public partial class Hang : Form

    {
        HangService _Hservice = new HangService();
        SachHangService _shservice = new SachHangService();
        Docgiaservice _docgiaservice = new Docgiaservice();
        int idCellClick = -1;
        public Hang()
        {
            _Hservice = new HangService();
            _shservice = new SachHangService();
            _docgiaservice = new Docgiaservice();
            InitializeComponent();
        }
        public void LoadData(dynamic data)
        {
            luoi.Rows.Clear();
            int stt = 1;
            luoi.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            luoi.ColumnCount = 5;
            luoi.Columns[0].Name = "STT";
            luoi.Columns[1].Name = "Mã hạng";
            luoi.Columns[2].Name = "Tên hạng";
            luoi.Columns[3].Name = "Đơn giá";
            luoi.Columns[4].Name = "Thời hạn";
            foreach (var hang in data)
            {
                luoi.Rows.Add(stt++, hang.Id, hang.Tenhang, hang.Dongia, hang.Thoigianhieuluc);
            }
        }
        public void reset()
        {
            txtTentl.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            idCellClick = -1;
            them.Enabled = true;
            sua.Enabled = false;
            xoa.Enabled = false;
        }
        private void Hang_Load(object sender, EventArgs e)
        {
            LoadData(_Hservice.GetAll());
            sua.Enabled = false;
            xoa.Enabled = false;
            them.Enabled = true;

        }

        private void them_Click(object sender, EventArgs e)
        {
            var Htv = new Hangthanhvien();
            Htv.Tenhang = txtTentl.Text;
            if (decimal.TryParse(textBox2.Text, out decimal dongiaValue))
            {
                Htv.Dongia = dongiaValue;
            }
            if (int.TryParse(textBox3.Text, out int thoigianValue))
            {
                Htv.Thoigianhieuluc = thoigianValue;
            }

            MessageBox.Show(_Hservice.Add(Htv));
            LoadData(_Hservice.GetAll());
            reset();
        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            textBox2.Text = selectChild.Cells[3].Value.ToString();
            textBox3.Text = selectChild.Cells[4].Value.ToString();

            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            sua.Enabled = true;
            var x = 0;
            var y = 0;
            foreach (var i in _shservice.GetAll())
            {
                if (idCellClick == i.Idhang)
                {
                    x = 1;
                    continue;
                }

            }
            foreach (var i in _docgiaservice.GetAll())
            {
                if (idCellClick == i.Idhang)
                {
                    y = 1;
                    continue;
                }

            }
            if (x != 1 && y != 1)
            {
                xoa.Enabled = true;
            }
            else
            {

                xoa.Enabled = false;
            }
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            textBox2.Text = selectChild.Cells[3].Value.ToString();
            textBox3.Text = selectChild.Cells[4].Value.ToString();

            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);
            them.Enabled = false;
            sua.Enabled = true;
            var x = 0;
            var y = 0;
            foreach (var i in _shservice.GetAll())
            {
                if (idCellClick == i.Idhang)
                {
                    x = 1;
                    continue;
                }

            }
            foreach (var i in _docgiaservice.GetAll())
            {
                if (idCellClick == i.Idhang)
                {
                    y = 1;
                    continue;
                }

            }
            if (x != 1 && y != 1)
            {
                xoa.Enabled = true;
            }
            else
            {

                xoa.Enabled = false;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string i = "";
            if (textBox2.Text == "")
            {
                i = null;
            }
            else
            {
                i = textBox2.Text;
            }
            string m = "";
            if (textBox3.Text == "")
            {
                m = null;
            }
            else
            {
                m = textBox3.Text;
            }
            var result = _Hservice.Update(idCellClick, new Hangthanhvien()
            {
                Tenhang = txtTentl.Text,
                Dongia = Convert.ToDecimal(i),
                Thoigianhieuluc = Convert.ToInt32(m)
            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_Hservice.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                LoadData(_Hservice.GetAll());
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var result = _Hservice.Delete(idCellClick);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                LoadData(_Hservice.GetAll());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
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
            LoadData(_Hservice.GetSearch(textBox1.Text));
        }
    }
}
