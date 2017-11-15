namespace QuanLyNhanSu
{
    partial class _FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormLogin));
            this._iconUser = new System.Windows.Forms.PictureBox();
            this._iconPass = new System.Windows.Forms.PictureBox();
            this._account = new System.Windows.Forms.TextBox();
            this._passWord = new System.Windows.Forms.TextBox();
            this._buttonLogin = new System.Windows.Forms.Button();
            this._labelHideMess = new System.Windows.Forms.Label();
            this._labelclickForgetPass = new System.Windows.Forms.Label();
            this._labelClickSignUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._iconPass)).BeginInit();
            this.SuspendLayout();
            // 
            // _iconUser
            // 
            this._iconUser.BackColor = System.Drawing.Color.Transparent;
            this._iconUser.Image = global::QuanLyNhanSu.Properties.Resources.User_Avatar_512;
            this._iconUser.Location = new System.Drawing.Point(45, 222);
            this._iconUser.Name = "_iconUser";
            this._iconUser.Size = new System.Drawing.Size(34, 33);
            this._iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._iconUser.TabIndex = 0;
            this._iconUser.TabStop = false;
            // 
            // _iconPass
            // 
            this._iconPass.BackColor = System.Drawing.Color.Transparent;
            this._iconPass.Image = global::QuanLyNhanSu.Properties.Resources._674008_key_reg_registration_register_signup_sign_up_512;
            this._iconPass.Location = new System.Drawing.Point(45, 271);
            this._iconPass.Name = "_iconPass";
            this._iconPass.Size = new System.Drawing.Size(34, 32);
            this._iconPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._iconPass.TabIndex = 1;
            this._iconPass.TabStop = false;
            this._iconPass.Click += new System.EventHandler(this._iconPass_Click);
            // 
            // _account
            // 
            this._account.BackColor = System.Drawing.Color.LightGray;
            this._account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._account.Location = new System.Drawing.Point(95, 222);
            this._account.Name = "_account";
            this._account.Size = new System.Drawing.Size(144, 29);
            this._account.TabIndex = 2;
            this._account.TextChanged += new System.EventHandler(this._account_TextChanged);
            this._account.KeyDown += new System.Windows.Forms.KeyEventHandler(this._account_KeyDown);
            // 
            // _passWord
            // 
            this._passWord.BackColor = System.Drawing.Color.LightGray;
            this._passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._passWord.Location = new System.Drawing.Point(95, 271);
            this._passWord.Name = "_passWord";
            this._passWord.Size = new System.Drawing.Size(144, 29);
            this._passWord.TabIndex = 3;
            this._passWord.TextChanged += new System.EventHandler(this._passWord_TextChanged);
            this._passWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this._passWord_KeyDown);
            // 
            // _buttonLogin
            // 
            this._buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonLogin.Image = global::QuanLyNhanSu.Properties.Resources.Login;
            this._buttonLogin.Location = new System.Drawing.Point(108, 340);
            this._buttonLogin.Name = "_buttonLogin";
            this._buttonLogin.Size = new System.Drawing.Size(111, 30);
            this._buttonLogin.TabIndex = 4;
            this._buttonLogin.UseVisualStyleBackColor = true;
            this._buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // _labelHideMess
            // 
            this._labelHideMess.BackColor = System.Drawing.Color.Transparent;
            this._labelHideMess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._labelHideMess.Location = new System.Drawing.Point(60, 315);
            this._labelHideMess.MaximumSize = new System.Drawing.Size(220, 13);
            this._labelHideMess.MinimumSize = new System.Drawing.Size(127, 13);
            this._labelHideMess.Name = "_labelHideMess";
            this._labelHideMess.Size = new System.Drawing.Size(220, 13);
            this._labelHideMess.TabIndex = 5;
            this._labelHideMess.Text = " ";
            this._labelHideMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelclickForgetPass
            // 
            this._labelclickForgetPass.AutoSize = true;
            this._labelclickForgetPass.BackColor = System.Drawing.Color.Transparent;
            this._labelclickForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this._labelclickForgetPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._labelclickForgetPass.Location = new System.Drawing.Point(121, 373);
            this._labelclickForgetPass.Name = "_labelclickForgetPass";
            this._labelclickForgetPass.Size = new System.Drawing.Size(86, 13);
            this._labelclickForgetPass.TabIndex = 6;
            this._labelclickForgetPass.Text = "Quên mật khẩu?";
            this._labelclickForgetPass.Click += new System.EventHandler(this._labelclickForgetPass_Click);
            // 
            // _labelClickSignUp
            // 
            this._labelClickSignUp.AutoSize = true;
            this._labelClickSignUp.BackColor = System.Drawing.Color.Transparent;
            this._labelClickSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this._labelClickSignUp.ForeColor = System.Drawing.Color.White;
            this._labelClickSignUp.Location = new System.Drawing.Point(137, 395);
            this._labelClickSignUp.Name = "_labelClickSignUp";
            this._labelClickSignUp.Size = new System.Drawing.Size(47, 13);
            this._labelClickSignUp.TabIndex = 7;
            this._labelClickSignUp.Text = "Đăng ký";
            this._labelClickSignUp.Click += new System.EventHandler(this._labelClickSignUp_Click);
            // 
            // _FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.background_login;
            this.ClientSize = new System.Drawing.Size(301, 490);
            this.Controls.Add(this._labelClickSignUp);
            this.Controls.Add(this._labelclickForgetPass);
            this.Controls.Add(this._labelHideMess);
            this.Controls.Add(this._buttonLogin);
            this.Controls.Add(this._passWord);
            this.Controls.Add(this._account);
            this.Controls.Add(this._iconPass);
            this.Controls.Add(this._iconUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(317, 529);
            this.MinimumSize = new System.Drawing.Size(317, 529);
            this.Name = "_FormLogin";
            this.Text = "Đăng Nhập - Quản Lý Nhân Sự";
            ((System.ComponentModel.ISupportInitialize)(this._iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._iconPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _iconUser;
        private System.Windows.Forms.PictureBox _iconPass;
        private System.Windows.Forms.TextBox _account;
        private System.Windows.Forms.TextBox _passWord;
        private System.Windows.Forms.Button _buttonLogin;
        private System.Windows.Forms.Label _labelHideMess;
        private System.Windows.Forms.Label _labelclickForgetPass;
        private System.Windows.Forms.Label _labelClickSignUp;
    }
}

