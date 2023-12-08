namespace C_PRL.Forms
{
    partial class Quenmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quenmk));
            label3 = new Label();
            txtTK = new TextBox();
            txtMK = new TextBox();
            btLogin = new Button();
            QMK = new Label();
            panel1 = new Panel();
            vButton1 = new VButton();
            vButton3 = new VButton();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(437, 41);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 40);
            label3.TabIndex = 25;
            label3.Text = "Quên mật khẩu";
            // 
            // txtTK
            // 
            txtTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.ForeColor = Color.Black;
            txtTK.Location = new Point(416, 110);
            txtTK.Margin = new Padding(2);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Nhập email";
            txtTK.Size = new Size(289, 29);
            txtTK.TabIndex = 26;
            txtTK.TextChanged += txtTK_TextChanged;
            // 
            // txtMK
            // 
            txtMK.Enabled = false;
            txtMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.ForeColor = Color.Black;
            txtMK.Location = new Point(416, 178);
            txtMK.Margin = new Padding(2);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(110, 29);
            txtMK.TabIndex = 27;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.MintCream;
            btLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btLogin.ForeColor = SystemColors.HotTrack;
            btLogin.Location = new Point(548, 178);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 27);
            btLogin.TabIndex = 28;
            btLogin.Text = "Gửi mã OTP";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // QMK
            // 
            QMK.AutoSize = true;
            QMK.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            QMK.ForeColor = Color.LightSeaGreen;
            QMK.Location = new Point(320, 187);
            QMK.Margin = new Padding(2, 0, 2, 0);
            QMK.Name = "QMK";
            QMK.Size = new Size(67, 20);
            QMK.TabIndex = 30;
            QMK.Text = "Mã OTP:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 410);
            panel1.TabIndex = 31;
            // 
            // vButton1
            // 
            vButton1.BackColor = Color.Peru;
            vButton1.BackgroundColor = Color.Peru;
            vButton1.BorderColor = Color.PaleVioletRed;
            vButton1.BorderRadius = 18;
            vButton1.BorderSize = 0;
            vButton1.FlatAppearance.BorderSize = 0;
            vButton1.FlatStyle = FlatStyle.Flat;
            vButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            vButton1.ForeColor = Color.White;
            vButton1.Location = new Point(401, 259);
            vButton1.Name = "vButton1";
            vButton1.Size = new Size(100, 33);
            vButton1.TabIndex = 32;
            vButton1.Text = "Xác nhận";
            vButton1.TextColor = Color.White;
            vButton1.UseVisualStyleBackColor = false;
            vButton1.Click += vButton1_Click;
            // 
            // vButton3
            // 
            vButton3.BackColor = Color.Peru;
            vButton3.BackgroundColor = Color.Peru;
            vButton3.BorderColor = Color.PaleVioletRed;
            vButton3.BorderRadius = 18;
            vButton3.BorderSize = 0;
            vButton3.FlatAppearance.BorderSize = 0;
            vButton3.FlatStyle = FlatStyle.Flat;
            vButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            vButton3.ForeColor = Color.White;
            vButton3.Location = new Point(548, 259);
            vButton3.Name = "vButton3";
            vButton3.Size = new Size(100, 33);
            vButton3.TabIndex = 34;
            vButton3.Text = "Thoát";
            vButton3.TextColor = Color.White;
            vButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(319, 119);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 35;
            label1.Text = "Nhập email:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(321, 229);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 36;
            // 
            // Quenmk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 410);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vButton3);
            Controls.Add(vButton1);
            Controls.Add(panel1);
            Controls.Add(QMK);
            Controls.Add(btLogin);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(label3);
            Name = "Quenmk";
            Text = "Quenmk";
            Load += Quenmk_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtTK;
        private TextBox txtMK;
        private Button btLogin;
        private Label QMK;
        private Panel panel1;
        private VButton vButton1;
        private VButton vButton3;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label label2;
    }
}