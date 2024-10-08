﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Repository;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class Login : Form
    {
        private readonly LoginService loginSV;
        Nhanvienservice _nv = new Nhanvienservice();
        public Login()
        {
             _nv=new Nhanvienservice();
            loginSV = new LoginService(new LoginRepos());
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text;
            string password = txtMK.Text;

            var loginM = loginSV.GetNhanvienByUsername(username);
            if (loginM == null)
            {
                MessageBox.Show("Email hoặc SĐT không chinhd xác!");
            }

            else if (loginM.Pass != password)
            {
                MessageBox.Show("Mật khẩu không chính xác!");
            }
            else if (loginM.Trangthai == 0)
            {
                MessageBox.Show("Tài khoản không hoạt động!");
            }
            else if (loginM != null && loginM.Pass == password && loginM.Trangthai == 1 && loginM.Vaitro == "Thủ thư")
            {
              foreach(var item in _nv.GetAll())
               {
                    if ((username == item.Email || username == item.Sdt) && password == item.Pass)
                    {
                        Properties.Settings.Default.user = username;
                        Properties.Settings.Default.password=password;
                        Properties.Settings.Default.Tennhanvien = item.Hoten;
                        Properties.Settings.Default.Vaitro = "Thủ thư";
                        Properties.Settings.Default.Save();
                    }
                   
                }
                Hienthi giaodienNV = new Hienthi();
                giaodienNV.Show();
                this.Hide();
            }
            else if (loginM != null && loginM.Pass == password && loginM.Trangthai == 1)
            {
                foreach (var item in _nv.GetAll())
                {
                    if ((username == item.Email || username == item.Sdt) && password == item.Pass)
                    {
                        Properties.Settings.Default.user = username;
                        Properties.Settings.Default.password = password;
                        Properties.Settings.Default.Tennhanvien = item.Hoten;
                        Properties.Settings.Default.Vaitro = "Quản lý";
                        Properties.Settings.Default.Save();
                    }

                }

                Giaodien1 giaodien = new Giaodien1();
                giaodien.Show();
                this.Hide();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void QMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new Quenmk();
            f.Show();
        }
    }
}
