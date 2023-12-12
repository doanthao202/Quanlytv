namespace C_PRL.Forms
{
    partial class Phieumuonsach
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
            components = new System.ComponentModel.Container();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            lvid = new ColumnHeader();
            lvSach = new ColumnHeader();
            lvghichu = new ColumnHeader();
            btnXoa = new Button();
            btnXacnhan = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            cbxDocgia = new GroupBox();
            txtsdt = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            cbxTennv = new ComboBox();
            label10 = new Label();
            datengaytra = new DateTimePicker();
            cbxTenthanhvien = new ComboBox();
            label5 = new Label();
            txtTenkhachle = new TextBox();
            label9 = new Label();
            cbxKieudocgia = new ComboBox();
            label8 = new Label();
            txtDocgia = new Label();
            dtpNgaymuon = new DateTimePicker();
            txtTiencoc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            thoat = new Button();
            them = new Button();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            cbxDocgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacnhan);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.LightSeaGreen;
            groupBox2.Location = new Point(176, 360);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(837, 361);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách mượn";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvid, lvSach, lvghichu });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(98, 123);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(668, 228);
            listView1.TabIndex = 33;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lvid
            // 
            lvid.Text = "ID sách";
            lvid.Width = 80;
            // 
            // lvSach
            // 
            lvSach.Text = "Chi tiết sách";
            lvSach.Width = 300;
            // 
            // lvghichu
            // 
            lvghichu.Text = "Ghi chú";
            lvghichu.Width = 200;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Peru;
            btnXoa.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Transparent;
            btnXoa.Location = new Point(503, 79);
            btnXoa.Margin = new Padding(5, 4, 5, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 36);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.BackColor = Color.Peru;
            btnXacnhan.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacnhan.ForeColor = Color.Transparent;
            btnXacnhan.Location = new Point(226, 79);
            btnXacnhan.Margin = new Padding(5, 4, 5, 4);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(144, 36);
            btnXacnhan.TabIndex = 37;
            btnXacnhan.Text = "Thêm sách mượn";
            btnXacnhan.UseVisualStyleBackColor = false;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 28);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(323, 28);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 39);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 13;
            label4.Text = "Sách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(523, 39);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 15;
            label6.Text = "Ghi chú:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(591, 35);
            textBox3.Margin = new Padding(5, 4, 5, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 29);
            textBox3.TabIndex = 16;
            // 
            // cbxDocgia
            // 
            cbxDocgia.Controls.Add(txtsdt);
            cbxDocgia.Controls.Add(label7);
            cbxDocgia.Controls.Add(textBox2);
            cbxDocgia.Controls.Add(label12);
            cbxDocgia.Controls.Add(cbxTennv);
            cbxDocgia.Controls.Add(label10);
            cbxDocgia.Controls.Add(datengaytra);
            cbxDocgia.Controls.Add(cbxTenthanhvien);
            cbxDocgia.Controls.Add(label5);
            cbxDocgia.Controls.Add(txtTenkhachle);
            cbxDocgia.Controls.Add(label9);
            cbxDocgia.Controls.Add(cbxKieudocgia);
            cbxDocgia.Controls.Add(label8);
            cbxDocgia.Controls.Add(txtDocgia);
            cbxDocgia.Controls.Add(dtpNgaymuon);
            cbxDocgia.Controls.Add(txtTiencoc);
            cbxDocgia.Controls.Add(label2);
            cbxDocgia.Controls.Add(label3);
            cbxDocgia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDocgia.ForeColor = Color.LightSeaGreen;
            cbxDocgia.Location = new Point(176, 108);
            cbxDocgia.Margin = new Padding(3, 4, 3, 4);
            cbxDocgia.Name = "cbxDocgia";
            cbxDocgia.Padding = new Padding(3, 4, 3, 4);
            cbxDocgia.Size = new Size(837, 244);
            cbxDocgia.TabIndex = 80;
            cbxDocgia.TabStop = false;
            cbxDocgia.Text = "Thông tin phiếu mượn";
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtsdt.Location = new Point(684, 89);
            txtsdt.Margin = new Padding(5, 4, 5, 4);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(143, 27);
            txtsdt.TabIndex = 34;
            txtsdt.TextChanged += txtsdt_TextChanged;
            txtsdt.KeyPress += txtsdt_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(553, 93);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 19);
            label7.TabIndex = 33;
            label7.Text = "Sdt:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(686, 196);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(550, 200);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 19);
            label12.TabIndex = 30;
            label12.Text = "Phí mượn sách:";
            // 
            // cbxTennv
            // 
            cbxTennv.FormattingEnabled = true;
            cbxTennv.Location = new Point(112, 83);
            cbxTennv.Margin = new Padding(3, 4, 3, 4);
            cbxTennv.Name = "cbxTennv";
            cbxTennv.Size = new Size(124, 28);
            cbxTennv.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(553, 138);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(125, 19);
            label10.TabIndex = 27;
            label10.Text = "Ngày trả dự kiến:";
            label10.Click += label10_Click;
            // 
            // datengaytra
            // 
            datengaytra.CustomFormat = "dd/MM/yyyy";
            datengaytra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datengaytra.Format = DateTimePickerFormat.Custom;
            datengaytra.Location = new Point(686, 133);
            datengaytra.Margin = new Padding(3, 4, 3, 4);
            datengaytra.Name = "datengaytra";
            datengaytra.Size = new Size(141, 27);
            datengaytra.TabIndex = 26;
            datengaytra.ValueChanged += datengaytra_ValueChanged_1;
            // 
            // cbxTenthanhvien
            // 
            cbxTenthanhvien.FormattingEnabled = true;
            cbxTenthanhvien.Location = new Point(387, 36);
            cbxTenthanhvien.Margin = new Padding(3, 4, 3, 4);
            cbxTenthanhvien.Name = "cbxTenthanhvien";
            cbxTenthanhvien.Size = new Size(146, 28);
            cbxTenthanhvien.TabIndex = 25;
            cbxTenthanhvien.SelectedIndexChanged += cbxTenthanhvien_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(259, 40);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 24;
            label5.Text = "Tên thành viên:";
            // 
            // txtTenkhachle
            // 
            txtTenkhachle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenkhachle.Location = new Point(684, 40);
            txtTenkhachle.Margin = new Padding(5, 4, 5, 4);
            txtTenkhachle.Name = "txtTenkhachle";
            txtTenkhachle.Size = new Size(143, 27);
            txtTenkhachle.TabIndex = 23;
            txtTenkhachle.KeyPress += txtTenkhachle_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(11, 87);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 19);
            label9.TabIndex = 22;
            label9.Text = "Tên nhân viên:";
            // 
            // cbxKieudocgia
            // 
            cbxKieudocgia.FormattingEnabled = true;
            cbxKieudocgia.Location = new Point(112, 33);
            cbxKieudocgia.Margin = new Padding(3, 4, 3, 4);
            cbxKieudocgia.Name = "cbxKieudocgia";
            cbxKieudocgia.Size = new Size(124, 28);
            cbxKieudocgia.TabIndex = 21;
            cbxKieudocgia.SelectedIndexChanged += cbxKieudocgia_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(11, 196);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 20;
            label8.Text = "Tiền cọc:";
            // 
            // txtDocgia
            // 
            txtDocgia.AutoSize = true;
            txtDocgia.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocgia.ForeColor = Color.Black;
            txtDocgia.Location = new Point(550, 45);
            txtDocgia.Margin = new Padding(5, 0, 5, 0);
            txtDocgia.Name = "txtDocgia";
            txtDocgia.Size = new Size(99, 19);
            txtDocgia.TabIndex = 17;
            txtDocgia.Text = "Tên khách lẻ:";
            // 
            // dtpNgaymuon
            // 
            dtpNgaymuon.CustomFormat = "dd/MM/yyyy";
            dtpNgaymuon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaymuon.Format = DateTimePickerFormat.Custom;
            dtpNgaymuon.Location = new Point(109, 133);
            dtpNgaymuon.Margin = new Padding(3, 4, 3, 4);
            dtpNgaymuon.Name = "dtpNgaymuon";
            dtpNgaymuon.Size = new Size(127, 27);
            dtpNgaymuon.TabIndex = 16;
            dtpNgaymuon.ValueChanged += dtpNgaymuon_ValueChanged;
            // 
            // txtTiencoc
            // 
            txtTiencoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiencoc.Location = new Point(109, 192);
            txtTiencoc.Margin = new Padding(5, 4, 5, 4);
            txtTiencoc.Name = "txtTiencoc";
            txtTiencoc.Size = new Size(127, 27);
            txtTiencoc.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 40);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 13;
            label2.Text = "Kiểu độc giả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 141);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 15;
            label3.Text = "Ngày mượn:";
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.ForeColor = Color.Red;
            thoat.Location = new Point(604, 747);
            thoat.Margin = new Padding(5, 4, 5, 4);
            thoat.Name = "thoat";
            thoat.Size = new Size(69, 36);
            thoat.TabIndex = 79;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // them
            // 
            them.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            them.ForeColor = Color.Red;
            them.Location = new Point(176, 747);
            them.Margin = new Padding(5, 4, 5, 4);
            them.Name = "them";
            them.Size = new Size(208, 36);
            them.TabIndex = 77;
            them.Text = "Thêm phiếu mượn";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(421, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 76;
            label1.Text = "PHIẾU MƯỢN";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(447, 747);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(87, 36);
            button3.TabIndex = 86;
            button3.Text = "Gia hạn";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(785, 747);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(227, 36);
            button1.TabIndex = 87;
            button1.Text = "Xem danh sách phiếu mượn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Phieumuonsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 888);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(cbxDocgia);
            Controls.Add(thoat);
            Controls.Add(them);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Phieumuonsach";
            Text = "Phieumuonsach";
            Load += Phieumuonsach_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            cbxDocgia.ResumeLayout(false);
            cbxDocgia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnXacnhan;
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private GroupBox cbxDocgia;
        private TextBox txtTenkhachle;
        private Label label9;
        private ComboBox cbxKieudocgia;
        private Label label8;
        private Label txtDocgia;
        private DateTimePicker dtpNgaymuon;
        private TextBox txtTiencoc;
        private Label label2;
        private Label label3;
        private Button thoat;
        private Button them;
        private Label label1;
        private ComboBox cbxTenthanhvien;
        private Label label5;
        private ComboBox cbxTennv;
        private Label label10;
        private DateTimePicker datengaytra;
        private Button button3;
        private TextBox textBox2;
        private Label label12;
        private ListView listView1;
        private ColumnHeader lvid;
        private ColumnHeader lvSach;
        private ColumnHeader lvghichu;
        private TextBox txtsdt;
        private Label label7;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}