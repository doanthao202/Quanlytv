﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.Services;
using Syncfusion.XlsIO;
using Microsoft.Office.Interop.Excel;
//using as1 = Microsoft.Office.Interop.Excel.Application;

namespace C_PRL.Forms
{
    public partial class Thongke : Form
    {
        PhieumuonService _pm = new PhieumuonService();
        PhieumuonctService _phieumuonctService = new PhieumuonctService();
        PhieutractService _phieutractService = new PhieutractService();
        public Thongke()
        {
            _phieutractService = new PhieutractService();
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
            //var i = 0;

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

                dataGridView1.Rows.Add(stt++, s.Idphieumuon, s.Tendocgia, s.Sdt, s.Ngaymuon, s.Ngaytradukien, y/*, s.Tinhtrang, s.Idphieumuonct, s.Idphieutract*/, s.soluong);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Random random = new Random();
        int r;
        private void vButton1_Click(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                r = random.Next(1, 10000);
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];
                    //Adding text to a cell
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Range[1, i].Text = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Range[i + 2, j + 1].Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    Stream excelstream = File.Create(Path.GetFullPath(@"D:\New folder\Xuatfile(" + r + ").xlsx"));
                    workbook.SaveAs(excelstream);
                    excelstream.Dispose();
                    MessageBox.Show("Xuất file thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xuất file thất bại");
            }

        }
    }
}
