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
using C_PRL.Forms;

namespace C_PRL
{
    public partial class Phieutrasach : Form

    {
        Phieutraservice _ptservice = new Phieutraservice();
        PhieutractService _ptct = new PhieutractService();
        PhieumuonService _pm = new PhieumuonService();
        Nhanvienservice _nv = new Nhanvienservice();
        PhieumuonctService _pmct = new PhieumuonctService();
        public Phieutrasach()
        {
            _ptservice = new Phieutraservice();
            _ptct = new PhieutractService();
            _pm = new PhieumuonService();
            _nv = new Nhanvienservice();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Phieutrasach_Load(object sender, EventArgs e)
        {

            comboBox3.Items.Add("Khách lẻ");
            comboBox3.Items.Add("Thành viên");
            loatData1(_pm.GetAll());
            foreach (var x in _nv.GetAll())
            {
                cbxTennv.Items.Add(x.Hoten);
            }
            foreach (var x in _pm.GetAll())
            {
                comboBox2.Items.Add(x.Id);
            }/* foreach (var x in _pmct.Getview())
            {
                comboBox1.Items.Add(x.Idphieumuon + " - " + x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
            }*/
            textBox1.Enabled = false;
            textBox7.Enabled = false;
            txtsdt.Enabled = false;
        }
        public void loatData1(dynamic data)
        {
            listView2.Items.Clear();

            foreach (var s in data)
            {
                if (s.Tinhtrang == 1)
                {

                    ListViewItem lv1 = new ListViewItem(s.Tendocgia);
                    //THÊM CÁC Ô TIẾP THEo
                    lv1.SubItems.Add(s.Sdt);
                    if (s.Iddocgia == null)
                    {
                        lv1.SubItems.Add("Khách lẻ");
                    }
                    else
                    {
                        lv1.SubItems.Add("Thành viên");
                    }
                    listView2.Items.Add(lv1);
                }


            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                listView2.Items.Clear();

                foreach (var s in _pm.GetAll())
                {
                    if (s.Tinhtrang == 1 && s.Iddocgia == null)
                    {

                        ListViewItem lv1 = new ListViewItem(s.Tendocgia);
                        lv1.SubItems.Add(s.Sdt);

                        lv1.SubItems.Add("Khách lẻ");


                        listView2.Items.Add(lv1);
                    }


                }
            }
            if (comboBox3.SelectedIndex == 1)
            {
                listView2.Items.Clear();

                foreach (var s in _pm.GetAll())
                {
                    if (s.Tinhtrang == 1 && s.Iddocgia != null)
                    {

                        ListViewItem lv1 = new ListViewItem(s.Tendocgia);

                        lv1.SubItems.Add(s.Sdt);
                        lv1.SubItems.Add("Thành viên");


                        listView2.Items.Add(lv1);
                    }


                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            loatData1(_pm.GetSearch(textBox6.Text, comboBox3.Text));
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {

                ListViewItem lv = listView2.SelectedItems[0];
                string tendocgia = lv.SubItems[0].Text;
                string sdt = lv.SubItems[1].Text;
                string vaitro = lv.SubItems[2].Text;
                if (vaitro == "Khách lẻ")
                {
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    textBox7.Enabled = false;
                    txtsdt.Enabled = false;
                    textBox7.Text = tendocgia;
                    txtsdt.Text = sdt;
                    comboBox2.Items.Clear();
                    foreach (var x in _pm.GetAll().Where(c => c.Tendocgia == tendocgia && c.Sdt == sdt && c.Iddocgia == null))
                    {
                        comboBox2.Items.Add(x.Id);
                        //comboBox1.Items.Add(x.Idphieumuon + " - " + x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
                    }/*foreach (var x in _pmct.Getview().Where(c => c.Tendocgia==tendocgia&&c.Sdt==sdt&& c.Iddocgia==null))
                    {
                        comboBox2.Items.Add(x.Idphieumuon);
                        //comboBox1.Items.Add(x.Idphieumuon + " - " + x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
                    }*/
                }
                else
                {
                    textBox1.Text = tendocgia;
                    textBox1.Enabled = false;
                    textBox7.Enabled = false;
                    txtsdt.Enabled = false;
                    textBox7.Text = "";
                    txtsdt.Text = sdt;
                    comboBox2.Items.Clear();
                    /*foreach (var x in _pmct.Getview().Where(c => c.Tendocgia == tendocgia && c.Sdt == sdt && c.Iddocgia != null))
                    {
                        comboBox2.Items.Add(x.Idphieumuon);
                        // comboBox1.Items.Add(x.Idphieumuon + " - " + x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
                    }*/
                    foreach (var x in _pm.GetAll().Where(c => c.Tendocgia == tendocgia && c.Sdt == sdt && c.Iddocgia != null))
                    {
                        comboBox2.Items.Add(x.Id);
                        // comboBox1.Items.Add(x.Idphieumuon + " - " + x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
                    }
                }

                comboBox1.ResetText();
                comboBox2.ResetText();


            }
        }
        int i = 0;
        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            var i = Convert.ToInt32(comboBox2.Text);
            comboBox1.Items.Clear();
            foreach (var x in _pmct.Getview().Where(c => c.Idphieumuon == i))
            {
                comboBox1.Items.Add(x.Tensach + " - " + x.Tennn + " - " + x.Tennxb + " - " + x.Lantaiban);
            }

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            var m = comboBox2.SelectedIndex;
            ListViewItem lv1 = new ListViewItem(comboBox2.Text);
            //THÊM CÁC Ô TIẾP THEo

            lv1.SubItems.Add(comboBox1.Text);
            lv1.SubItems.Add(textBox3.Text);
            listView1.Items.Add(lv1);
            comboBox1.ResetText();
            comboBox1.Items.RemoveAt(m);
            comboBox1.ResetText();
            //comboBox2.ResetText();
            //comboBox2.Items.Clear();

            textBox3.Text = "";
            listView2.Enabled = false;

        }


        string sachctclick = "";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem lv = listView1.SelectedItems[0];
                string idphieumuon = lv.SubItems[0].Text;
                string sachchitiet = lv.SubItems[1].Text;
                string ghichu = lv.SubItems[2].Text;
                sachctclick = lv.SubItems[1].Text;
                comboBox2.Text = idphieumuon;
                comboBox1.Text = sachchitiet;
                textBox3.Text = ghichu;


                btnXacnhan.Enabled = false;
                btnXoa.Enabled = true;
            }


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                comboBox1.ResetText();
                comboBox2.ResetText();
                textBox3.Text = "";
                listView2.Enabled = false;

                comboBox1.Items.Add(sachctclick);


            }
            /*else
            {
                listView2.Enabled = true;
            }*/
            btnXacnhan.Enabled = true;
            btnXoa.Enabled = false;
        }
        int x = 0;
        private void them_Click_1(object sender, EventArgs e)
        {
            var phieutra = new Phieutra();

            if (string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (cbxTennv.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên nhân viên");
                    return;
                }
                else
                {
                    phieutra.Iddocgia = null;
                    phieutra.Tendocgia = textBox7.Text;
                    phieutra.Sdt = txtsdt.Text;
                    phieutra.Idnhanvien = _nv.GetAll().ElementAt(cbxTennv.SelectedIndex).Id;


                    phieutra.Ngaytra = dtpNgaymuon.Value;
                    if (textBox4.Text == "")
                    {
                        phieutra.Tienphat = 0;
                    }
                    else
                    {
                        phieutra.Tienphat = Convert.ToDecimal(textBox4.Text);
                    }

                    phieutra.Lydophat = textBox2.Text;
                    if (txtTiencoc.Text == "")
                    {
                        phieutra.Hoancoc = 0;
                    }
                    else
                    {
                        phieutra.Hoancoc = Convert.ToDecimal(txtTiencoc.Text);
                    }
                    _ptservice.add(phieutra);
                    x = phieutra.Id;
                    if (listView1.Items.Count == 0)
                    {
                        MessageBox.Show("Phiếu trả chưa có thông tin sách trả");
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
                                //  ListViewItem lv = listView1.Items[i];
                                int idpm = Convert.ToInt16(lv.SubItems[0].Text);
                                string y = lv.SubItems[1].Text;



                                foreach (var item in _pmct.Getview())
                                {
                                    if (item.Idphieumuon == idpm && (item.Tensach + " - " + item.Tennn + " - " + item.Tennxb + " - " + item.Lantaiban).ToString() == y)
                                    {
                                        var pt = new Phieutract();
                                        pt.Idphieutra = x;
                                        pt.Idphieumuonct = item.Id;
                                        pt.Ghichu = lv.SubItems[2].Text;

                                        _ptct.add(pt);

                                    }
                                }
                                MessageBox.Show("Trả sách thành công");
                                comboBox1.ResetText();
                                textBox7.Text = "";
                                txtsdt.Text = "";
                                cbxTennv.ResetText();
                                txtTiencoc.Text = "";
                                textBox4.Text = "";
                                listView1.Items.Clear();

                            }
                        }

                    }
                }

            }
            else if (!string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox7.Text))
            {
                if (cbxTennv.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên nhân viên");
                    return;
                }
                else
                {
                    var IDclick = _pm.GetAll().Where(x => x.Tendocgia == textBox1.Text && x.Sdt == txtsdt.Text).ToList();
                    phieutra.Iddocgia = IDclick.ElementAt(0).Id;
                    phieutra.Tendocgia = textBox1.Text;
                    phieutra.Sdt = txtsdt.Text;
                    phieutra.Idnhanvien = _nv.GetAll().ElementAt(cbxTennv.SelectedIndex).Id;
                    _ptservice.add(phieutra);
                    x = phieutra.Id;
                    if (listView1.Items.Count == 0)
                    {
                        MessageBox.Show("Phiếu trả chưa có thông tin sách trả");
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

                                int idpm = Convert.ToInt16(lv.SubItems[0].Text);
                                string y = lv.SubItems[1].Text;
                                foreach (var item in _pmct.Getview())
                                {
                                    if (lv.SubItems[0].Text == "" || lv.SubItems[1].Text == "")
                                    {
                                        MessageBox.Show("Không được để trống tên sách");
                                        return;
                                    }
                                    else
                                    {
                                        if (item.Idphieumuon == idpm && (item.Tensach + " - " + item.Tennn + " - " + item.Tennxb + " - " + item.Lantaiban).ToString() == y)
                                        {
                                            var pt = new Phieutract();
                                            pt.Idphieutra = x;
                                            pt.Idphieumuonct = item.Id;
                                            pt.Ghichu = lv.SubItems[2].Text;

                                            _ptct.add(pt);

                                        }
                                        MessageBox.Show("Trả sách thành công");
                                    }
                                }
                            }
                        }
                    }
                    comboBox1.ResetText();
                    textBox7.Text = "";
                    txtsdt.Text = "";
                    cbxTennv.ResetText();
                    txtTiencoc.Text = "";
                    textBox4.Text = "";
                    listView1.Items.Clear();
                    phieutra.Ngaytra = dtpNgaymuon.Value;
                    phieutra.Tienphat = Convert.ToDecimal(textBox4.Text);
                    phieutra.Lydophat = textBox2.Text;
                    phieutra.Hoancoc = null;
                    // phieutra.Tinhtrangtra = 0;
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập tên độc giả");
            }





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien1();
            f.Show();
        }
    }
}

