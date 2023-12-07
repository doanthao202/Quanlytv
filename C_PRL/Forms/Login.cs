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
                MessageBox.Show("Email hoặc SĐT không chính xác!");
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
                MessageBox.Show("Đăng nhập thành công!");
                GiaoDienNV giaodienNV = new GiaoDienNV();
                giaodienNV.Show();
                this.Hide();
            }
            else if (loginM != null && loginM.Pass == password && loginM.Trangthai == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Giaodien giaodien = new Giaodien();
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
    }
}
