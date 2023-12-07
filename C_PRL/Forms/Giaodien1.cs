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
            this.Hide();
            Form f = new Nhanvien1();
            f.Show();

        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Sach1();
            f.Show();
        }

        private void hangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Hang();
            f.Show();
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Docgia1();
            f.Show();
        }

        private void mươntraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiêuMươnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Phieumuonsach();
            f.Show();
        }

        private void phiêuTraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new Phieutrasach();
            f.Show();
        }

        private void sachChiTiêtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Sachchitiet1();
            f.Show();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Tacgia();
            f.Show();
        }

        private void ngônNgưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new NgonNgu1();
            f.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new NXB();
            f.Show();
        }

        private void thêLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Theloai1();
            f.Show();
        }
    }
}
