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
    public partial class Thongke : Form
    {
        PhieumuonService _pm = new PhieumuonService();
        PhieumuonctService _phieumuonctService = new PhieumuonctService();
        public Thongke()
        {
            _phieumuonctService = new PhieumuonctService();
            _pm = new PhieumuonService();
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            loatData(_phieumuonctService.Getview1());
        }

        public void loatData(dynamic data)
        {

            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "ID phiếu mượn";
            dataGridView1.Columns[2].Name = "Tên độc giả";
            dataGridView1.Columns[3].Name = "Sđt";
            dataGridView1.Columns[4].Name = "Ngày mượn";
            dataGridView1.Columns[5].Name = "Ngày trả dự kiến";
            dataGridView1.Columns[6].Name = "Kiểu độc giả";
           
            dataGridView1.Columns[7].Name = "Số lượng sách chưa trả";
            var i = 0;

            var y = "";
            foreach (var s in data)
            {
                if (s.Iddocgia == null)
                {
                    y = "Khách lẻ";
                }
                else
                {
                    y = "Thành viên";
                }

                dataGridView1.Rows.Add(stt++, s.Idphieumuon, s.Tendocgia, s.Sdt, s.Ngaymuon, s.Ngaytradukien, y,  s.soluong);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
