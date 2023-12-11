namespace C_PRL.Forms
{
    partial class Danhsachphieumuon
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
            vButton1 = new VButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // vButton1
            // 
            vButton1.BackColor = Color.Peru;
            vButton1.BackgroundColor = Color.Peru;
            vButton1.BorderColor = Color.PaleVioletRed;
            vButton1.BorderRadius = 20;
            vButton1.BorderSize = 0;
            vButton1.FlatAppearance.BorderSize = 0;
            vButton1.FlatStyle = FlatStyle.Flat;
            vButton1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            vButton1.ForeColor = Color.White;
            vButton1.Location = new Point(970, 533);
            vButton1.Name = "vButton1";
            vButton1.Size = new Size(150, 40);
            vButton1.TabIndex = 7;
            vButton1.Text = "Xuất file Excel";
            vButton1.TextColor = Color.White;
            vButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(295, 35);
            label1.Name = "label1";
            label1.Size = new Size(630, 36);
            label1.TabIndex = 6;
            label1.Text = "DANH SÁCH SÁCH ĐƯỢC MƯỢN NHIỀU";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(934, 332);
            dataGridView1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(769, 106);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 111);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(678, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Đến ngày:";
            // 
            // Danhsachphieumuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(vButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Danhsachphieumuon";
            Text = "Danhsachphieumuon";
            Load += Danhsachphieumuon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VButton vButton1;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
    }
}