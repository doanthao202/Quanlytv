namespace C_PRL.Forms
{
    partial class NgonNgu1
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
            txtTentl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            thoat = new Button();
            xoa = new Button();
            sua = new Button();
            them = new Button();
            label1 = new Label();
            luoi = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)luoi).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 123);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 69;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 112);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên ngôn ngữ";
            textBox1.Size = new Size(414, 31);
            textBox1.TabIndex = 68;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTentl);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(16, 180);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(541, 170);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 178);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 18;
            // 
            // txtTentl
            // 
            txtTentl.Location = new Point(136, 82);
            txtTentl.Margin = new Padding(6, 5, 6, 5);
            txtTentl.Name = "txtTentl";
            txtTentl.Size = new Size(375, 31);
            txtTentl.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 85);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 24);
            label2.TabIndex = 13;
            label2.Text = "Tên ngôn ngữ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 113);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 15;
            // 
            // thoat
            // 
            thoat.Location = new Point(567, 327);
            thoat.Margin = new Padding(6, 5, 6, 5);
            thoat.Name = "thoat";
            thoat.Size = new Size(126, 45);
            thoat.TabIndex = 66;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.Location = new Point(567, 272);
            xoa.Margin = new Padding(6, 5, 6, 5);
            xoa.Name = "xoa";
            xoa.Size = new Size(126, 45);
            xoa.TabIndex = 65;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(567, 217);
            sua.Margin = new Padding(6, 5, 6, 5);
            sua.Name = "sua";
            sua.Size = new Size(126, 45);
            sua.TabIndex = 64;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // them
            // 
            them.Location = new Point(567, 162);
            them.Margin = new Padding(6, 5, 6, 5);
            them.Name = "them";
            them.Size = new Size(126, 45);
            them.TabIndex = 63;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 39);
            label1.TabIndex = 62;
            label1.Text = "NGÔN NGỮ";
            label1.Click += label1_Click;
            // 
            // luoi
            // 
            luoi.BackgroundColor = SystemColors.AppWorkspace;
            luoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            luoi.Location = new Point(16, 390);
            luoi.Margin = new Padding(6, 5, 6, 5);
            luoi.Name = "luoi";
            luoi.RowHeadersWidth = 62;
            luoi.Size = new Size(693, 320);
            luoi.TabIndex = 61;
            luoi.CellClick += luoi_CellClick;
            luoi.CellContentClick += luoi_CellContentClick;
            // 
            // NgonNgu1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 750);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(luoi);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NgonNgu1";
            Text = "NgonNgu1";
            Load += NgonNgu1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)luoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtTentl;
        private Label label2;
        private Label label3;
        private Button thoat;
        private Button xoa;
        private Button sua;
        private Button them;
        private Label label1;
        private DataGridView luoi;
    }
}