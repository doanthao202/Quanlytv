using System;
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
        public Login()
        {
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
            else if (loginM != null && loginM.Pass == password && loginM.Trangthai == 1 && loginM.Vaitro == "Nhân viên")
            {

                Hienthi giaodienNV = new Hienthi();
                giaodienNV.Show();
                this.Hide();
            }
            else if (loginM != null && loginM.Pass == password && loginM.Trangthai == 1)
            {

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
