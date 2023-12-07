namespace C_PRL.Forms
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
            QMK = new Label();
            btExit = new Button();
            btLogin = new Button();
            txtMK = new TextBox();
            txtTK = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // QMK
            // 
            QMK.AutoSize = true;
            QMK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            QMK.ForeColor = Color.Red;
            QMK.Location = new Point(454, 279);
            QMK.Margin = new Padding(2, 0, 2, 0);
            QMK.Name = "QMK";
            QMK.Size = new Size(116, 20);
            QMK.TabIndex = 23;
            QMK.Text = "Quên mật khẩu?";
            // 
            // btExit
            // 
            btExit.BackColor = Color.Red;
            btExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btExit.ForeColor = SystemColors.ButtonHighlight;
            btExit.Location = new Point(470, 309);
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
            btLogin.BackColor = Color.FromArgb(0, 192, 0);
            btLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btLogin.ForeColor = SystemColors.ButtonHighlight;
            btLogin.Location = new Point(312, 309);
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
            txtMK.Location = new Point(320, 245);
            txtMK.Margin = new Padding(2);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(254, 29);
            txtMK.TabIndex = 20;
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.ForeColor = Color.Black;
            txtTK.Location = new Point(320, 198);
            txtTK.Margin = new Padding(2);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(254, 29);
            txtTK.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(344, 107);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 47);
            label3.TabIndex = 18;
            label3.Text = "Đăng nhập";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(227, 247);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 17;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 200);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 16;
            label1.Text = "Tài khoản";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QMK);
            Controls.Add(btExit);
            Controls.Add(btLogin);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QMK;
        private Button btExit;
        private Button btLogin;
        private TextBox txtMK;
        private TextBox txtTK;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}