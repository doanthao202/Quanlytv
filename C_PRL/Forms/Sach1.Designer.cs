namespace C_PRL.Forms
{
    partial class Sach1
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
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            lvtacgia = new ColumnHeader();
            lvvaitro = new ColumnHeader();
            txtNam = new TextBox();
            label9 = new Label();
            cbxTheloai = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtTensach = new TextBox();
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
            Sua.Location = new Point(146, 229);
            Sua.Margin = new Padding(4, 3, 4, 3);
            Sua.Name = "Sua";
            Sua.Size = new Size(88, 27);
            Sua.TabIndex = 74;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacnhan);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(528, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 146);
            groupBox2.TabIndex = 73;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác giả";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(161, 102);
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
            btnXacnhan.Location = new Point(40, 102);
            btnXacnhan.Margin = new Padding(4, 3, 4, 3);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(77, 27);
            btnXacnhan.TabIndex = 37;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 13;
            label4.Text = "Tên tác giả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 68);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 15;
            label6.Text = "Vai trò:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 62);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 72;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 34);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên sách";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 71;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(txtNam);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbxTheloai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTensach);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 163);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { lvtacgia, lvvaitro });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(298, 43);
            listView1.Name = "listView1";
            listView1.Size = new Size(195, 97);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lvtacgia
            // 
            lvtacgia.Text = "Tên tác giả";
            lvtacgia.Width = 110;
            // 
            // lvvaitro
            // 
            lvvaitro.Text = "Vai trò";
            lvvaitro.Width = 80;
            // 
            // txtNam
            // 
            txtNam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNam.Location = new Point(97, 59);
            txtNam.Margin = new Padding(4, 3, 4, 3);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(126, 23);
            txtNam.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 101);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(88, 16);
            label9.TabIndex = 22;
            label9.Text = "Thể loại sách:";
            // 
            // cbxTheloai
            // 
            cbxTheloai.FormattingEnabled = true;
            cbxTheloai.Location = new Point(97, 96);
            cbxTheloai.Name = "cbxTheloai";
            cbxTheloai.Size = new Size(126, 23);
            cbxTheloai.TabIndex = 21;
            cbxTheloai.SelectedIndexChanged += cbxTheloai_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(238, 19);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 16);
            label8.TabIndex = 20;
            label8.Text = "Danh sách tác giả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 63);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 16);
            label7.TabIndex = 17;
            label7.Text = "Năm xuất bản:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(97, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // txtTensach
            // 
            txtTensach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTensach.Location = new Point(97, 22);
            txtTensach.Margin = new Padding(4, 3, 4, 3);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(126, 23);
            txtTensach.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 13;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 16);
            label3.TabIndex = 15;
            label3.Text = "Ngày nhập:";
            // 
            // thoat
            // 
            thoat.Location = new Point(402, 229);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 69;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(274, 229);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 68;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // them
            // 
            them.Location = new Point(18, 229);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 67;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 26);
            label1.TabIndex = 66;
            label1.Text = "SÁCH";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(18, 264);
            dgv.Margin = new Padding(4, 3, 4, 3);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(776, 186);
            dgv.TabIndex = 65;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // Sach1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Sach1";
            Text = "df";
            Load += Sach1_Load;
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
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtNam;
        private Label label9;
        private ComboBox cbxTheloai;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTensach;
        private Label label2;
        private Label label3;
        private Button thoat;
        private Button xoa;
        private Button them;
        private Label label1;
        private DataGridView dgv;
        private ListView listView1;
        private ColumnHeader lvtacgia;
        private ColumnHeader lvvaitro;
    }
}