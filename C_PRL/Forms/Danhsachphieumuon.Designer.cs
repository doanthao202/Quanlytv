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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(114, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(934, 332);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Location = new Point(985, 504);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 7;
            button1.Text = "Xuất file Excel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Danhsachphieumuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 576);
            Controls.Add(button1);
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
        private Button button1;
    }
}