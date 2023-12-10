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
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(268, 154);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 69;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 151);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên ngôn ngữ";
            textBox1.Size = new Size(291, 23);
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
            groupBox2.ForeColor = Color.LightSeaGreen;
            groupBox2.Location = new Point(261, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 102);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
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
            // txtTentl
            // 
            txtTentl.Location = new Point(108, 44);
            txtTentl.Margin = new Padding(4, 3, 4, 3);
            txtTentl.Name = "txtTentl";
            txtTentl.Size = new Size(264, 23);
            txtTentl.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 13;
            label2.Text = "Tên ngôn ngữ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 16);
            label3.TabIndex = 15;
            // 
            // thoat
            // 
            thoat.BackColor = Color.Peru;
            thoat.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.ForeColor = Color.White;
            thoat.Location = new Point(647, 276);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 66;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.BackColor = Color.Peru;
            xoa.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            xoa.ForeColor = Color.White;
            xoa.Location = new Point(647, 243);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 65;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.BackColor = Color.Peru;
            sua.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sua.ForeColor = Color.White;
            sua.Location = new Point(647, 210);
            sua.Margin = new Padding(4, 3, 4, 3);
            sua.Name = "sua";
            sua.Size = new Size(88, 27);
            sua.TabIndex = 64;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = false;
            sua.Click += sua_Click;
            // 
            // them
            // 
            them.BackColor = Color.Peru;
            them.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            them.ForeColor = Color.White;
            them.Location = new Point(647, 177);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 63;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(396, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 36);
            label1.TabIndex = 62;
            label1.Text = "NGÔN NGỮ";
            label1.Click += label1_Click;
            // 
            // luoi
            // 
            luoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            luoi.Location = new Point(261, 314);
            luoi.Margin = new Padding(4, 3, 4, 3);
            luoi.Name = "luoi";
            luoi.Size = new Size(485, 192);
            luoi.TabIndex = 61;
            luoi.CellClick += luoi_CellClick;
            luoi.CellContentClick += luoi_CellContentClick;
            // 
            // NgonNgu1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 666);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(label1);
            Controls.Add(luoi);
            ForeColor = Color.Black;
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