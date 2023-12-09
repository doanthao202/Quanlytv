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
    public partial class Theloai1 : Form
    {
        Theloaiservi _service = new Theloaiservi();
        Sachservice _sachservice = new Sachservice();
        int idCellClick = -1;
        public Theloai1()
        {
            _sachservice = new Sachservice();
            _service = new Theloaiservi();
            InitializeComponent();
        }

        private void Theloai_Load(object sender, EventArgs e)
        {
            // dgv.DataSource = _service.GetAll();
            loatData(_service.GetAll());
            sua.Enabled = false;
            Xoa.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_service.GetSearch(textBox1.Text));
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            txtVitri.Text = selectChild.Cells[3].Value.ToString();

            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            sua.Enabled = true;
          
            
                Xoa.Enabled = true;
            
        }
        public void loatData(dynamic data)
        {
            dgv.Rows.Clear();
            int stt = 1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Stt";
            dgv.Columns[1].Name = "Id thể loại";
            dgv.Columns[2].Name = "Tên thể loại";
            dgv.Columns[3].Name = "Vị trí";

            foreach (var theloai in data)
            {
                dgv.Rows.Add(stt++, theloai.Id, theloai.Tentheloai, theloai.Vitri);
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dgv.Rows[index];//lấy data từ index được chọn
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            txtVitri.Text = selectChild.Cells[3].Value.ToString();

            idCellClick = Convert.ToInt32(selectChild.Cells[1].Value);//lấy id khi select 1 row
            them.Enabled = false;
            sua.Enabled = true;
            
                Xoa.Enabled = true;
            
        }
        public void reset()
        {
            txtTentl.Text = "";
            txtVitri.Text = "";
            idCellClick = -1;
            them.Enabled = true;
            sua.Enabled = false;
            Xoa.Enabled = false;
        }
        private void them_Click(object sender, EventArgs e)
        {


            var tl = new Theloai();
            tl.Tentheloai = txtTentl.Text; ;
            tl.Vitri = txtVitri.Text;

            
                MessageBox.Show(_service.add(tl));
                loatData(_service.GetAll());
                reset();
            
          


        }
        private void sua_Click(object sender, EventArgs e)
        {



            var result = _service.Update(idCellClick, new Theloai()
            {
                Tentheloai = txtTentl.Text,
                Vitri = txtVitri.Text

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                loatData(_service.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên thể loại không được để trống");
                loatData(_service.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void Xoa_Click_1(object sender, EventArgs e)
        {
            var x = 0;
            foreach (var i in _sachservice.GetAll())
            {
                if (i.Idtheloai==idCellClick)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                var thongBao = MessageBox.Show("Đã có sách thuộc thể loại này.Bạn có muốn xóa thể loại này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (thongBao == DialogResult.Yes)
                {
                    _sachservice.Delete1(idCellClick);
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
                }
            }
            else
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
            }
            reset();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Giaodien1();
            f.Show();
        }
    }



}

