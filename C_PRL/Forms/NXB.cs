using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class NXB : Form
    {
        NxbService _service = new NxbService();
        int idWhenclick = -1;
        public NXB()
        {
            _service = new NxbService();
            InitializeComponent();
        }

        private void txtTentl_TextChanged(object sender, EventArgs e)
        {

        }

        private void NXB_Load(object sender, EventArgs e)
        {

        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {

        }

        private void sua_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                // errorProvider1.SetError(txtSdt, null);

            }
            else
            {
                //errorProvider1.SetError(txtSdt, "Không được nhập chữ");
                e.Handled = true;
            }
        }
    }
}
