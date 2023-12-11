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
    public partial class Danhsachphieumuon : Form
    {
        Sachservice _sach = new Sachservice();
        PhieumuonctService _phieumuonctService = new PhieumuonctService();
        Ngonnguservice _nn = new Ngonnguservice();
        NxbService _xbService = new NxbService();
        public Danhsachphieumuon()
        {
            _sach = new Sachservice();
            _phieumuonctService = new PhieumuonctService();
            _nn = new Ngonnguservice();
            _xbService = new NxbService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //loatData(_phieumuonctService.Getview3());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker2.MaxDate = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = (dateTimePicker2.Value.AddDays(-1));
        }
        public void loatData(dynamic data)
        {

            dataGridView1.Rows.Clear();
            int stt = 1;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Tên sách";
            dataGridView1.Columns[2].Name = "Ngôn ngữ";
            dataGridView1.Columns[3].Name = "NXB";
            dataGridView1.Columns[4].Name = "Lần tái bản";
            dataGridView1.Columns[5].Name = "Số lượng mượn sách";

            string x = "";
            string y = "";
            string z = "";

            foreach (var item in _phieumuonctService.Getview3())
            {
                foreach (var i in _sach.GetAll())
                {
                    if (item.Idsach == i.Id)
                    {
                        x = i.Tensach;
                    }
                }
            }
            foreach (var item in _phieumuonctService.Getview3())
            {
                foreach (var i in _nn.GetAll())
                {
                    if (item.Idnn == i.Id)
                    {
                        y = i.Tennn;
                    }
                }
            }
            foreach (var item in _phieumuonctService.Getview3())
            {
                foreach (var i in _xbService.GetAll())
                {
                    if (item.Idnn == i.Id)
                    {
                        z = i.Tennxb;
                    }
                }
            }
            foreach (var s in data)
            {


                dataGridView1.Rows.Add(stt++, x, y, z, s.Lantaiban, s.soluon);
            }
        }

        private void Danhsachphieumuon_Load(object sender, EventArgs e)
        {
            loatData(_phieumuonctService.Getview3());
        }
        Random random = new Random();
        int r;
    }
}
