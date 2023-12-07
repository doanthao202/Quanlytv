namespace C_PRL.Forms
{
    partial class Giaodien
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
            TreeNode treeNode1 = new TreeNode("Độc giả");
            TreeNode treeNode2 = new TreeNode("Hạng");
            TreeNode treeNode3 = new TreeNode("NXB");
            TreeNode treeNode4 = new TreeNode("Tác giả");
            TreeNode treeNode5 = new TreeNode("Thể loại");
            TreeNode treeNode6 = new TreeNode("Nhân viên");
            TreeNode treeNode7 = new TreeNode("Sách");
            TreeNode treeNode8 = new TreeNode("Danh mục", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Quản lý mượn trả");
            TreeNode treeNode10 = new TreeNode("Quản lý nhân viên");
            TreeNode treeNode11 = new TreeNode("Quản lý độc giả");
            TreeNode treeNode12 = new TreeNode("Quản lý thể loại");
            TreeNode treeNode13 = new TreeNode("Quản lý tác giả");
            TreeNode treeNode14 = new TreeNode("Quản lý NXB");
            TreeNode treeNode15 = new TreeNode("Quản lý sách", new TreeNode[] { treeNode12, treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Thống kê");
            splitContainer1 = new SplitContainer();
            DangXuat = new Label();
            treeView1 = new TreeView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 44);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DangXuat);
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Size = new Size(964, 467);
            splitContainer1.SplitterDistance = 173;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 3;
            // 
            // DangXuat
            // 
            DangXuat.AutoSize = true;
            DangXuat.BackColor = Color.FromArgb(255, 192, 192);
            DangXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DangXuat.ForeColor = Color.Red;
            DangXuat.Location = new Point(19, 431);
            DangXuat.Margin = new Padding(2, 0, 2, 0);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(77, 19);
            DangXuat.TabIndex = 1;
            DangXuat.Text = "Đăng xuất";
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(255, 192, 192);
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            treeView1.ForeColor = Color.White;
            treeView1.Location = new Point(0, 0);
            treeView1.Margin = new Padding(2);
            treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.ForeColor = Color.Red;
            treeNode1.Name = "ndDG";
            treeNode1.Text = "Độc giả";
            treeNode2.ForeColor = Color.Red;
            treeNode2.Name = "ndHang";
            treeNode2.Text = "Hạng";
            treeNode3.ForeColor = Color.Red;
            treeNode3.Name = "ndNXB";
            treeNode3.Text = "NXB";
            treeNode4.ForeColor = Color.Red;
            treeNode4.Name = "ndTG";
            treeNode4.Text = "Tác giả";
            treeNode5.ForeColor = Color.Red;
            treeNode5.Name = "ndTL";
            treeNode5.Text = "Thể loại";
            treeNode6.ForeColor = Color.Red;
            treeNode6.Name = "ndNV";
            treeNode6.Text = "Nhân viên";
            treeNode7.ForeColor = Color.Red;
            treeNode7.Name = "ndSach";
            treeNode7.Text = "Sách";
            treeNode8.ForeColor = Color.Red;
            treeNode8.Name = "Node0";
            treeNode8.Text = "Danh mục";
            treeNode9.ForeColor = Color.Red;
            treeNode9.Name = "Node8";
            treeNode9.Text = "Quản lý mượn trả";
            treeNode10.ForeColor = Color.Red;
            treeNode10.Name = "Node9";
            treeNode10.Text = "Quản lý nhân viên";
            treeNode11.ForeColor = Color.Red;
            treeNode11.Name = "Node10";
            treeNode11.Text = "Quản lý độc giả";
            treeNode12.ForeColor = Color.Red;
            treeNode12.Name = "Node13";
            treeNode12.Text = "Quản lý thể loại";
            treeNode13.ForeColor = Color.Red;
            treeNode13.Name = "Node14";
            treeNode13.Text = "Quản lý tác giả";
            treeNode14.ForeColor = Color.Red;
            treeNode14.Name = "Node15";
            treeNode14.Text = "Quản lý NXB";
            treeNode15.ForeColor = Color.Red;
            treeNode15.Name = "Node12";
            treeNode15.Text = "Quản lý sách";
            treeNode16.ForeColor = Color.Red;
            treeNode16.Name = "Node11";
            treeNode16.Text = "Thống kê";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode9, treeNode10, treeNode11, treeNode15, treeNode16 });
            treeView1.Size = new Size(173, 467);
            treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 39);
            panel1.TabIndex = 2;
            // 
            // Giaodien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 515);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Giaodien";
            Text = "Giaodien";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label DangXuat;
        private TreeView treeView1;
        private Panel panel1;
    }
}