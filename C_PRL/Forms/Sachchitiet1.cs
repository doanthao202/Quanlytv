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
        int idCellClick = -1;
        public Sachchitiet1()
        {
            _sservice = new Sachservice();
            _service = new SachctService();
            _nxbService = new NxbService();
            _nnservice = new Ngonnguservice();
            _sachhangservie = new SachHangService();
            InitializeComponent();
        }

        private void Sachchitiet1_Load(object sender, EventArgs e)
        {
            foreach (var item in _sservice.GetAll())
            {
               cbxTensach.Items.Add(item.Tensach);
            }
            foreach (var item in _nnservice.GetAll())
            {
               cxbNgonngu.Items.Add(item.Tennn);
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
            them.Enabled = true;

            Sua.Enabled = false;
            xoa.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cxbHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
