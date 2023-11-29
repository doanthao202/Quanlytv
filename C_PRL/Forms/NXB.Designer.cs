namespace C_PRL.Forms
{
    partial class NXB
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
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTenNXB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDiachi = new TextBox();
            thoat = new Button();
            xoa = new Button();
            sua = new Button();
            them = new Button();
            label1 = new Label();
            dgvNxb = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txtSDT = new TextBox();
            txtGhichu = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNxb).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 59);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 51;
            label5.Text = "Tìm kiếm:";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 57);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên nhà xuấ bản";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(txtGhichu);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTenNXB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDiachi);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(45, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 164);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            groupBox2.Enter += this.groupBox2_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 18;
            // 
            // txtTenNXB
            // 
            txtTenNXB.Location = new Point(95, 18);
            txtTenNXB.Margin = new Padding(4, 3, 4, 3);
            txtTenNXB.Name = "txtTenNXB";
            txtTenNXB.Size = new Size(264, 23);
            txtTenNXB.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 13;
            label2.Text = "Tên NXB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 15;
            label3.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(95, 47);
            txtDiachi.Margin = new Padding(4, 3, 4, 3);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(264, 23);
            txtDiachi.TabIndex = 16;
            // 
            // thoat
            // 
            thoat.Location = new Point(418, 230);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 48;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += this.thoat_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(418, 189);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 47;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += this.xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(418, 146);
            sua.Margin = new Padding(4, 3, 4, 3);
            sua.Name = "sua";
            sua.Size = new Size(88, 27);
            sua.TabIndex = 46;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += this.sua_Click;
            // 
            // them
            // 
            them.Location = new Point(418, 113);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 45;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += this.them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 26);
            label1.TabIndex = 44;
            label1.Text = "NHÀ XUẤT BẢN";
            label1.Click += this.label1_Click;
            // 
            // dgvNxb
            // 
            dgvNxb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNxb.Location = new Point(36, 263);
            dgvNxb.Margin = new Padding(4, 3, 4, 3);
            dgvNxb.Name = "dgvNxb";
            dgvNxb.Size = new Size(485, 184);
            dgvNxb.TabIndex = 43;
            dgvNxb.CellContentClick += this.luoi_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 107);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 19;
            label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 83);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 16);
            label7.TabIndex = 20;
            label7.Text = "Sdt:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(95, 76);
            txtSDT.Margin = new Padding(4, 3, 4, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(264, 23);
            txtSDT.TabIndex = 21;
            // 
            // txtGhichu
            // 
            txtGhichu.Location = new Point(95, 107);
            txtGhichu.Margin = new Padding(4, 3, 4, 3);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(264, 23);
            txtGhichu.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hoạt động", "Dừng hoạt động" });
            comboBox1.Location = new Point(95, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 138);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 16);
            label8.TabIndex = 24;
            label8.Text = "Trạng thái:";
            // 
            // NXB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(dgvNxb);
            Name = "NXB";
            Text = "NXB";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNxb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTenNXB;
        private Label label2;
        private Label label3;
        private TextBox txtDiachi;
        private Button thoat;
        private Button xoa;
        private Button sua;
        private Button them;
        private Label label1;
        private DataGridView dgvNxb;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox txtGhichu;
        private TextBox txtSDT;
        private Label label7;
        private Label label6;
    }
}