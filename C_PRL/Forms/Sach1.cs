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
    public partial class Sach1 : Form
    {
        Sachservice _service = new Sachservice();
        Theloaiservi _tlservice = new Theloaiservi();
       
        int idCellClick = -1;
        public Sach1()
        {
            _service = new Sachservice();
            _tlservice = new Theloaiservi();
            InitializeComponent();
            
        }

        private void Sach1_Load(object sender, EventArgs e)
        {
            loatData(_service.GetAll());
            foreach(var item in _tlservice.GetAll())
            {
                cbxTheloai.Items.Add(item.Tentheloai);
            }
        }
        public void reset()
        {
            txtTensach.Text = "";
            txtNam.Text = "";
            idCellClick = -1;
            dateTimePicker1.Value = DateTime.Now;
            cbxTheloai.ResetText();
            them.Enabled = true;
        }
       /* public void loatData(dynamic data,dynamic data1)
        {
            //var theloai=  //_tlservice.GetById(cbxTheloai.Text).Id;
            dgv.Rows.Clear();
            int stt = 1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "Stt";
            dgv.Columns[1].Name = "Mã sách";
            dgv.Columns[2].Name = "Tên sách";
            dgv.Columns[3].Name = "Ngày nhập";
            dgv.Columns[4].Name = "Năm xuất bản";
            dgv.Columns[5].Name = "Tên thể loại";
            //dgv.Columns[6].Name = "Tên thể loại";

            foreach (var s in data)
            {
                int x = s.Idtheloai;
                string m = data1.GetTheloaiByName(x);
                dgv.Rows.Add(stt++, s.Id, s.Tensach, s.Ngaynhap, s.Namxuatban,m);
            }

        }*/
        public void loatData(dynamic data)
        {
            //var theloai=  //_tlservice.GetById(cbxTheloai.Text).Id;
            dgv.Rows.Clear();
            int stt = 1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "Stt";
            dgv.Columns[1].Name = "Mã sách";
            dgv.Columns[2].Name = "Tên sách";
            dgv.Columns[3].Name = "Ngày nhập";
            dgv.Columns[4].Name = "Năm xuất bản";
            dgv.Columns[5].Name = "Tên thể loại";
            //dgv.Columns[6].Name = "Tên thể loại";

            foreach (var s in data)
            {
               
                dgv.Rows.Add(stt++, s.Id, s.Tensach, s.Ngaynhap, s.Namxuatban, s.Idtheloai);
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn
            txtTensach.Text = selectChild.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(selectChild.Cells[3].Value.ToString());
            txtNam.Text = selectChild.Cells[4].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn
            txtTensach.Text = selectChild.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(selectChild.Cells[3].Value.ToString());
            txtNam.Text = selectChild.Cells[4].Value.ToString();
            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
           
            them.Enabled = false;
        }

        private void them_Click(object sender, EventArgs e)
        {
            var s1 = new Sach();
            s1.Tensach = txtTensach.Text;
            s1.Ngaynhap = dateTimePicker1.Value.Date;
            s1.Namxuatban = Convert.ToInt32(txtNam.Text);
            s1.Idtheloai = _tlservice.GetById(cbxTheloai.Text).Id;
            var thongBao = MessageBox.Show("Xác nhận thêm sách", "Xác nhận", MessageBoxButtons.YesNo);
            if (thongBao == DialogResult.Yes)
            {
                MessageBox.Show(_service.add(s1));
                //loatData(_service.GetAll(),_tlservice);
                loatData(_service.GetAll());
                reset();
            }
            else
            {
                return;
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            var result = _service.Update(idCellClick, new Sach()
            {
                Tensach = txtTensach.Text,
                Ngaynhap = dateTimePicker1.Value.Date,
                Namxuatban = Convert.ToInt32(txtNam.Text),
                Idtheloai = 1,

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                loatData(_service.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                loatData(_service.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var result = _service.Delete(idCellClick);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                loatData(_service.GetAll());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_service.GetSearch(textBox1.Text));
        }
    }
}
