namespace C_PRL
{
    partial class Phieutrasach
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
            button1 = new Button();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnXoa = new Button();
            btnXacnhan = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            cbxDocgia = new GroupBox();
            textBox7 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            txtsdt = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            cbxTennv = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtDocgia = new Label();
            dtpNgaymuon = new DateTimePicker();
            txtTiencoc = new TextBox();
            label3 = new Label();
            thoat = new Button();
            them = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            comboBox3 = new ComboBox();
            textBox6 = new TextBox();
            label11 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            cbxDocgia.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(724, 574);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(199, 27);
            button1.TabIndex = 95;
            button1.Text = "Xem danh sách phiếu mượn";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacnhan);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(243, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 264);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách mượn";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 23);
            comboBox2.TabIndex = 40;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(28, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(615, 172);
            listView1.TabIndex = 33;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id phiếu mượn";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sách chi tiết";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ghi chú";
            columnHeader3.Width = 190;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(387, 59);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 27);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(192, 59);
            btnXacnhan.Margin = new Padding(4, 3, 4, 3);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(130, 27);
            btnXacnhan.TabIndex = 37;
            btnXacnhan.Text = "Trả sách";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 23);
            comboBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 13;
            label4.Text = "Sách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(436, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 15;
            label6.Text = "Ghi chú:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 22);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 16;
            // 
            // cbxDocgia
            // 
            cbxDocgia.Controls.Add(textBox7);
            cbxDocgia.Controls.Add(textBox1);
            cbxDocgia.Controls.Add(label10);
            cbxDocgia.Controls.Add(textBox4);
            cbxDocgia.Controls.Add(txtsdt);
            cbxDocgia.Controls.Add(label7);
            cbxDocgia.Controls.Add(textBox2);
            cbxDocgia.Controls.Add(label12);
            cbxDocgia.Controls.Add(cbxTennv);
            cbxDocgia.Controls.Add(label5);
            cbxDocgia.Controls.Add(label9);
            cbxDocgia.Controls.Add(label8);
            cbxDocgia.Controls.Add(txtDocgia);
            cbxDocgia.Controls.Add(dtpNgaymuon);
            cbxDocgia.Controls.Add(txtTiencoc);
            cbxDocgia.Controls.Add(label3);
            cbxDocgia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDocgia.Location = new Point(243, 115);
            cbxDocgia.Name = "cbxDocgia";
            cbxDocgia.Size = new Size(680, 183);
            cbxDocgia.TabIndex = 91;
            cbxDocgia.TabStop = false;
            cbxDocgia.Text = "Thông tin phiếu mượn";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(340, 29);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(129, 23);
            textBox7.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(115, 29);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(477, 80);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 16);
            label10.TabIndex = 37;
            label10.Text = "Lý do phạt:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(340, 78);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 35;
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtsdt.Location = new Point(547, 33);
            txtsdt.Margin = new Padding(4, 3, 4, 3);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(126, 23);
            txtsdt.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(508, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 33;
            label7.Text = "Sdt:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(547, 78);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 58);
            textBox2.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(266, 80);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 16);
            label12.TabIndex = 30;
            label12.Text = "Tiền phạt:";
            // 
            // cbxTennv
            // 
            cbxTennv.FormattingEnabled = true;
            cbxTennv.Location = new Point(115, 61);
            cbxTennv.Name = "cbxTennv";
            cbxTennv.Size = new Size(126, 23);
            cbxTennv.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 16);
            label5.TabIndex = 24;
            label5.Text = "Tên thành viên:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 65);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 16);
            label9.TabIndex = 22;
            label9.Text = "Tên nhân viên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 147);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 16);
            label8.TabIndex = 20;
            label8.Text = "Hoàn cọc:";
            // 
            // txtDocgia
            // 
            txtDocgia.AutoSize = true;
            txtDocgia.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocgia.Location = new Point(263, 31);
            txtDocgia.Margin = new Padding(4, 0, 4, 0);
            txtDocgia.Name = "txtDocgia";
            txtDocgia.Size = new Size(79, 16);
            txtDocgia.TabIndex = 17;
            txtDocgia.Text = "Tên độc giả:";
            // 
            // dtpNgaymuon
            // 
            dtpNgaymuon.CustomFormat = "dd/MM/yyyy";
            dtpNgaymuon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaymuon.Format = DateTimePickerFormat.Custom;
            dtpNgaymuon.Location = new Point(115, 99);
            dtpNgaymuon.Name = "dtpNgaymuon";
            dtpNgaymuon.Size = new Size(129, 23);
            dtpNgaymuon.TabIndex = 16;
            // 
            // txtTiencoc
            // 
            txtTiencoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTiencoc.Location = new Point(115, 143);
            txtTiencoc.Margin = new Padding(4, 3, 4, 3);
            txtTiencoc.Name = "txtTiencoc";
            txtTiencoc.Size = new Size(129, 23);
            txtTiencoc.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 16);
            label3.TabIndex = 15;
            label3.Text = "Ngày trả:";
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.ForeColor = Color.Red;
            thoat.Location = new Point(592, 574);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(60, 27);
            thoat.TabIndex = 90;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            them.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            them.ForeColor = Color.Red;
            them.Location = new Point(393, 574);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(91, 27);
            them.TabIndex = 89;
            them.Text = "Trả sách";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 88;
            label1.Text = "PHIẾU TRẢ SÁCH";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 486);
            groupBox1.TabIndex = 97;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm sách mượn";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(6, 101);
            listView2.Name = "listView2";
            listView2.Size = new Size(213, 379);
            listView2.TabIndex = 40;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Họ tên";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Sđt";
            columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vai trò";
            columnHeader6.Width = 70;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(68, 31);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(150, 23);
            comboBox3.TabIndex = 99;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(6, 60);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Tìm kiếm theo tên hoặc số điện thoại";
            textBox6.Size = new Size(212, 23);
            textBox6.TabIndex = 100;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 33);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 16);
            label11.TabIndex = 98;
            label11.Text = "Độc giả:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Phieutrasach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 611);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(cbxDocgia);
            Controls.Add(thoat);
            Controls.Add(them);
            Controls.Add(label1);
            Name = "Phieutrasach";
            Text = "Phieutrasach";
            Load += Phieutrasach_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            cbxDocgia.ResumeLayout(false);
            cbxDocgia.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button btnXoa;
        private Button btnXacnhan;
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private GroupBox cbxDocgia;
        private TextBox txtsdt;
        private Label label7;
        private TextBox textBox2;
        private Label label12;
        private ComboBox cbxTennv;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label txtDocgia;
        private DateTimePicker dtpNgaymuon;
        private TextBox txtTiencoc;
        private Label label3;
        private Button thoat;
        private Button them;
        private Label label1;
        private Label label10;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private TextBox textBox7;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private TextBox textBox6;
        private Label label11;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ComboBox comboBox2;
        private ErrorProvider errorProvider1;
    }
}