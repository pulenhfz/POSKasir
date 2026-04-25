namespace POSKasir
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppSub = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubWelcome = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelTxtUser = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelTxtPass = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelTxtUser.SuspendLayout();
            this.panelTxtPass.SuspendLayout();
            this.SuspendLayout();

            // panelLeft
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelLeft.Controls.Add(this.lblVersion);
            this.panelLeft.Controls.Add(this.lblAppSub);
            this.panelLeft.Controls.Add(this.lblAppName);
            this.panelLeft.Controls.Add(this.lblAppIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 450);

            // lblAppIcon
            this.lblAppIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblAppIcon.ForeColor = System.Drawing.Color.White;
            this.lblAppIcon.Location = new System.Drawing.Point(0, 90);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(280, 70);
            this.lblAppIcon.Text = "\U0001F6D2";
            this.lblAppIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblAppName
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(0, 170);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(280, 45);
            this.lblAppName.Text = "POS Kasir";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblAppSub
            this.lblAppSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppSub.ForeColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.lblAppSub.Location = new System.Drawing.Point(0, 218);
            this.lblAppSub.Name = "lblAppSub";
            this.lblAppSub.Size = new System.Drawing.Size(280, 30);
            this.lblAppSub.Text = "Sistem Kasir Sederhana";
            this.lblAppSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblVersion
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(100, 115, 120);
            this.lblVersion.Location = new System.Drawing.Point(0, 422);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(280, 18);
            this.lblVersion.Text = "v1.0 - Universitas Amikom Purwokerto";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelRight
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelRight.Controls.Add(this.btnKeluar);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.panelTxtPass);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.panelTxtUser);
            this.panelRight.Controls.Add(this.lblUsername);
            this.panelRight.Controls.Add(this.panelSeparator);
            this.panelRight.Controls.Add(this.lblSubWelcome);
            this.panelRight.Controls.Add(this.lblWelcome);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(280, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(470, 450);

            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblWelcome.Location = new System.Drawing.Point(40, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(390, 40);
            this.lblWelcome.Text = "Selamat Datang!";

            // lblSubWelcome
            this.lblSubWelcome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubWelcome.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblSubWelcome.Location = new System.Drawing.Point(40, 96);
            this.lblSubWelcome.Name = "lblSubWelcome";
            this.lblSubWelcome.Size = new System.Drawing.Size(390, 20);
            this.lblSubWelcome.Text = "Masuk ke akun Anda untuk melanjutkan";

            // panelSeparator
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.panelSeparator.Location = new System.Drawing.Point(40, 126);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(390, 1);

            // lblUsername
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblUsername.Location = new System.Drawing.Point(40, 142);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(390, 18);
            this.lblUsername.Text = "USERNAME";

            // panelTxtUser
            this.panelTxtUser.BackColor = System.Drawing.Color.FromArgb(232, 236, 240);
            this.panelTxtUser.Controls.Add(this.txtUsername);
            this.panelTxtUser.Location = new System.Drawing.Point(40, 162);
            this.panelTxtUser.Name = "panelTxtUser";
            this.panelTxtUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelTxtUser.Size = new System.Drawing.Size(390, 40);

            // txtUsername
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(232, 236, 240);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);

            // lblPassword
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.lblPassword.Location = new System.Drawing.Point(40, 218);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(390, 18);
            this.lblPassword.Text = "PASSWORD";

            // panelTxtPass
            this.panelTxtPass.BackColor = System.Drawing.Color.FromArgb(232, 236, 240);
            this.panelTxtPass.Controls.Add(this.txtPassword);
            this.panelTxtPass.Location = new System.Drawing.Point(40, 238);
            this.panelTxtPass.Name = "panelTxtPass";
            this.panelTxtPass.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelTxtPass.Size = new System.Drawing.Size(390, 40);

            // txtPassword
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(232, 236, 240);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(390, 48);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "MASUK";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);

            // btnKeluar
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
            this.btnKeluar.Location = new System.Drawing.Point(40, 362);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(390, 32);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar dari Aplikasi";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);

            // FormLogin
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS Kasir - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelTxtUser.ResumeLayout(false);
            this.panelTxtUser.PerformLayout();
            this.panelTxtPass.ResumeLayout(false);
            this.panelTxtPass.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAppIcon;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubWelcome;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelTxtUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panelTxtPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnKeluar;
    }
}
