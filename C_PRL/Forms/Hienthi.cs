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
    public partial class Hienthi : Form
    {
        public Hienthi()
        {
            InitializeComponent();
        }

        private void đăngXiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new Login();

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hienthi_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.Tennhanvien;
            label2.Text = Properties.Settings.Default.Vaitro;
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

        private void thEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form f = new NXB();
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
