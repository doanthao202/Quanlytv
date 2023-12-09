namespace C_PRL.Forms
{
    partial class Nhanvien1
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
            Sua = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            cxbTrangthai = new ComboBox();
            label4 = new Label();
            txtSdt = new TextBox();
            label9 = new Label();
            cbxVaitro = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            thoat = new Button();
            xoa = new Button();
            them = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Sua
            // 
            Sua.Location = new Point(374, 314);
            Sua.Margin = new Padding(4, 3, 4, 3);
            Sua.Name = "Sua";
            Sua.Size = new Size(88, 27);
            Sua.TabIndex = 83;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            Sua.Click += Sua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(262, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 82;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 133);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên nhân viên";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 81;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(cxbTrangthai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbxVaitro);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(262, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 153);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(325, 23);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 27;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(325, 58);
            txtPass.Margin = new Padding(4, 3, 4, 3);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(179, 23);
            txtPass.TabIndex = 26;
            // 
            // cxbTrangthai
            // 
            cxbTrangthai.FormattingEnabled = true;
            cxbTrangthai.Location = new Point(325, 98);
            cxbTrangthai.Name = "cxbTrangthai";
            cxbTrangthai.Size = new Size(103, 23);
            cxbTrangthai.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(249, 105);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 24;
            label4.Text = "Trạng thái:";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdt.Location = new Point(108, 58);
            txtSdt.Margin = new Padding(4, 3, 4, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(103, 23);
            txtSdt.TabIndex = 23;
            txtSdt.TextChanged += txtSdt_TextChanged;
            txtSdt.KeyPress += txtSdt_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 105);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 16);
            label9.TabIndex = 22;
            label9.Text = "Vai trò:";
            // 
            // cbxVaitro
            // 
            cbxVaitro.FormattingEnabled = true;
            cbxVaitro.Location = new Point(108, 98);
            cbxVaitro.Name = "cbxVaitro";
            cbxVaitro.Size = new Size(103, 23);
            cbxVaitro.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(249, 65);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 16);
            label8.TabIndex = 20;
            label8.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 65);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 16);
            label7.TabIndex = 17;
            label7.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(108, 18);
            txtTen.Margin = new Padding(4, 3, 4, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(103, 23);
            txtTen.TabIndex = 14;
            txtTen.TextChanged += txtTensach_TextChanged;
            txtTen.KeyPress += txtTen_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 16);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(249, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 15;
            label3.Text = "Email:";
            // 
            // thoat
            // 
            thoat.Location = new Point(602, 314);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 79;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(494, 314);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 78;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // them
            // 
            them.Location = new Point(262, 314);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 77;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(455, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 26);
            label1.TabIndex = 76;
            label1.Text = "NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(264, 347);
            dgv.Margin = new Padding(4, 3, 4, 3);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(509, 186);
            dgv.TabIndex = 75;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Nhanvien1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 666);
            Controls.Add(Sua);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "Nhanvien1";
            Text = "Nhanvien1";
            Load += Nhanvien1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sua;
        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtSdt;
        private Label label9;
        private ComboBox cbxVaitro;
        private Label label8;
        private Label label7;
        private TextBox txtTen;
        private Label label2;
        private Label label3;
        private Button thoat;
        private Button xoa;
        private Button them;
        private Label label1;
        private DataGridView dgv;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPass;
        private ComboBox cxbTrangthai;
        private ErrorProvider errorProvider1;
    }
}