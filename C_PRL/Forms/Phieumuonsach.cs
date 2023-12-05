using System;
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
    public partial class Phieumuonsach : Form
    {
        PhieumuonctService _pmctservice = new PhieumuonctService();
        PhieumuonService _service = new PhieumuonService();
        SachctService _sachservice = new SachctService();
        Docgiaservice _dgservice = new Docgiaservice();
        Nhanvienservice _nvservice = new Nhanvienservice();
        int idCellClick = -1;
        public Phieumuonsach()
        {
            _pmctservice = new PhieumuonctService();
            _service = new PhieumuonService();
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Phieumuonsach_Load(object sender, EventArgs e)
        {
            cbxKieudocgia.Items.Add("Khách lẻ");
            cbxKieudocgia.Items.Add("Thành viên");
            foreach (var i in _sachservice.Getview())
            {
                comboBox1.Items.Add(i.Tensach + " - " + i.Tennn + " - " + i.Tennxb + " - " + i.Lantaiban);
            }
            foreach (var i in _dgservice.GetAll())
            {
                cbxTenthanhvien.Items.Add(i.Hoten);
            }
            foreach (var i in _nvservice.GetAll())
            {
                cbxTennv.Items.Add(i.Hoten);
            }
            comboBox1.Enabled = true;

            cbxTenthanhvien.Enabled = false;
            txtTenkhachle.Enabled = false;
            txtTiencoc.Enabled = false;
            textBox2.Enabled = false;
            txtsdt.Enabled = false;
            datengaytra.Enabled = false;
            datengaytra.Value = (dtpNgaymuon.Value.AddDays(7));
        }



        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem((_sachservice.Getview().ElementAt(comboBox1.SelectedIndex).Id).ToString());
            //THÊM CÁC Ô TIẾP THEo
            lv1.SubItems.Add(comboBox1.Text);
            lv1.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lv1);
            comboBox1.ResetText();
            textBox3.Text = "";
        }





        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem lv = listView1.SelectedItems[0];
                string tentacgia = lv.SubItems[1].Text;
                string vaitro = lv.SubItems[2].Text;
                comboBox1.Text = tentacgia;
                textBox3.Text = vaitro;
                /*btnXacnhan.Enabled = false;
                btnXoa.Enabled = true;*/
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                comboBox1.ResetText();
                textBox3.Text = "";

            }
        }

        private void cbxKieudocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKieudocgia.Text == "")
            {
                cbxTenthanhvien.Enabled = false;
                txtTenkhachle.Enabled = false;
                txtTiencoc.Enabled = false;
                textBox2.Enabled = false;
                txtsdt.Enabled = false;

            }
            else if (cbxKieudocgia.Text == "Thành viên")
            {
                cbxTenthanhvien.Enabled = true;
                txtTenkhachle.Enabled = false;
                txtTiencoc.Enabled = false;
                textBox2.Enabled = true;

            }
            else
            {
                if (cbxKieudocgia.Text == "Khách lẻ")
                {
                    cbxTenthanhvien.Enabled = false;
                    txtTenkhachle.Enabled = true;
                    txtTiencoc.Enabled = true;
                    textBox2.Enabled = true;
                    txtsdt.Enabled = true;
                }
            }
        }

        private void cbxTenthanhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsdt.Text = _dgservice.GetAll().ElementAt(cbxTenthanhvien.SelectedIndex).Sdt;
        }

        private void dtpNgaymuon_ValueChanged(object sender, EventArgs e)
        {
            datengaytra.Value = (dtpNgaymuon.Value.AddDays(7));
            
        }
    }
}
