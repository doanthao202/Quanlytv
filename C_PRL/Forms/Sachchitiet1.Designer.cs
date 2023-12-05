
namespace C_PRL
{
    partial class Sachchitiet1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sua = new Button();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnXacnhan = new Button();
            cxbHang = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            txtTuoi = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cxbTinhtrang = new ComboBox();
            label6 = new Label();
            cxbNXB = new ComboBox();
            cxbNgonngu = new ComboBox();
            listView1 = new ListView();
            lvhang = new ColumnHeader();
            txtGia = new TextBox();
            label9 = new Label();
            cbxTensach = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtlantaiban = new TextBox();
            label2 = new Label();
            label3 = new Label();
            thoat = new Button();
            xoa = new Button();
            them = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // Sua
            // 
            Sua.Location = new Point(143, 392);
            Sua.Margin = new Padding(5, 4, 5, 4);
            Sua.Name = "Sua";
            Sua.Size = new Size(101, 36);
            Sua.TabIndex = 84;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacnhan);
            groupBox2.Controls.Add(cxbHang);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(600, 137);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(217, 195);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hạng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(117, 125);
            btnXoa.Margin = new Padding(5, 4, 5, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 36);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(8, 125);
            btnXacnhan.Margin = new Padding(5, 4, 5, 4);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(88, 36);
            btnXacnhan.TabIndex = 37;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // cxbHang
            // 
            cxbHang.FormattingEnabled = true;
            cxbHang.Location = new Point(19, 57);
            cxbHang.Margin = new Padding(3, 4, 3, 4);
            cxbHang.Name = "cxbHang";
            cxbHang.Size = new Size(174, 28);
            cxbHang.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 29);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 13;
            label4.Text = "Tên tác giả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 53);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 82;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 51);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên sách chi tiết";
            textBox1.Size = new Size(486, 27);
            textBox1.TabIndex = 81;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cxbTinhtrang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cxbNXB);
            groupBox1.Controls.Add(cxbNgonngu);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbxTensach);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtlantaiban);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(584, 299);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuoi.Location = new Point(415, 29);
            txtTuoi.Margin = new Padding(5, 4, 5, 4);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(161, 27);
            txtTuoi.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(294, 81);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 30;
            label11.Text = "Tình trạng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(294, 32);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(141, 21);
            label10.TabIndex = 29;
            label10.Text = "Độ tuội đọc sách:";
            // 
            // cxbTinhtrang
            // 
            cxbTinhtrang.FormattingEnabled = true;
            cxbTinhtrang.Location = new Point(415, 72);
            cxbTinhtrang.Margin = new Padding(3, 4, 3, 4);
            cxbTinhtrang.Name = "cxbTinhtrang";
            cxbTinhtrang.Size = new Size(161, 28);
            cxbTinhtrang.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 248);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 28;
            label6.Text = "Giá sách:";
            // 
            // cxbNXB
            // 
            cxbNXB.FormattingEnabled = true;
            cxbNXB.Location = new Point(111, 125);
            cxbNXB.Margin = new Padding(3, 4, 3, 4);
            cxbNXB.Name = "cxbNXB";
            cxbNXB.Size = new Size(143, 28);
            cxbNXB.TabIndex = 26;
            // 
            // cxbNgonngu
            // 
            cxbNgonngu.FormattingEnabled = true;
            cxbNgonngu.Location = new Point(111, 81);
            cxbNgonngu.Margin = new Padding(3, 4, 3, 4);
            cxbNgonngu.Name = "cxbNgonngu";
            cxbNgonngu.Size = new Size(143, 28);
            cxbNgonngu.TabIndex = 25;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvhang });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(431, 131);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(139, 151);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lvhang
            // 
            lvhang.Text = "Tên hạng";
            lvhang.Width = 120;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(111, 243);
            txtGia.Margin = new Padding(5, 4, 5, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(143, 27);
            txtGia.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 139);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 22;
            label9.Text = "NXB:";
            // 
            // cbxTensach
            // 
            cbxTensach.FormattingEnabled = true;
            cbxTensach.Location = new Point(111, 29);
            cbxTensach.Margin = new Padding(3, 4, 3, 4);
            cbxTensach.Name = "cbxTensach";
            cbxTensach.Size = new Size(143, 28);
            cbxTensach.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(294, 131);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 21);
            label8.TabIndex = 20;
            label8.Text = "Danh sách tác giả:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 84);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 17;
            label7.Text = "Ngôn ngữ:";
            // 
            // txtlantaiban
            // 
            txtlantaiban.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtlantaiban.Location = new Point(111, 183);
            txtlantaiban.Margin = new Padding(5, 4, 5, 4);
            txtlantaiban.Name = "txtlantaiban";
            txtlantaiban.Size = new Size(143, 27);
            txtlantaiban.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 29);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 13;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 193);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 15;
            label3.Text = "Lần tái bản:";
            // 
            // thoat
            // 
            thoat.Location = new Point(438, 392);
            thoat.Margin = new Padding(5, 4, 5, 4);
            thoat.Name = "thoat";
            thoat.Size = new Size(101, 36);
            thoat.TabIndex = 79;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(281, 392);
            xoa.Margin = new Padding(5, 4, 5, 4);
            xoa.Name = "xoa";
            xoa.Size = new Size(101, 36);
            xoa.TabIndex = 78;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // them
            // 
            them.Location = new Point(9, 392);
            them.Margin = new Padding(5, 4, 5, 4);
            them.Name = "them";
            them.Size = new Size(101, 36);
            them.TabIndex = 77;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(370, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 76;
            label1.Text = "Sách chi tiết";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(9, 436);
            dgv.Margin = new Padding(5, 4, 5, 4);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(824, 248);
            dgv.TabIndex = 75;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // Sachchitiet1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 717);
            Controls.Add(Sua);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(dgv);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sachchitiet1";
            Text = "Sachchitiet1";
            Load += Sachchitiet1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button Sua;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnXacnhan;
        private ComboBox cxbHang;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader lvhang;
        private TextBox txtGia;
        private Label label9;
        private ComboBox cbxTensach;
        private Label label8;
        private Label label7;
        private TextBox txtlantaiban;
        private Label label2;
        private Label label3;
        private Button thoat;
        private Button xoa;
        private Button them;
        private Label label1;
        private DataGridView dgv;
        private ComboBox cxbTinhtrang;
        private ComboBox cxbNXB;
        private ComboBox cxbNgonngu;
        private TextBox txtTuoi;
        private Label label11;
        private Label label10;
        private Label label6;
    }
}