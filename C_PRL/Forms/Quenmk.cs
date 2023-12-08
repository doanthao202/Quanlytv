using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class Quenmk : Form
    {
        Nhanvienservice _nv = new Nhanvienservice();
        public Quenmk()
        {
            _nv = new Nhanvienservice();
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        int check = 0;
        private void Quenmk_Load(object sender, EventArgs e)
        {
            label2.Visible=false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //guimail("thaodt230@gmail.com", "doanbuiphuongthao@gmail.com", "HELLO ", "hi");

            otp = random.Next(100000, 1000000);
            foreach (var i in _nv.GetAll())
            {
                if (txtTK.Text == i.Email)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                errorProvider1.SetError(txtTK, "Email không tồn tại trong danh sách.");
            }
            else
            {
                otp = random.Next(100000, 1000000);
                guimail("thaodt230@gmail.com", txtTK.Text, "OTP_THUVIENF4", otp.ToString());
                txtMK.Enabled = true;
               
            }

        }
        void guimail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            mess.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Host = "smtp.gmail.com";
            client.UseDefaultCredentials = false;
            client.Port = 587;

            client.Credentials = new System.Net.NetworkCredential(from, "smlm rcvx icpe ujdm");
            client.EnableSsl = true;
            //client.Timeout = 2000;
            client.Send(mess);
        }
        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void vButton1_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == otp.ToString())
            {
                foreach (var i in _nv.GetAll().Where(c => c.Email == txtTK.Text)) {
                    
                    label2.Visible = true;
                    label2.Text = $"Mật khẩu của bạn là: {i.Pass}";
                }
            }
        }
    }
}
