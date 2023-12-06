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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL.Forms
{
    public partial class Docgia1 : Form
    {
        Docgiaservice _service = new Docgiaservice();
        HangService _hserviec = new HangService();
        PhieumuonService _pm = new PhieumuonService();
        Phieutraservice _ph = new Phieutraservice();
        int idCellClick = -1;
        public Docgia1()
        {
            _pm = new PhieumuonService();
            _ph = new Phieutraservice();
            _service = new Docgiaservice();
            _hserviec = new HangService();
            InitializeComponent();
        }

        private void Docgia1_Load(object sender, EventArgs e)
        {
            cbxtrangthai.Items.Add("Hoạt động");
            cbxtrangthai.Items.Add("Dừng hoạt động");
            foreach (var i in _hserviec.GetAll())
            {
                cbxHang.Items.Add(i.Tenhang);
            }
            loatData(_service.Getview());
            sua.Enabled = false;
            xoa.Enabled = false;
        }
        public void reset()
        {
            txtDocgia.Text = "";
            txtCCCD.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            idCellClick = -1;
            dtpNgaysinh.Value = DateTime.Now;
            dtpNgaycapthe.Value = DateTime.Now;
            Hanthe.Value = DateTime.Now;
            cbxHang.ResetText();
            cbxtrangthai.ResetText();
            them.Enabled = true;
            sua.Enabled = false;
            xoa.Enabled = false;

        }
        public void loatData(dynamic data)
        {
            //var theloai=  //_tlservice.GetById(cbxTheloai.Text).Id;
            luoi.Rows.Clear();
            int stt = 1;
            luoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luoi.ColumnCount = 12;
            luoi.Columns[0].Name = "Stt";
            luoi.Columns[1].Name = "Mã độc giả";
            luoi.Columns[2].Name = "Họ tên";
            luoi.Columns[3].Name = "Email";
            luoi.Columns[4].Name = "Sdt";
            luoi.Columns[5].Name = "Địa chỉ";
            luoi.Columns[6].Name = "CCCD";
            luoi.Columns[7].Name = "Ngày sinh";
            luoi.Columns[8].Name = "Ngày cấp thẻ";
            luoi.Columns[9].Name = "Hạn thẻ";
            luoi.Columns[10].Name = "Trạng thái";
            luoi.Columns[11].Name = "Tên hạng";
            //dgv.Columns[6].Name = "Tên thể loại";

            foreach (var s in data)
            {

                luoi.Rows.Add(stt++, s.Id, s.Hoten, s.Email, s.Sdt, s.Diachi, s.Cmnd, s.Ngaysinh, s.Ngaycapthe, s.Hanthe, s.Trangthai, s.Tenhang);
            }

        }
        private bool IsValidateMail(string email)
        {
            var r = new System.Text.RegularExpressions.Regex(@"([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
            return !String.IsNullOrEmpty(email) && r.IsMatch(email);
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (!IsValidateMail(txtEmail.Text))
            {
                MessageBox.Show("Mail không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtEmail.Focus();
            }
            else
            {
                var s1 = new Docgium();
                s1.Hoten = txtDocgia.Text;
                s1.Email = txtEmail.Text;
                s1.Sdt = txtSdt.Text;
                s1.Diachi = txtSdt.Text;
                s1.Cmnd = txtCCCD.Text;
                s1.Ngaysinh = dtpNgaysinh.Value;
                s1.Ngaycapthe = dtpNgaycapthe.Value;
                s1.Hanthe = Hanthe.Value;
                if (cbxtrangthai.Text == "Hoạt động")
                {
                    s1.Trangthai = 1;
                }
                else
                {
                    if (cbxtrangthai.Text == "Dừng hoạt động")
                    {
                        s1.Trangthai = 0;
                    }
                }
                s1.Idhang = _hserviec.GetAll().ElementAt(cbxHang.SelectedIndex).Id;

                MessageBox.Show(_service.add(s1));
                //loatData(_service.GetAll(),_tlservice);
                loatData(_service.Getview());
                reset();

            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string x = "";

            if (cbxtrangthai.Text == "Hoạt động")
            {
                x = "1";
            }
            else
            {
                if (cbxtrangthai.Text == "Dừng hoạt động")
                {
                    x = "0";
                }
            }
            if (!IsValidateMail(txtEmail.Text))
            {
                MessageBox.Show("Mail không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtEmail.Focus();
            }
            else
            {
                var result = _service.Update(idCellClick, new Docgium()
                {
                    Hoten = txtDocgia.Text,
                    Email = txtEmail.Text,
                    Sdt = txtSdt.Text,
                    Diachi = txtSdt.Text,
                    Cmnd = txtCCCD.Text,
                    Ngaysinh = dtpNgaysinh.Value,
                    Ngaycapthe = dtpNgaycapthe.Value,
                    Hanthe = Hanthe.Value,
                    Trangthai = Convert.ToInt32(x),
                    Idhang = _hserviec.GetAll().ElementAt(cbxHang.SelectedIndex).Id

                });

                if (result == 3)
                {
                    MessageBox.Show("Sửa thành công");
                    loatData(_service.Getview());
                    reset();
                }
                else if (result == 2)
                {
                    MessageBox.Show("Tên không được để trống");
                    loatData(_service.Getview());

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                reset();
            }
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];//lấy data từ index được chọn
            txtDocgia.Text = selectChild.Cells[2].Value.ToString();
            txtEmail.Text = selectChild.Cells[3].Value.ToString();
            txtSdt.Text = selectChild.Cells[4].Value.ToString();
            txtDiachi.Text = selectChild.Cells[5].Value.ToString();
            txtCCCD.Text = selectChild.Cells[6].Value.ToString();
            dtpNgaysinh.Value = Convert.ToDateTime(selectChild.Cells[7].Value.ToString());
            dtpNgaycapthe.Value = Convert.ToDateTime(selectChild.Cells[8].Value.ToString());
            Hanthe.Value = Convert.ToDateTime(selectChild.Cells[9].Value.ToString());

            if (selectChild.Cells[10].Value.ToString() == "0")
            {
                cbxtrangthai.Text = "Dừng hoạt động";
            }
            else
            {
                if (selectChild.Cells[10].Value.ToString() == "1")
                {
                    cbxtrangthai.Text = "Hoạt động";
                }
            }
            cbxHang.Text = selectChild.Cells[11].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            sua.Enabled = true;
            var x = 0;
            var y = 0;
            foreach (var i in _pm.GetAll())
            {
                if (idCellClick == i.Iddocgia)
                {
                    x = 1;
                    continue;
                }

            }
            foreach (var i in _ph.GetAll())
            {
                if (idCellClick == i.Iddocgia)
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

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];//lấy data từ index được chọn
            txtDocgia.Text = selectChild.Cells[2].Value.ToString();
            txtEmail.Text = selectChild.Cells[3].Value.ToString();
            txtSdt.Text = selectChild.Cells[4].Value.ToString();
            txtDiachi.Text = selectChild.Cells[5].Value.ToString();
            txtCCCD.Text = selectChild.Cells[6].Value.ToString();
            dtpNgaysinh.Value = Convert.ToDateTime(selectChild.Cells[7].Value.ToString());
            dtpNgaycapthe.Value = Convert.ToDateTime(selectChild.Cells[8].Value.ToString());
            Hanthe.Value = Convert.ToDateTime(selectChild.Cells[9].Value.ToString());

            if (selectChild.Cells[10].Value.ToString() == "0")
            {
                cbxtrangthai.Text = "Dừng hoạt động";
            }
            else
            {
                if (selectChild.Cells[10].Value.ToString() == "1")
                {
                    cbxtrangthai.Text = "Hoạt động";
                }
            }
            cbxHang.Text = selectChild.Cells[11].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            sua.Enabled = true;
            var x = 0;
            var y = 0;
            foreach (var i in _pm.GetAll())
            {
                if (idCellClick == i.Iddocgia)
                {
                    x = 1;
                    continue;
                }

            }
            foreach (var i in _ph.GetAll())
            {
                if (idCellClick == i.Iddocgia)
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

        private void xoa_Click(object sender, EventArgs e)
        {

            var result = _service.Delete(idCellClick);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                loatData(_service.Getview());
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
            loatData(_service.Getview1(textBox1.Text));
        }

        private void txtDocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDocgia, "Tên không được nhập số");

            }
            else
            {
                errorProvider1.Clear();
                e.Handled = false;
            }

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(txtSdt, "Số điện thoại không được nhập chữ");
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(txtCCCD, "Số CCCD không được nhập chữ");
                e.Handled = true;
            }
        }
    }
}
