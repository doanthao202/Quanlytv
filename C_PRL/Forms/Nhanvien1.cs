﻿using System;
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
        PhieumuonService _pmservice = new PhieumuonService();
        Phieutraservice _ptservice = new Phieutraservice();
        public Nhanvien1()
        {
            _service = new Nhanvienservice();
            _pmservice = new PhieumuonService();
           _ptservice = new Phieutraservice();
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
            cxbTrangthai.Text = "Hoạt động";
            cxbTrangthai.Enabled = false;

           
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
            cxbTrangthai.Text = "Hoạt động";
            cxbTrangthai.Enabled = false;
        }
        private bool IsValidateMail(string email)
        {
            var r = new System.Text.RegularExpressions.Regex(@"([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
            return !String.IsNullOrEmpty(email) && r.IsMatch(email);
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
                int x = 0;
                int y= 0;
                foreach(var i in _service.GetAll())
                {
                    if(i.Email == txtEmail.Text)
                    {
                        x = 1;
                    }
                    if (i.Sdt == txtSdt.Text)
                    {
                        y = 1;
                    }
                }
                if(x==1)
                {
                    MessageBox.Show("Email đã tồn tại");
                }else if (y == 1)
                {
                    MessageBox.Show("Sđt đã tồn tại");
                }
                else if(x==1&& y == 1)
                {
                    MessageBox.Show("Email và sđt đã tồn tại");
                }
                else
                {
                    var nv = new Nhanvien();
                    nv.Hoten = txtTen.Text; ;
                    nv.Sdt = txtSdt.Text;
                    nv.Vaitro = cbxVaitro.Text;
                    nv.Email = txtEmail.Text;
                    nv.Pass = txtPass.Text;
                    nv.Trangthai = 1;
                    MessageBox.Show(_service.add(nv));
                    loatData(_service.GetAll());
                    reset();
                }
                
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
            if (!IsValidateMail(txtEmail.Text))
            {
                MessageBox.Show("Mail không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtEmail.Focus();
            }
            else
            {
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
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    loatData(_service.GetAll());

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
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
            
           // cxbTrangthai.ResetText();
            cxbTrangthai.Enabled = true;
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
           
            //cxbTrangthai.ResetText();
            cxbTrangthai.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var x = 0;
            var y = 0;
            foreach (var i in _pmservice.GetAll())
            {
                if (idCellClick == i.Idnhanvien)
                {
                    x = 1;
                    continue;
                }

            }
            foreach (var i in _ptservice.GetAll())
            {
                if (idCellClick == i.Idnhanvien)
                {
                    y = 1;
                    continue;
                }

            }
            if(x== 1 || y == 1){
                var thongBao = MessageBox.Show("Nhân viên đang hoạt động, bạn có muốn tiếp tục xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (thongBao == DialogResult.Yes)
                {
                    _pmservice.Delete1(idCellClick);
                    _ptservice.Delete(idCellClick);
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
                }
            }
            else
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
            }
          

            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_service.GetSearch1(textBox1.Text));
        }



        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTen, "Tên không được nhập số");

            }
            else
            {
                errorProvider1.Clear();
                e.Handled = false;
            }
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            
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
    }
}
