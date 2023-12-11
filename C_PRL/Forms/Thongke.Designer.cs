namespace C_PRL.Forms
{
    partial class Thongke
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
            vButton1 = new VButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(236, 127);
            label1.Name = "label1";
            label1.Size = new Size(793, 45);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH SÁCH ĐƯỢC MƯỢN NHIỀU";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 272);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1067, 443);
            dataGridView1.TabIndex = 2;
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
            vButton1.Location = new Point(1008, 791);
            vButton1.Margin = new Padding(3, 4, 3, 4);
            vButton1.Name = "vButton1";
            vButton1.Size = new Size(171, 53);
            vButton1.TabIndex = 4;
            vButton1.Text = "Xuất file Excel";
            vButton1.TextColor = Color.White;
            vButton1.UseVisualStyleBackColor = false;
            vButton1.Click += vButton1_Click;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 872);
            Controls.Add(vButton1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Thongke";
            Text = "Thongke";
            Load += Thongke_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private VButton vButton1;
    }
}