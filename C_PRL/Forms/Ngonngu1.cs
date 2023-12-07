using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Models;
using B_BUS.Services;

namespace C_PRL.Forms
{
    public partial class NgonNgu1 : Form
    {
        Ngonnguservice _service = new Ngonnguservice();
        SachctService _sch = new SachctService();
        int idWhenClick = -1;
        public NgonNgu1()
        {
            _sch = new SachctService();
            _service = new Ngonnguservice();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData(dynamic data)
        {
            luoi.Rows.Clear();
            int stt = 1;
            luoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luoi.ColumnCount = 3;
            luoi.Columns[0].Name = "Stt";
            luoi.Columns[1].Name = "Mã ngôn ngữ";
            luoi.Columns[2].Name = "Tên ngôn ngữ";

            foreach (var ngonngu in data)
            {
                luoi.Rows.Add(stt++, ngonngu.Id, ngonngu.Tennn);
            }
        }
        public void reset()
        {
            txtTentl.Text = "";
            idWhenClick = -1;
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = false;
        }
        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            idWhenClick = Convert.ToInt32(selectChild.Cells[1].Value);
            sua.Enabled = true;
            them.Enabled = false;
            var x = 0;
            foreach (var i in _sch.GetAll())
            {
                if (idWhenClick == i.Idnxb)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                xoa.Enabled = false;
            }
            else
            {

                xoa.Enabled = true;
            }
        }

        private void luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            var selectChild = luoi.Rows[index];
            txtTentl.Text = selectChild.Cells[2].Value.ToString();
            idWhenClick = Convert.ToInt32(selectChild.Cells[1].Value);
            sua.Enabled = true;
            them.Enabled = false;
            var x = 0;
            foreach (var i in _sch.GetAll())
            {
                if (idWhenClick == i.Idnxb)
                {
                    x = 1;
                    continue;
                }

            }
            if (x == 1)
            {
                xoa.Enabled = false;
            }
            else
            {

                xoa.Enabled = true;
            }
        }

        private void NgonNgu1_Load(object sender, EventArgs e)
        {
            LoadData(_service.GetAll());
            sua.Enabled = false;
            xoa.Enabled = false;
        }

        private void them_Click(object sender, EventArgs e)
        {
            var nn = new Ngonngu();
            nn.Tennn = txtTentl.Text;

            MessageBox.Show(_service.add(nn));
            LoadData(_service.GetAll());
            reset();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            var result = _service.Update(idWhenClick, new Ngonngu()
            {
                Tennn = txtTentl.Text

            });
            if (result == 3)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_service.GetAll());
                reset();
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên không được để trống");
                LoadData(_service.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            reset();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            var result = _service.Delete(idWhenClick);
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                LoadData(_service.GetAll());
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
            Form f = new Giaodien1();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(_service.GetSearch(textBox1.Text));
        }
    }
}
