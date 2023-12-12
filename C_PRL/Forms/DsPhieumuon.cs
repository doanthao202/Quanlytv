using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class DsPhieumuon : Form
    {
        PhieumuonService _phieumuonService = new PhieumuonService();
        PhieumuonctService _PhieumuonctService = new PhieumuonctService();
        PhieutractService _phieutractService = new PhieutractService();
        int idclick = -1;
        public DsPhieumuon()
        {
            _PhieumuonctService = new PhieumuonctService();
            _phieutractService = new PhieutractService();
            _phieumuonService = new PhieumuonService();
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void loatData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Stt";
            dataGridView1.Columns[1].Name = "Id phiếu mượn";
            dataGridView1.Columns[2].Name = "Tên độc giả";
            dataGridView1.Columns[3].Name = "SĐT";
            dataGridView1.Columns[4].Name = "Ngày mượn";
            dataGridView1.Columns[5].Name = "Ngày trả dự kiến";
            dataGridView1.Columns[6].Name = "Kiểu độc giả";


            foreach (var nv in data)
            {
                string x;
                if (nv.Iddocgia == null)
                {
                    x = "Khách lẻ";
                }
                else
                {
                    x = "Thành viên";
                }
                dataGridView1.Rows.Add(stt++, nv.Id, nv.Tendocgia, nv.Sdt, nv.Ngaymuon, nv.Ngaytradukien, x);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dataGridView1.Rows[index];
            dateTimePicker1.Value = Convert.ToDateTime(selectChild.Cells[5].Value.ToString());
            idclick = Convert.ToInt32(selectChild.Cells[1].Value);
            bntGiahan.Enabled = true;
            // btnxOA.Enabled = true;
        }

        private void DsPhieumuon_Load(object sender, EventArgs e)
        {
            loatData(_phieumuonService.GetAll());
            //btnxOA.Enabled = false;
            bntGiahan.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dataGridView1.Rows[index];
            dateTimePicker1.Value = Convert.ToDateTime(selectChild.Cells[5].Value.ToString());
            idclick = Convert.ToInt32(selectChild.Cells[1].Value);
            bntGiahan.Enabled = true;
            //btnxOA.Enabled = true;


        }

        private void bntGiahan_Click(object sender, EventArgs e)
        {
            _phieumuonService.Update1(idclick, dateTimePicker1.Value);
            MessageBox.Show("Gia hạn phiếu mượn thành công ");
            loatData(_phieumuonService.GetAll());
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /* private void btnxOA_Click(object sender, EventArgs e)
         {
             var x = 0;
             var y = 0;
             foreach (var i in _PhieumuonctService.GetAll())
             {
                 if (i.Idphieumuon == idclick)
                 {
                     x = 1;
                     y = i.Id;
                     continue;
                 }

             }
             var ent = 0;
             var f = 0;
             foreach (var i in _phieutractService.GetAll())
             {
                 if (i.Idphieumuonct == y)
                 {
                     ent = 1;
                     f = i.Id;
                     *//*_phieutractService.Delete(i.Id);*//*
                 }

             }
             if (x == 1 || ent ==1)
             {

                 var thongBao = MessageBox.Show("Bạn có muốn xóa phiếu mượn này không?", "Xác nhận", MessageBoxButtons.YesNo);
                 if (thongBao == DialogResult.Yes)
                 {
                     _phieutractService.Delete(f);

                     _PhieumuonctService.Delete1(y);
                     var result = _phieumuonService.Delete(idclick);
                     if (result)
                     {

                         MessageBox.Show("Xóa thành công");
                         loatData(_phieumuonService.GetAll());
                     }

                     else
                     {
                         MessageBox.Show("Xóa thất bại");
                     }
                 }
             }
             else
             {

                 var result = _phieumuonService.Delete(idclick);
                 if (result)
                 {
                     MessageBox.Show("Xóa thành công");
                     loatData(_phieumuonService.GetAll());
                 }
                 else
                 {
                     MessageBox.Show("Xóa thất bại");
                 }
             }
             loatData(_phieumuonService.GetAll());
             dateTimePicker1.Value = DateTime.Now;
         }
 */
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_phieumuonService.GetSearch1(textBox1.Text));
        }
    }
}
