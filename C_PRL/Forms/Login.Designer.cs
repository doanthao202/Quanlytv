﻿namespace C_PRL.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btExit = new Button();
            btLogin = new Button();
            txtMK = new TextBox();
            txtTK = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.BackColor = Color.OrangeRed;
            btExit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btExit.ForeColor = SystemColors.ButtonHighlight;
            btExit.Location = new Point(550, 262);
            btExit.Margin = new Padding(2);
            btExit.Name = "btExit";
            btExit.Size = new Size(104, 35);
            btExit.TabIndex = 22;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.LightSeaGreen;
            btLogin.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.ForeColor = SystemColors.ButtonHighlight;
            btLogin.Location = new Point(392, 262);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(104, 35);
            btLogin.TabIndex = 21;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.ForeColor = Color.Black;
            txtMK.Location = new Point(392, 195);
            txtMK.Margin = new Padding(2);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.PlaceholderText = "Nhập password";
            txtMK.Size = new Size(262, 29);
            txtMK.TabIndex = 20;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.ForeColor = Color.Black;
            txtTK.Location = new Point(392, 148);
            txtTK.Margin = new Padding(2);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Nhập email hoặc số điện thoại";
            txtTK.Size = new Size(262, 29);
            txtTK.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(424, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 40);
            label3.TabIndex = 18;
            label3.Text = "Đăng nhập";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 410);
            panel1.TabIndex = 24;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(560, 226);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 410);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(btExit);
            Controls.Add(btLogin);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btExit;
        private Button btLogin;
        private TextBox txtMK;
        private TextBox txtTK;
        private Label label3;
        private Panel panel1;
        private LinkLabel linkLabel1;
    }
}