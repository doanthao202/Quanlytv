namespace C_PRL.Forms
{
    partial class Tacgia
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
            label5 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtTentl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVitri = new TextBox();
            thoat = new Button();
            xoa = new Button();
            sua = new Button();
            them = new Button();
            label1 = new Label();
            luoi = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)luoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(304, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 42;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 150);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên tác giả";
            textBox1.Size = new Size(271, 22);
            textBox1.TabIndex = 41;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTentl);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtVitri);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.LightSeaGreen;
            groupBox2.Location = new Point(297, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 102);
            groupBox2.TabIndex = 40;
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
            txtTentl.Location = new Point(95, 25);
            txtTentl.Margin = new Padding(4, 3, 4, 3);
            txtTentl.Name = "txtTentl";
            txtTentl.Size = new Size(264, 23);
            txtTentl.TabIndex = 14;
            txtTentl.KeyPress += txtTentl_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(7, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 13;
            label2.Text = "Tên tác giả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Ghi chú:";
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(95, 61);
            txtVitri.Margin = new Padding(4, 3, 4, 3);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(264, 23);
            txtVitri.TabIndex = 16;
            // 
            // thoat
            // 
            thoat.BackColor = Color.Peru;
            thoat.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.ForeColor = SystemColors.ControlLightLight;
            thoat.Location = new Point(681, 274);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 39;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // xoa
            // 
            xoa.BackColor = Color.Peru;
            xoa.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            xoa.ForeColor = SystemColors.ControlLightLight;
            xoa.Location = new Point(681, 241);
            xoa.Margin = new Padding(4, 3, 4, 3);
            xoa.Name = "xoa";
            xoa.Size = new Size(88, 27);
            xoa.TabIndex = 38;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = false;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.BackColor = Color.Peru;
            sua.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sua.ForeColor = SystemColors.ControlLightLight;
            sua.Location = new Point(681, 208);
            sua.Margin = new Padding(4, 3, 4, 3);
            sua.Name = "sua";
            sua.Size = new Size(88, 27);
            sua.TabIndex = 37;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = false;
            sua.Click += sua_Click;
            // 
            // them
            // 
            them.BackColor = Color.Peru;
            them.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            them.ForeColor = SystemColors.ControlLightLight;
            them.Location = new Point(681, 175);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 36;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(463, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 36);
            label1.TabIndex = 35;
            label1.Text = "TÁC GIẢ";
            // 
            // luoi
            // 
            luoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            luoi.Location = new Point(284, 312);
            luoi.Margin = new Padding(4, 3, 4, 3);
            luoi.Name = "luoi";
            luoi.Size = new Size(485, 192);
            luoi.TabIndex = 34;
            luoi.CellClick += luoi_CellClick;
            luoi.CellContentClick += luoi_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Tacgia
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
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Tacgia";
            Text = "Tacgia";
            Load += Tacgia_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)luoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox txtVitri;
        private Button thoat;
        private Button xoa;
        private Button sua;
        private Button them;
        private Label label1;
        private DataGridView luoi;
        private ErrorProvider errorProvider1;
    }
}