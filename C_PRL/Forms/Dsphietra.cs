using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Repository;
using B_BUS.Services;
using Syncfusion.XlsIO.Implementation.XmlSerialization;

namespace C_PRL.Forms
{
    public partial class Dsphietra : Form
    {
        PhieutractService _ptct = new PhieutractService();
        Phieutraservice _pt = new Phieutraservice();
        PhieumuonctService _pmct = new PhieumuonctService();
        int idWhenclick = -1;
        public Dsphietra()
        {
            _pmct = new PhieumuonctService();
            _ptct = new PhieutractService();
            _pt = new Phieutraservice();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dataGridView1.Rows[index];
            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            loatData1(_pmct.Getview2(idWhenclick));
        }

        public void loatData1(dynamic data)
        {
            dataGridView2.Rows.Clear();
            int stt = 1;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Stt";
            dataGridView2.Columns[1].Name = "Tên sách";
            dataGridView2.Columns[2].Name = "Tên ngôn ngữ";
            dataGridView2.Columns[3].Name = "Tên NXB";
            dataGridView2.Columns[4].Name = "Lần tái bản";
            //dataGridView2.Columns[5].Name = "Id phiếu trả ct";


            foreach (var nv in data)
            {

                dataGridView2.Rows.Add(stt++, nv.Tensach, nv.Tennn, nv.Lantaiban, nv.Id);
            }
        }
        public void loatData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Stt";
            dataGridView1.Columns[1].Name = "Id phiếu trả";
            dataGridView1.Columns[2].Name = "Tên độc giả";
            dataGridView1.Columns[3].Name = "SĐT";
            dataGridView1.Columns[4].Name = "Ngày trả";
            dataGridView1.Columns[5].Name = "Kiểu độc giả";


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
                dataGridView1.Rows.Add(stt++, nv.Id, nv.Tendocgia, nv.Sdt, nv.Ngaytra, x);
            }

        }
        private void Dsphietra_Load(object sender, EventArgs e)
        {
            loatData(_pt.GetAll());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectChild = dataGridView1.Rows[index];
            idWhenclick = Convert.ToInt32(selectChild.Cells[1].Value);
            loatData1(_pmct.Getview2(idWhenclick));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loatData(_pt.GetSearch(textBox1.Text));
        }
    }
}
