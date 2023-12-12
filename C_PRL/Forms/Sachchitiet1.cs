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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL
{
    public partial class Sachchitiet1 : Form
    {
        SachctService _service = new SachctService();
        Ngonnguservice _nnservice = new Ngonnguservice();
        SachHangService _sachhangservie = new SachHangService();
        NxbService _nxbService = new NxbService();
        Sachservice _sservice = new Sachservice();
        HangService _hangservice = new HangService();
        PhieumuonctService _pm = new PhieumuonctService();
        int idCellClick = -1;
        public Sachchitiet1()
        {
            _pm = new PhieumuonctService();
            _sservice = new Sachservice();
            _service = new SachctService();
            _nxbService = new NxbService();
            _nnservice = new Ngonnguservice();
            _sachhangservie = new SachHangService();
            _hangservice = new HangService();
            InitializeComponent();
        }

        private void Sachchitiet1_Load(object sender, EventArgs e)
        {
            loatData(_service.Getview());
            foreach (var item in _sservice.GetAll())
            {
                cbxTensach.Items.Add(item.Tensach);
            }
            foreach (var item in _nnservice.GetAll())
            {
                cxbNgonngu.Items.Add(item.Tennn);
            }
            
            foreach (var item in _nxbService.GetAll())
            {
                cxbNXB.Items.Add(item.Tennxb);
            }
            foreach (var item in _hangservice.GetAll())
            {
                cxbHang.Items.Add(item.Tenhang);
            }
            cxbTinhtrang.Items.Add("Sách mới");
            cxbTinhtrang.Items.Add("Sách cũ");
            cxbTinhtrang.Items.Add("Dừng hoạt động");
            cxbTinhtrang.Text = "Sách mới";
            them.Enabled = true;
            
            Sua.Enabled = false;
            xoa.Enabled = false;

        }
        public void reset()
        {
            listView1.Items.Clear();
            cbxTensach.ResetText();
            cxbNgonngu.ResetText();
            cxbNXB.ResetText();
            cxbHang.ResetText();
            cxbTinhtrang.Text = "Sách mới";
            txtlantaiban.Text = "";
            txtGia.Text = "";
            txtTuoi.Text = "";
            them.Enabled = true;
            btnXacnhan.Enabled = true;
            btnXoa.Enabled = true;
            idCellClick = -1;
            Sua.Enabled = false;
            xoa.Enabled = false;

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void loatData(dynamic data)
        {

            dgv1.Rows.Clear();
            int stt = 1;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnCount = 9;
            dgv1.Columns[0].Name = "Stt";
            dgv1.Columns[1].Name = "Mã sách chi tiết";
            dgv1.Columns[2].Name = "Tên sách";
            dgv1.Columns[3].Name = "Tên ngôn ngữ";
            dgv1.Columns[4].Name = "Tên nxb";
            dgv1.Columns[5].Name = "Lần tái bản";
            dgv1.Columns[6].Name = "Giá sách";
            dgv1.Columns[7].Name = "Độ tuổi đọc sách";
            dgv1.Columns[8].Name = "Tình trạng";
            //dgv.Columns[6].Name = "Tên thể loại";


            foreach (var s in data)
            {

                dgv1.Rows.Add(stt++, s.Id, s.Tensach, s.Tennn, s.Tennxb, s.Lantaiban, s.Giasach, s.Dotuoidocsach, s.Tinhtrang);
            }

        }

        public void loatData1(dynamic data)
        {
            listView1.Items.Clear();

            foreach (var s in data)
            {
                ListViewItem lv1 = new ListViewItem(s.Tenhang);

                listView1.Items.Add(lv1);

            }

        }
        private void them_Click(object sender, EventArgs e)
        {
            int m = cbxTensach.SelectedIndex;
            int n = cxbNgonngu.SelectedIndex;
            int g = cxbNXB.SelectedIndex;
           
            if (cbxTensach.Text == ""||cxbNgonngu.Text==""||cxbNXB.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tên sách, tên ngôn ngữ, tên nhà xuất bản");
            }
            else
            {
                var s1 = new Sachchitiet();
                s1.Idsach = _sservice.GetAll().ElementAt(m).Id;
                s1.Idngonngu = _nnservice.GetAll().ElementAt(n).Id;
                s1.Idnxb = _nxbService.GetAll().ElementAt(g).Id;
                if (txtlantaiban.Text == "")
                {
                    s1.Lantaiban = null;
                }
                else
                {
                    s1.Lantaiban = Convert.ToInt32(txtlantaiban.Text);
                }
                if (txtGia.Text == "")
                {
                    s1.Giasach = null;
                }
                else
                {
                    s1.Giasach = Convert.ToDecimal(txtGia.Text);
                }
                if (txtTuoi.Text == "")
                {
                    s1.Dotuoidocsach = null;
                }
                else
                {
                    s1.Dotuoidocsach = Convert.ToInt32(txtTuoi.Text);
                }



                if (cxbTinhtrang.Text == "Sách mới")
                {
                    s1.Tinhtrang = 1;
                }
                else if (cxbTinhtrang.Text == "Sách cũ")
                {
                    s1.Tinhtrang = 2;
                }
                else if (cxbTinhtrang.Text == "Dừng hoạt động")
                {
                    s1.Tinhtrang = 0;
                }
                else
                {
                    s1.Tinhtrang = null;
                }



                MessageBox.Show(_service.add(s1));

                loatData(_service.Getview());

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem lv = listView1.Items[i];
                    string tenhang = lv.SubItems[0].Text;
                    var sachcthang = new SachctHang();
                    sachcthang.Idsachct = s1.Id;
                    sachcthang.Idhang = _hangservice.GetById(tenhang).Id; ;


                    _sachhangservie.add(sachcthang);

                }
                reset();
            }

          




        }



        /*private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv1.Rows[index];//lấy data từ index được chọn
            cbxTensach.Text = selectChild.Cells[2].Value.ToString();
            cxbNgonngu.Text = selectChild.Cells[3].Value.ToString();
            cxbNXB.Text = selectChild.Cells[4].Value.ToString();
            txtlantaiban.Text = selectChild.Cells[5].Value.ToString();
            txtGia.Text = selectChild.Cells[6].Value.ToString();

            txtTuoi.Text = selectChild.Cells[7].Value.ToString();

            if (selectChild.Cells[8].Value.ToString() == "0")
            {
                cxbTinhtrang.Text = "Dừng hoạt động";
            }
            else if (selectChild.Cells[8].Value.ToString() == "1")
            {
                cxbTinhtrang.Text = "Sách mới";
            }
            else if (selectChild.Cells[8].Value.ToString() == "2")
            {
                cxbTinhtrang.Text = "Sách cũ";
            }
            else
            {
                cxbTinhtrang.ResetText();
            }
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            loatData1(_sachhangservie.Getview(idCellClick));
            them.Enabled = false;
            Sua.Enabled = true;

            xoa.Enabled = true;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn
            cbxTensach.Text = selectChild.Cells[2].Value.ToString();
            cxbNgonngu.Text = selectChild.Cells[3].Value.ToString();
            cxbNXB.Text = selectChild.Cells[4].Value.ToString();
            if (selectChild.Cells[5].Value == null)
            {
                txtlantaiban.Text = "";
            }
            else
            {
                txtlantaiban.Text = Convert.ToString(selectChild.Cells[5].Value);
            }
            if (selectChild.Cells[6].Value == null)
            {
                txtGia.Text = "";
            }
            else
            {
                txtGia.Text = Convert.ToString(selectChild.Cells[6].Value);
            }
            if (selectChild.Cells[7].Value == null)
            {
                txtTuoi.Text = "";
            }
            else
            {
                txtTuoi.Text = Convert.ToString(selectChild.Cells[7]);
            }



            if (selectChild.Cells[8].Value.ToString() == "0")
            {
                cxbTinhtrang.Text = "Dừng hoạt động";
            }
            else if (selectChild.Cells[8].Value.ToString() == "1")
            {
                cxbTinhtrang.Text = "Sách mới";
            }
            else if (selectChild.Cells[8].Value.ToString() == "2")
            {
                cxbTinhtrang.Text = "Sách cũ";
            }
            else
            {
                cxbTinhtrang.ResetText();
            }


*/
/*

            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            loatData1(_sachhangservie.Getview(idCellClick));

            them.Enabled = false;
            Sua.Enabled = true;

            xoa.Enabled = true;

        }*/

        private void xoa_Click(object sender, EventArgs e)
        {
            var x = 0;
            foreach (var i in _pm.GetAll())
            {
                if (i.Idsachct == idCellClick)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                var thongBao = MessageBox.Show("Sách đang được cho mượn, bạn có thực sự muốn xóa sách không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (thongBao == DialogResult.Yes)
                {
                    _pm.Delete1(idCellClick);
                    _sachhangservie.Delete(idCellClick);
                    var result = _service.Delete(idCellClick);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công");
                        loatData(_service.Getview());
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                _sachhangservie.Delete(idCellClick);
                var result = _service.Delete(idCellClick);
                if (result)
                {
                    MessageBox.Show("Xóa thành công");
                    loatData(_service.Getview());
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem lv = listView1.SelectedItems[0];
                string tenhang = lv.SubItems[0].Text;

                cxbHang.Text = tenhang;

                btnXacnhan.Enabled = false;
                btnXoa.Enabled = true;
            }

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(cxbHang.Text);
            //THÊM CÁC Ô TIẾP THEo

            listView1.Items.Add(lv1);
            cxbHang.ResetText();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                cxbHang.ResetText();


            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            _sachhangservie.Delete(idCellClick);

            string x = "";
            if (cxbTinhtrang.Text == "Sách mới")
            {
                x = "1";
            }
            else if (cxbTinhtrang.Text == "Sách cũ")
            {
                x = "2";
            }
            else
            {
                if (cxbTinhtrang.Text == "Dừng hoạt động")
                {
                    x = "0";
                }
            }

            int m = cbxTensach.SelectedIndex;
            int n = cxbNgonngu.SelectedIndex;
            int g = cxbNXB.SelectedIndex;
            var result = _service.Update(idCellClick, new Sachchitiet()
            {
                Idsach = _sservice.GetAll().ElementAt(m).Id,
                Idngonngu = _nnservice.GetAll().ElementAt(n).Id,
                Idnxb = _nxbService.GetAll().ElementAt(g).Id,
                Lantaiban = Convert.ToInt32(txtlantaiban.Text),
                Giasach = Convert.ToDecimal(txtGia.Text),
                Dotuoidocsach = Convert.ToInt32(txtTuoi.Text),
                Tinhtrang = Convert.ToInt32(x)

            });
            // _sachhangservie.Delete(idCellClick);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem lv = listView1.Items[i];
                string tenhang = lv.SubItems[0].Text;
                var sachcthang = new SachctHang();
                sachcthang.Idsachct = idCellClick;
                sachcthang.Idhang = _hangservice.GetById(tenhang).Id; ;


                _sachhangservie.add(sachcthang);

            }



            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                loatData(_service.Getview());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                loatData(_service.Getview());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_service.GetSearch1(textBox1.Text));
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv1.Rows[index];//lấy data từ index được chọn
            cbxTensach.Text = selectChild.Cells[2].Value.ToString();
            cxbNgonngu.Text = selectChild.Cells[3].Value.ToString();
            cxbNXB.Text = selectChild.Cells[4].Value.ToString();
            if (Convert.ToString(selectChild.Cells[5].Value) == null)
            {
                txtlantaiban.Text = "";
            }
            else
            {
                txtlantaiban.Text = Convert.ToString(selectChild.Cells[5].Value);
            }
            if (Convert.ToString(selectChild.Cells[6].Value) == null)
            {
                txtGia.Text = "";
            }
            else
            {
                txtGia.Text = Convert.ToString(selectChild.Cells[6].Value);
            }
            if (Convert.ToString(selectChild.Cells[7].Value) == null)
            {
                txtTuoi.Text = "";
            }
            else
            {
                txtTuoi.Text = Convert.ToString(selectChild.Cells[7].Value);
            }
            if (selectChild.Cells[8].Value.ToString() == "0")
            {
                cxbTinhtrang.Text = "Dừng hoạt động";
            }
            else if (selectChild.Cells[8].Value.ToString() == "1")
            {
                cxbTinhtrang.Text = "Sách mới";
            }
            else if (selectChild.Cells[8].Value.ToString() == "2")
            {
                cxbTinhtrang.Text = "Sách cũ";
            }
            else
            {
                cxbTinhtrang.ResetText();
            }
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            loatData1(_sachhangservie.Getview(idCellClick));
            them.Enabled = false;
            Sua.Enabled = true;

            xoa.Enabled = true;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv1.Rows[index];//lấy data từ index được chọn
            cbxTensach.Text = selectChild.Cells[2].Value.ToString();
            cxbNgonngu.Text = selectChild.Cells[3].Value.ToString();
            cxbNXB.Text = selectChild.Cells[4].Value.ToString();
            //txtlantaiban.Text = selectChild.Cells[5].Value.ToString();
            if (Convert.ToString(selectChild.Cells[5].Value) == null)
            {
                txtlantaiban.Text = "";
            }
            else
            {
                txtlantaiban.Text = Convert.ToString(selectChild.Cells[5].Value);
            }
            if (Convert.ToString(selectChild.Cells[6].Value)== null)
            {
                txtGia.Text = "";
            }
            else
            {
                txtGia.Text = Convert.ToString(selectChild.Cells[6].Value);
            }
            if (Convert.ToString(selectChild.Cells[7].Value) == null)
            {
                txtTuoi.Text = "";
            }
            else
            {
                txtTuoi.Text = Convert.ToString(selectChild.Cells[7].Value);
            }


            //txtTuoi.Text = selectChild.Cells[7].Value.ToString();

            if (selectChild.Cells[8].Value.ToString() == "0")
            {
                cxbTinhtrang.Text = "Dừng hoạt động";
            }
            else if (selectChild.Cells[8].Value.ToString() == "1")
            {
                cxbTinhtrang.Text = "Sách mới";
            }
            else if (selectChild.Cells[8].Value.ToString() == "2")
            {
                cxbTinhtrang.Text = "Sách cũ";
            }
            else
            {
                if (selectChild.Cells[8].Value.ToString() == null)
                {
                    cxbTinhtrang.Text = "";
                }
            }
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            loatData1(_sachhangservie.Getview(idCellClick));
            them.Enabled = false;
            Sua.Enabled = true;

            xoa.Enabled = true;
        }
    }
}
