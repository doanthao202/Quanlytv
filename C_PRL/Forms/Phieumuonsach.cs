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
        int x = 0;
        private void them_Click(object sender, EventArgs e)
        {
            var phieumuon1 = new Phieumuon();

            if (cbxTenthanhvien.Text == "" && txtTenkhachle.Text != "")
            {

                if (txtTiencoc.Text == "" || textBox2.Text == "" || cbxTennv.Text == "")
                {
                    if (txtTiencoc.Text == "" && textBox2.Text != "")
                    {
                        MessageBox.Show("Khách lẻ thiếu tiền cọc sách");
                    }
                    else if (txtTiencoc.Text != "" && textBox2.Text == "")
                    {
                        MessageBox.Show("Khách lẻ thiếu phí mượn sách");
                    }
                    else
                    {
                        if (txtTiencoc.Text == "" && textBox2.Text == "")
                        {
                            MessageBox.Show("Khách lẻ phải đóng tiền cọc và phí mượn sách");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng điền tên nhân viên");
                        }
                    }
                    return;

                }

                else
                {
                    phieumuon1.Iddocgia = null;
                    phieumuon1.Idnhanvien = _nvservice.GetAll().ElementAt(cbxTennv.SelectedIndex).Id;
                    phieumuon1.Tendocgia = txtTenkhachle.Text;
                    phieumuon1.Sdt = txtsdt.Text;
                    phieumuon1.Ngaymuon = dtpNgaymuon.Value;
                    phieumuon1.Ngaytradukien = datengaytra.Value;

                    phieumuon1.Tiencoc = Convert.ToDecimal(txtTiencoc.Text);
                    phieumuon1.Phimuon = Convert.ToDecimal(textBox2.Text);



                    phieumuon1.Tinhtrang = 1;
                   
                    if (listView1.Items.Count == 0)
                    {
                        MessageBox.Show("Phiếu mượn chưa có sách");
                    }
                    else
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {

                            ListViewItem lv = listView1.Items[i];
                            if (lv.SubItems[0].Text == "" || lv.SubItems[1].Text == "")
                            {
                                MessageBox.Show("Phiếu mượn chưa có sách");
                                return;
                            }
                            else
                            {
                                _service.add(phieumuon1);
                                x = phieumuon1.Id;
                                int idsach = Convert.ToInt16(lv.SubItems[0].Text);

                                var phieumuonchitiet = new Phieumuonct();
                                phieumuonchitiet.Idsachct = idsach;
                                phieumuonchitiet.Idphieumuon = x;

                                phieumuonchitiet.Ghichu = lv.SubItems[2].Text;
                                phieumuonchitiet.Tinhtrang = 1;
                                _pmctservice.add(phieumuonchitiet);
                                MessageBox.Show("Thêm phiếu thành công");
                                comboBox1.Enabled = true;
                                cbxKieudocgia.Text = "";
                                txtTenkhachle.Text = "";
                                cbxTennv.ResetText();
                                cbxTenthanhvien.ResetText();
                                txtTenkhachle.Text = "";
                                txtTiencoc.Text = "";
                                textBox2.Text = "";
                                txtsdt.Text = "";
                                cbxTenthanhvien.Enabled = false;
                                txtTenkhachle.Enabled = false;
                                txtTiencoc.Enabled = false;
                                textBox2.Enabled = false;
                                txtsdt.Enabled = false;
                                dtpNgaymuon.Value = DateTime.Now;
                                datengaytra.Enabled = false;
                                datengaytra.Value = (dtpNgaymuon.Value.AddDays(7));
                                listView1.Items.Clear();
                            }


                        }
                    }


                }
            }
            else if (cbxTenthanhvien.Text != "" && txtTenkhachle.Text == "")
            {
                if (cbxTenthanhvien.Text != "")
                {
                    phieumuon1.Iddocgia = _dgservice.GetAll().ElementAt(cbxTenthanhvien.SelectedIndex).Id; ;
                    phieumuon1.Idnhanvien = _nvservice.GetAll().ElementAt(cbxTennv.SelectedIndex).Id;
                    phieumuon1.Tendocgia = cbxTenthanhvien.Text;
                    phieumuon1.Sdt = txtsdt.Text;
                    phieumuon1.Ngaymuon = dtpNgaymuon.Value;
                    phieumuon1.Ngaytradukien = datengaytra.Value;
                    phieumuon1.Tiencoc = 0;
                    //phieumuon1.Phimuon = Convert.ToDecimal(txtTiencoc.Text);
                    if (textBox2.Text == "")
                    {
                        phieumuon1.Phimuon = 0;
                    }
                    else
                    { phieumuon1.Phimuon = Convert.ToDecimal(textBox2.Text); }
                    phieumuon1.Tinhtrang = 1;
                    phieumuon1.Tinhtrang = 1;
                    x = phieumuon1.Id;
                    if (listView1.Items.Count == 0)
                    {
                        MessageBox.Show("Phiếu mượn chưa có sách");
                    }
                    else
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {

                            ListViewItem lv = listView1.Items[i];
                            if (lv.SubItems[0].Text == "" || lv.SubItems[1].Text == "")
                            {
                                MessageBox.Show("Không được để trống tên sách");
                                return;
                            }
                            else
                            {
                                int idsach = Convert.ToInt16(lv.SubItems[0].Text);

                                var phieumuonchitiet = new Phieumuonct();
                                phieumuonchitiet.Idsachct = idsach;
                                phieumuonchitiet.Idphieumuon = x;
                                phieumuonchitiet.Ghichu = lv.SubItems[2].Text;

                                _pmctservice.add(phieumuonchitiet);
                                MessageBox.Show("Thêm phiếu thành công");
                                comboBox1.Enabled = true;

                                comboBox1.Enabled = true;
                                cbxKieudocgia.Text = "";
                                cbxTennv.ResetText();
                                cbxTenthanhvien.ResetText();
                                txtTenkhachle.Text = "";
                                txtTiencoc.Text = "";
                                txtsdt.Text = "";
                                textBox2.Text = "";
                                cbxTenthanhvien.Enabled = false;
                                txtTenkhachle.Enabled = false;
                                txtTiencoc.Enabled = false;
                                textBox2.Enabled = false;
                                txtsdt.Enabled = false;
                                dtpNgaymuon.Value = DateTime.Now;
                                datengaytra.Enabled = false;
                                datengaytra.Value = (dtpNgaymuon.Value.AddDays(7));
                                listView1.Items.Clear();
                            }


                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin độc giả");
            }






        }

        
        private void datengaytra_ValueChanged_1(object sender, EventArgs e)
        {
            //datengaytra.Value > dtpNgaymuon.Value.AddDays(7);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();

            }
            else
            {
                errorProvider1.SetError(txtsdt, "Số điện thoại không được nhập chữ");
                e.Handled = true;
            }
        }

        private void txtTenkhachle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenkhachle, "Tên không được nhập số");

            }
            else
            {
                errorProvider1.Clear();
                e.Handled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datengaytra.Enabled = true;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
