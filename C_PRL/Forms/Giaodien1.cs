using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class Giaodien1 : Form
    {
        public Giaodien1()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Nhanvien1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();

        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             Form f = new Sach1();
             f.Show();*/
        }

        private void hangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Hang();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             Form f = new Docgia1();
             f.Show();*/
        }

        private void mươntraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiêuMươnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Phieumuonsach();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void phiêuTraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            Form f = new Phieutrasach();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void sachChiTiêtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            Form f = new Sach1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Tacgia1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void ngônNgưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new NgonNgu1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new NXB();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void thêLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form f = new Theloai1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void đăngXiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();

            f.Show();
        }

        private void thEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Theloai1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void sachChiTiêtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Sachchitiet1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void thôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Thongke();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void sachĐươcMươnNhiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Danhsachphieumuon();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void thanhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Docgia1();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = Properties.Settings.Default.Tennhanvien;
            label2.Text = Properties.Settings.Default.Vaitro;
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new Doimatkhau();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            f.Show();
        }
    }
}
