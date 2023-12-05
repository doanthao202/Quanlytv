

namespace C_PRL.Forms
{
    partial class Theloai1
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
            groupBox1 = new GroupBox();
            txtTentl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtVitri = new TextBox();
            thoat = new Button();
            sua = new Button();
            them = new Button();
            dgv = new DataGridView();
            Xoa = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 33;
            label5.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 40);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên thể loại";
            textBox1.Size = new Size(398, 23);
            textBox1.TabIndex = 32;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTentl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtVitri);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 102);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtTentl
            // 
            txtTentl.Location = new Point(95, 25);
            txtTentl.Margin = new Padding(4, 3, 4, 3);
            txtTentl.Name = "txtTentl";
            txtTentl.Size = new Size(383, 23);
            txtTentl.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 13;
            label2.Text = "Tên thể loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 68);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 15;
            label3.Text = "Vị trí:";
            // 
            // txtVitri
            // 
            txtVitri.Location = new Point(95, 61);
            txtVitri.Margin = new Padding(4, 3, 4, 3);
            txtVitri.Name = "txtVitri";
            txtVitri.Size = new Size(383, 23);
            txtVitri.TabIndex = 16;
            // 
            // thoat
            // 
            thoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.Location = new Point(408, 194);
            thoat.Margin = new Padding(4, 3, 4, 3);
            thoat.Name = "thoat";
            thoat.Size = new Size(88, 27);
            thoat.TabIndex = 30;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // sua
            // 
            sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sua.Location = new Point(146, 194);
            sua.Margin = new Padding(4, 3, 4, 3);
            sua.Name = "sua";
            sua.Size = new Size(88, 27);
            sua.TabIndex = 28;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // them
            // 
            them.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            them.Location = new Point(25, 194);
            them.Margin = new Padding(4, 3, 4, 3);
            them.Name = "them";
            them.Size = new Size(88, 27);
            them.TabIndex = 27;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(18, 227);
            dgv.Margin = new Padding(4, 3, 4, 3);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(485, 197);
            dgv.TabIndex = 25;
            dgv.CellClick += dgv_CellClick;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // Xoa
            // 
            Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Xoa.Location = new Point(273, 194);
            Xoa.Margin = new Padding(4, 3, 4, 3);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(88, 27);
            Xoa.TabIndex = 34;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 35;
            label1.Text = "Thể loại";
            // 
            // Theloai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(label1);
            Controls.Add(Xoa);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(thoat);
            Controls.Add(sua);
            Controls.Add(them);
            Controls.Add(dgv);
            Name = "Theloai1";
            Text = "Theloai";
            Load += Theloai_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Label label5;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtTentl;
        private Label label2;
        private Label label3;
        private TextBox txtVitri;
        private Button thoat;
        private Button sua;
        private Button them;
        private DataGridView dgv;
        private Button Xoa;
        private ErrorProvider errorProvider1;
        private Label label1;
    }
}