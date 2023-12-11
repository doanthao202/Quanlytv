namespace C_PRL.Forms
{
    partial class Hienthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hienthi));
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            hêThôngToolStripMenuItem = new ToolStripMenuItem();
            đăngXiToolStripMenuItem = new ToolStripMenuItem();
            đôiMâtKhâuToolStripMenuItem = new ToolStripMenuItem();
            sachToolStripMenuItem = new ToolStripMenuItem();
            sachChiTiêtToolStripMenuItem = new ToolStripMenuItem();
            tacGiaToolStripMenuItem = new ToolStripMenuItem();
            ngônNgưToolStripMenuItem = new ToolStripMenuItem();
            nXBToolStripMenuItem = new ToolStripMenuItem();
            thEEToolStripMenuItem = new ToolStripMenuItem();
            sachChiTiêtToolStripMenuItem1 = new ToolStripMenuItem();
            mươntraToolStripMenuItem = new ToolStripMenuItem();
            phiêuMươnToolStripMenuItem = new ToolStripMenuItem();
            phiêuTraToolStripMenuItem = new ToolStripMenuItem();
            đôcGiaToolStripMenuItem = new ToolStripMenuItem();
            hangToolStripMenuItem = new ToolStripMenuItem();
            thanhViênToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 704);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 76);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(966, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(966, 38);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Peru;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hêThôngToolStripMenuItem, sachToolStripMenuItem, mươntraToolStripMenuItem, đôcGiaToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1084, 76);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            hêThôngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXiToolStripMenuItem, đôiMâtKhâuToolStripMenuItem });
            hêThôngToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            hêThôngToolStripMenuItem.Size = new Size(87, 72);
            hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXiToolStripMenuItem
            // 
            đăngXiToolStripMenuItem.Name = "đăngXiToolStripMenuItem";
            đăngXiToolStripMenuItem.Size = new Size(180, 24);
            đăngXiToolStripMenuItem.Text = "Đăng xuất";
            đăngXiToolStripMenuItem.Click += đăngXiToolStripMenuItem_Click;
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            đôiMâtKhâuToolStripMenuItem.Size = new Size(180, 24);
            đôiMâtKhâuToolStripMenuItem.Text = "Đổi mật khẩu";
            đôiMâtKhâuToolStripMenuItem.Click += đôiMâtKhâuToolStripMenuItem_Click;
            // 
            // sachToolStripMenuItem
            // 
            sachToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sachChiTiêtToolStripMenuItem, tacGiaToolStripMenuItem, ngônNgưToolStripMenuItem, nXBToolStripMenuItem, thEEToolStripMenuItem, sachChiTiêtToolStripMenuItem1 });
            sachToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            sachToolStripMenuItem.Size = new Size(111, 72);
            sachToolStripMenuItem.Text = "Quản lý sách";
            // 
            // sachChiTiêtToolStripMenuItem
            // 
            sachChiTiêtToolStripMenuItem.Name = "sachChiTiêtToolStripMenuItem";
            sachChiTiêtToolStripMenuItem.Size = new Size(172, 24);
            sachChiTiêtToolStripMenuItem.Text = "Đầu sách";
            sachChiTiêtToolStripMenuItem.Click += sachChiTiêtToolStripMenuItem_Click;
            // 
            // tacGiaToolStripMenuItem
            // 
            tacGiaToolStripMenuItem.Name = "tacGiaToolStripMenuItem";
            tacGiaToolStripMenuItem.Size = new Size(172, 24);
            tacGiaToolStripMenuItem.Text = "Tác giả";
            tacGiaToolStripMenuItem.Click += tacGiaToolStripMenuItem_Click;
            // 
            // ngônNgưToolStripMenuItem
            // 
            ngônNgưToolStripMenuItem.Name = "ngônNgưToolStripMenuItem";
            ngônNgưToolStripMenuItem.Size = new Size(172, 24);
            ngônNgưToolStripMenuItem.Text = "Ngôn ngữ";
            ngônNgưToolStripMenuItem.Click += ngônNgưToolStripMenuItem_Click;
            // 
            // nXBToolStripMenuItem
            // 
            nXBToolStripMenuItem.Name = "nXBToolStripMenuItem";
            nXBToolStripMenuItem.Size = new Size(172, 24);
            nXBToolStripMenuItem.Text = "Nhà xuất bản";
            nXBToolStripMenuItem.Click += nXBToolStripMenuItem_Click;
            // 
            // thEEToolStripMenuItem
            // 
            thEEToolStripMenuItem.Name = "thEEToolStripMenuItem";
            thEEToolStripMenuItem.Size = new Size(172, 24);
            thEEToolStripMenuItem.Text = "Thể loại";
            thEEToolStripMenuItem.Click += thEEToolStripMenuItem_Click;
            // 
            // sachChiTiêtToolStripMenuItem1
            // 
            sachChiTiêtToolStripMenuItem1.Name = "sachChiTiêtToolStripMenuItem1";
            sachChiTiêtToolStripMenuItem1.Size = new Size(172, 24);
            sachChiTiêtToolStripMenuItem1.Text = "Sách chi tiết";
            sachChiTiêtToolStripMenuItem1.Click += sachChiTiêtToolStripMenuItem1_Click;
            // 
            // mươntraToolStripMenuItem
            // 
            mươntraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phiêuMươnToolStripMenuItem, phiêuTraToolStripMenuItem });
            mươntraToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            mươntraToolStripMenuItem.Name = "mươntraToolStripMenuItem";
            mươntraToolStripMenuItem.Size = new Size(90, 72);
            mươntraToolStripMenuItem.Text = "Mượn/trả";
            // 
            // phiêuMươnToolStripMenuItem
            // 
            phiêuMươnToolStripMenuItem.Name = "phiêuMươnToolStripMenuItem";
            phiêuMươnToolStripMenuItem.Size = new Size(165, 24);
            phiêuMươnToolStripMenuItem.Text = "Phiếu mượn";
            phiêuMươnToolStripMenuItem.Click += phiêuMươnToolStripMenuItem_Click;
            // 
            // phiêuTraToolStripMenuItem
            // 
            phiêuTraToolStripMenuItem.Name = "phiêuTraToolStripMenuItem";
            phiêuTraToolStripMenuItem.Size = new Size(165, 24);
            phiêuTraToolStripMenuItem.Text = "Phiếu trả";
            phiêuTraToolStripMenuItem.Click += phiêuTraToolStripMenuItem_Click;
            // 
            // đôcGiaToolStripMenuItem
            // 
            đôcGiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hangToolStripMenuItem, thanhViênToolStripMenuItem });
            đôcGiaToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            đôcGiaToolStripMenuItem.Name = "đôcGiaToolStripMenuItem";
            đôcGiaToolStripMenuItem.Size = new Size(74, 72);
            đôcGiaToolStripMenuItem.Text = "Độc giả";
            // 
            // hangToolStripMenuItem
            // 
            hangToolStripMenuItem.Name = "hangToolStripMenuItem";
            hangToolStripMenuItem.Size = new Size(157, 24);
            hangToolStripMenuItem.Text = "Hạng";
            // 
            // thanhViênToolStripMenuItem
            // 
            thanhViênToolStripMenuItem.Name = "thanhViênToolStripMenuItem";
            thanhViênToolStripMenuItem.Size = new Size(157, 24);
            thanhViênToolStripMenuItem.Text = "Thành viên";
            // 
            // Hienthi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 780);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Hienthi";
            Text = "Hienthi";
            Load += Hienthi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hêThôngToolStripMenuItem;
        private ToolStripMenuItem đăngXiToolStripMenuItem;
        private ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private ToolStripMenuItem sachToolStripMenuItem;
        private ToolStripMenuItem sachChiTiêtToolStripMenuItem;
        private ToolStripMenuItem tacGiaToolStripMenuItem;
        private ToolStripMenuItem ngônNgưToolStripMenuItem;
        private ToolStripMenuItem nXBToolStripMenuItem;
        private ToolStripMenuItem thEEToolStripMenuItem;
        private ToolStripMenuItem sachChiTiêtToolStripMenuItem1;
        private ToolStripMenuItem mươntraToolStripMenuItem;
        private ToolStripMenuItem phiêuMươnToolStripMenuItem;
        private ToolStripMenuItem phiêuTraToolStripMenuItem;
        private ToolStripMenuItem đôcGiaToolStripMenuItem;
        private ToolStripMenuItem hangToolStripMenuItem;
        private ToolStripMenuItem thanhViênToolStripMenuItem;
        private Label label2;
        private Label label1;
    }
}