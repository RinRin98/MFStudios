namespace MFStudios
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pctLogin = new DevExpress.XtraEditors.PictureEdit();
            this.lblDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblWebSite = new DevExpress.XtraEditors.LabelControl();
            this.lblForgetPass = new DevExpress.XtraEditors.LabelControl();
            this.lblPassWord = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.pctLogo = new DevExpress.XtraEditors.PictureEdit();
            this.ckPass = new DevExpress.XtraEditors.CheckEdit();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.grbSendCode = new System.Windows.Forms.GroupBox();
            this.lblVerify = new DevExpress.XtraEditors.LabelControl();
            this.lblverifyCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lblemail = new DevExpress.XtraEditors.LabelControl();
            this.txtsendUser = new DevExpress.XtraEditors.TextEdit();
            this.pctVerifyCode = new DevExpress.XtraEditors.PictureEdit();
            this.pctSendCode = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPass.Properties)).BeginInit();
            this.grbLogin.SuspendLayout();
            this.grbSendCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsendUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVerifyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSendCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogin
            // 
            this.pctLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLogin.EditValue = ((object)(resources.GetObject("pctLogin.EditValue")));
            this.pctLogin.Location = new System.Drawing.Point(81, 216);
            this.pctLogin.Name = "pctLogin";
            this.pctLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctLogin.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctLogin.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctLogin.Size = new System.Drawing.Size(115, 48);
            this.pctLogin.TabIndex = 12;
            this.pctLogin.TabStop = true;
            this.pctLogin.Click += new System.EventHandler(this.pctLogin_Click_1);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.Appearance.Options.UseFont = true;
            this.lblDangNhap.Location = new System.Drawing.Point(24, 37);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(231, 42);
            this.lblDangNhap.TabIndex = 18;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblWebSite
            // 
            this.lblWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWebSite.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebSite.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblWebSite.Appearance.Options.UseFont = true;
            this.lblWebSite.Appearance.Options.UseForeColor = true;
            this.lblWebSite.Location = new System.Drawing.Point(75, 314);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(101, 20);
            this.lblWebSite.TabIndex = 17;
            this.lblWebSite.Text = "mfstudios.vn";
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForgetPass.Location = new System.Drawing.Point(102, 270);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(79, 13);
            this.lblForgetPass.TabIndex = 14;
            this.lblForgetPass.Text = "Quên Mật Khẩu?";
            this.lblForgetPass.Click += new System.EventHandler(this.lblForgetPass_Click_1);
            // 
            // lblPassWord
            // 
            this.lblPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassWord.Location = new System.Drawing.Point(36, 145);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(45, 13);
            this.lblPassWord.TabIndex = 15;
            this.lblPassWord.Text = "Mật Khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Location = new System.Drawing.Point(36, 94);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(75, 13);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "Tên Đăng Nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(36, 115);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUserName.Size = new System.Drawing.Size(205, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcome.Location = new System.Drawing.Point(75, 134);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(298, 102);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome To\r\n       MFStudios";
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.EditValue = ((object)(resources.GetObject("pctLogo.EditValue")));
            this.pctLogo.Location = new System.Drawing.Point(52, 44);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Properties.Appearance.Options.UseBackColor = true;
            this.pctLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pctLogo.Size = new System.Drawing.Size(90, 43);
            this.pctLogo.TabIndex = 10;
            // 
            // ckPass
            // 
            this.ckPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckPass.Location = new System.Drawing.Point(117, 190);
            this.ckPass.Name = "ckPass";
            this.ckPass.Properties.Caption = "Hiện Mật Khẩu?";
            this.ckPass.Size = new System.Drawing.Size(124, 20);
            this.ckPass.TabIndex = 11;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Location = new System.Drawing.Point(36, 164);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(205, 20);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // grbLogin
            // 
            this.grbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLogin.BackColor = System.Drawing.Color.Transparent;
            this.grbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbLogin.CausesValidation = false;
            this.grbLogin.Controls.Add(this.pctLogin);
            this.grbLogin.Controls.Add(this.txtPass);
            this.grbLogin.Controls.Add(this.lblDangNhap);
            this.grbLogin.Controls.Add(this.ckPass);
            this.grbLogin.Controls.Add(this.txtUserName);
            this.grbLogin.Controls.Add(this.lblForgetPass);
            this.grbLogin.Controls.Add(this.lblUserName);
            this.grbLogin.Controls.Add(this.lblPassWord);
            this.grbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLogin.Location = new System.Drawing.Point(362, 38);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(277, 307);
            this.grbLogin.TabIndex = 19;
            this.grbLogin.TabStop = false;
            // 
            // grbSendCode
            // 
            this.grbSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSendCode.BackColor = System.Drawing.Color.White;
            this.grbSendCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbSendCode.CausesValidation = false;
            this.grbSendCode.Controls.Add(this.lblVerify);
            this.grbSendCode.Controls.Add(this.lblverifyCode);
            this.grbSendCode.Controls.Add(this.txtCode);
            this.grbSendCode.Controls.Add(this.lblemail);
            this.grbSendCode.Controls.Add(this.txtsendUser);
            this.grbSendCode.Controls.Add(this.pctVerifyCode);
            this.grbSendCode.Controls.Add(this.pctSendCode);
            this.grbSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSendCode.Location = new System.Drawing.Point(362, 38);
            this.grbSendCode.Name = "grbSendCode";
            this.grbSendCode.Size = new System.Drawing.Size(277, 307);
            this.grbSendCode.TabIndex = 19;
            this.grbSendCode.TabStop = false;
            // 
            // lblVerify
            // 
            this.lblVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVerify.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.Appearance.Options.UseFont = true;
            this.lblVerify.Location = new System.Drawing.Point(34, 34);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(208, 33);
            this.lblVerify.TabIndex = 25;
            this.lblVerify.Text = "VERIFY CODE";
            // 
            // lblverifyCode
            // 
            this.lblverifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblverifyCode.Location = new System.Drawing.Point(34, 178);
            this.lblverifyCode.Name = "lblverifyCode";
            this.lblverifyCode.Size = new System.Drawing.Size(56, 13);
            this.lblverifyCode.TabIndex = 23;
            this.lblverifyCode.Text = "Verify Code";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(66, 200);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCode.Size = new System.Drawing.Size(153, 20);
            this.txtCode.TabIndex = 19;
            // 
            // lblemail
            // 
            this.lblemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblemail.Location = new System.Drawing.Point(34, 90);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(49, 13);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "UserName";
            // 
            // txtsendUser
            // 
            this.txtsendUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsendUser.EnterMoveNextControl = true;
            this.txtsendUser.Location = new System.Drawing.Point(66, 110);
            this.txtsendUser.Name = "txtsendUser";
            this.txtsendUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtsendUser.Size = new System.Drawing.Size(153, 20);
            this.txtsendUser.TabIndex = 20;
            // 
            // pctVerifyCode
            // 
            this.pctVerifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctVerifyCode.EditValue = ((object)(resources.GetObject("pctVerifyCode.EditValue")));
            this.pctVerifyCode.Location = new System.Drawing.Point(84, 224);
            this.pctVerifyCode.Name = "pctVerifyCode";
            this.pctVerifyCode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctVerifyCode.Properties.Appearance.Options.UseBackColor = true;
            this.pctVerifyCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctVerifyCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctVerifyCode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctVerifyCode.Size = new System.Drawing.Size(115, 48);
            this.pctVerifyCode.TabIndex = 21;
            this.pctVerifyCode.TabStop = true;
            this.pctVerifyCode.Click += new System.EventHandler(this.pctVerifyCode_Click);
            // 
            // pctSendCode
            // 
            this.pctSendCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSendCode.EditValue = ((object)(resources.GetObject("pctSendCode.EditValue")));
            this.pctSendCode.Location = new System.Drawing.Point(84, 134);
            this.pctSendCode.Name = "pctSendCode";
            this.pctSendCode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctSendCode.Properties.Appearance.Options.UseBackColor = true;
            this.pctSendCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctSendCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctSendCode.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctSendCode.Size = new System.Drawing.Size(115, 48);
            this.pctSendCode.TabIndex = 22;
            this.pctSendCode.TabStop = true;
            this.pctSendCode.Click += new System.EventHandler(this.pctSendCode_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(686, 382);
            this.Controls.Add(this.grbSendCode);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.lblWebSite);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pctLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckPass.Properties)).EndInit();
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbSendCode.ResumeLayout(false);
            this.grbSendCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsendUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVerifyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSendCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pctLogin;
        private DevExpress.XtraEditors.LabelControl lblDangNhap;
        private DevExpress.XtraEditors.LabelControl lblWebSite;
        private DevExpress.XtraEditors.LabelControl lblForgetPass;
        private DevExpress.XtraEditors.LabelControl lblPassWord;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.PictureEdit pctLogo;
        private DevExpress.XtraEditors.CheckEdit ckPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.GroupBox grbSendCode;
        private DevExpress.XtraEditors.LabelControl lblVerify;
        private DevExpress.XtraEditors.LabelControl lblverifyCode;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lblemail;
        private DevExpress.XtraEditors.TextEdit txtsendUser;
        private DevExpress.XtraEditors.PictureEdit pctVerifyCode;
        private DevExpress.XtraEditors.PictureEdit pctSendCode;
    }
}