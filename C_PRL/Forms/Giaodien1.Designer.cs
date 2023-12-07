namespace C_PRL.Forms
{
    partial class Giaodien1
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            hêThôngToolStripMenuItem = new ToolStripMenuItem();
            đăngXiToolStripMenuItem = new ToolStripMenuItem();
            đôiMâtKhâuToolStripMenuItem = new ToolStripMenuItem();
            sachToolStripMenuItem = new ToolStripMenuItem();
            sachChiTiêtToolStripMenuItem = new ToolStripMenuItem();
            tacGiaToolStripMenuItem = new ToolStripMenuItem();
            ngônNgưToolStripMenuItem = new ToolStripMenuItem();
            nXBToolStripMenuItem = new ToolStripMenuItem();
            thêLoaiToolStripMenuItem = new ToolStripMenuItem();
            mươntraToolStripMenuItem = new ToolStripMenuItem();
            phiêuMươnToolStripMenuItem = new ToolStripMenuItem();
            phiêuTraToolStripMenuItem = new ToolStripMenuItem();
            thôngKêToolStripMenuItem = new ToolStripMenuItem();
            đôcGiaToolStripMenuItem = new ToolStripMenuItem();
            hangToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 100);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCoral;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hêThôngToolStripMenuItem, sachToolStripMenuItem, mươntraToolStripMenuItem, thôngKêToolStripMenuItem, đôcGiaToolStripMenuItem, nhânViênToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1239, 100);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            hêThôngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXiToolStripMenuItem, đôiMâtKhâuToolStripMenuItem });
            hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            hêThôngToolStripMenuItem.Size = new Size(85, 94);
            hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXiToolStripMenuItem
            // 
            đăngXiToolStripMenuItem.Name = "đăngXiToolStripMenuItem";
            đăngXiToolStripMenuItem.Size = new Size(181, 26);
            đăngXiToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            đôiMâtKhâuToolStripMenuItem.Size = new Size(181, 26);
            đôiMâtKhâuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // sachToolStripMenuItem
            // 
            sachToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sachChiTiêtToolStripMenuItem, tacGiaToolStripMenuItem, ngônNgưToolStripMenuItem, nXBToolStripMenuItem, thêLoaiToolStripMenuItem });
            sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            sachToolStripMenuItem.Size = new Size(54, 94);
            sachToolStripMenuItem.Text = "Sách";
            sachToolStripMenuItem.Click += sachToolStripMenuItem_Click;
            // 
            // sachChiTiêtToolStripMenuItem
            // 
            sachChiTiêtToolStripMenuItem.Name = "sachChiTiêtToolStripMenuItem";
            sachChiTiêtToolStripMenuItem.Size = new Size(224, 26);
            sachChiTiêtToolStripMenuItem.Text = "Sách chi tiết";
            sachChiTiêtToolStripMenuItem.Click += sachChiTiêtToolStripMenuItem_Click;
            // 
            // tacGiaToolStripMenuItem
            // 
            tacGiaToolStripMenuItem.Name = "tacGiaToolStripMenuItem";
            tacGiaToolStripMenuItem.Size = new Size(224, 26);
            tacGiaToolStripMenuItem.Text = "Tác giả";
            tacGiaToolStripMenuItem.Click += tacGiaToolStripMenuItem_Click;
            // 
            // ngônNgưToolStripMenuItem
            // 
            ngônNgưToolStripMenuItem.Name = "ngônNgưToolStripMenuItem";
            ngônNgưToolStripMenuItem.Size = new Size(224, 26);
            ngônNgưToolStripMenuItem.Text = "Ngôn ngữ";
            ngônNgưToolStripMenuItem.Click += ngônNgưToolStripMenuItem_Click;
            // 
            // nXBToolStripMenuItem
            // 
            nXBToolStripMenuItem.Name = "nXBToolStripMenuItem";
            nXBToolStripMenuItem.Size = new Size(224, 26);
            nXBToolStripMenuItem.Text = "Nhà xuất bản";
            nXBToolStripMenuItem.Click += nXBToolStripMenuItem_Click;
            // 
            // thêLoaiToolStripMenuItem
            // 
            thêLoaiToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.None;
            thêLoaiToolStripMenuItem.Name = "thêLoaiToolStripMenuItem";
            thêLoaiToolStripMenuItem.Size = new Size(224, 26);
            thêLoaiToolStripMenuItem.Text = "Thể loại";
            thêLoaiToolStripMenuItem.Click += thêLoaiToolStripMenuItem_Click;
            // 
            // mươntraToolStripMenuItem
            // 
            mươntraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiêuMươnToolStripMenuItem, phiêuTraToolStripMenuItem });
            mươntraToolStripMenuItem.Name = "mươntraToolStripMenuItem";
            mươntraToolStripMenuItem.Size = new Size(86, 94);
            mươntraToolStripMenuItem.Text = "Mượn/trả";
            mươntraToolStripMenuItem.Click += mươntraToolStripMenuItem_Click;
            // 
            // phiêuMươnToolStripMenuItem
            // 
            phiêuMươnToolStripMenuItem.Name = "phiêuMươnToolStripMenuItem";
            phiêuMươnToolStripMenuItem.Size = new Size(171, 26);
            phiêuMươnToolStripMenuItem.Text = "Phiếu mượn";
            phiêuMươnToolStripMenuItem.Click += phiêuMươnToolStripMenuItem_Click;
            // 
            // phiêuTraToolStripMenuItem
            // 
            phiêuTraToolStripMenuItem.Name = "phiêuTraToolStripMenuItem";
            phiêuTraToolStripMenuItem.Size = new Size(171, 26);
            phiêuTraToolStripMenuItem.Text = "Phiếu trả";
            phiêuTraToolStripMenuItem.Click += phiêuTraToolStripMenuItem_Click;
            // 
            // thôngKêToolStripMenuItem
            // 
            thôngKêToolStripMenuItem.Name = "thôngKêToolStripMenuItem";
            thôngKêToolStripMenuItem.Size = new Size(84, 94);
            thôngKêToolStripMenuItem.Text = "Thống kê";
            thôngKêToolStripMenuItem.Click += thôngKêToolStripMenuItem_Click;
            // 
            // đôcGiaToolStripMenuItem
            // 
            đôcGiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hangToolStripMenuItem });
            đôcGiaToolStripMenuItem.Name = "đôcGiaToolStripMenuItem";
            đôcGiaToolStripMenuItem.Size = new Size(75, 94);
            đôcGiaToolStripMenuItem.Text = "Độc giả";
            đôcGiaToolStripMenuItem.Click += đôcGiaToolStripMenuItem_Click;
            // 
            // hangToolStripMenuItem
            // 
            hangToolStripMenuItem.Name = "hangToolStripMenuItem";
            hangToolStripMenuItem.Size = new Size(128, 26);
            hangToolStripMenuItem.Text = "Hạng";
            hangToolStripMenuItem.Click += hangToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(89, 94);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1239, 940);
            panel2.TabIndex = 1;
            // 
            // Giaodien1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 1040);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Giaodien1";
            Text = "Giaodien1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hêThôngToolStripMenuItem;
        private ToolStripMenuItem đăngXiToolStripMenuItem;
        private ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private ToolStripMenuItem sachToolStripMenuItem;
        private ToolStripMenuItem sachChiTiêtToolStripMenuItem;
        private ToolStripMenuItem tacGiaToolStripMenuItem;
        private ToolStripMenuItem ngônNgưToolStripMenuItem;
        private ToolStripMenuItem nXBToolStripMenuItem;
        private ToolStripMenuItem thêLoaiToolStripMenuItem;
        private ToolStripMenuItem mươntraToolStripMenuItem;
        private ToolStripMenuItem phiêuMươnToolStripMenuItem;
        private ToolStripMenuItem phiêuTraToolStripMenuItem;
        private ToolStripMenuItem thôngKêToolStripMenuItem;
        private ToolStripMenuItem đôcGiaToolStripMenuItem;
        private ToolStripMenuItem hangToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}