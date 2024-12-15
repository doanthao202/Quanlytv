using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using A_DAL.Models1;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class Doimatkhau : Form
    {
        Nhanvienservice _nv = new Nhanvienservice();
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {

            foreach (var item in _nv.GetAll())
            {
                if (item.Email == Properties.Settings.Default.user || item.Sdt == Properties.Settings.Default.user && item.Hoten == Properties.Settings.Default.Tennhanvien)
                {
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(txtTentl.Text) || string.IsNullOrWhiteSpace(txtVitri.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    }
                    else if (textBox1.Text != item.Pass)
                    {
                        MessageBox.Show("Nhập sai mật khẩu");

                    }
                    else if (txtTentl.Text != txtVitri.Text)
                    {
                        MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới");
                    }
                    else
                    {
                        _nv.Update1(item.Id, txtVitri.Text);
                        MessageBox.Show("Đổi mật khẩu thành công");
                        textBox1.Text = "";
                        txtTentl.Text = "";
                        txtVitri.Text = "";
                    }
                }

            }

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
