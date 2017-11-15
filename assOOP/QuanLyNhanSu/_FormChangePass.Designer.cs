namespace QuanLyNhanSu
{
    partial class _FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormChangePass));
            this._labelChangePass = new System.Windows.Forms.Label();
            this._tBoxOldPass = new System.Windows.Forms.TextBox();
            this._tBoxNewPass = new System.Windows.Forms.TextBox();
            this._tBoxNewPassAgain = new System.Windows.Forms.TextBox();
            this._labelOldPass = new System.Windows.Forms.Label();
            this._labelNewPass = new System.Windows.Forms.Label();
            this._labelNewPassAgain = new System.Windows.Forms.Label();
            this._buttonChangePass = new System.Windows.Forms.Button();
            this._labelMess = new System.Windows.Forms.Label();
            this._labelNameAcc = new System.Windows.Forms.Label();
            this._tBoxNameAcc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelChangePass
            // 
            this._labelChangePass.AutoSize = true;
            this._labelChangePass.Font = new System.Drawing.Font("Sitka Subheading", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelChangePass.ForeColor = System.Drawing.Color.Navy;
            this._labelChangePass.Location = new System.Drawing.Point(77, 31);
            this._labelChangePass.Name = "_labelChangePass";
            this._labelChangePass.Size = new System.Drawing.Size(174, 32);
            this._labelChangePass.TabIndex = 0;
            this._labelChangePass.Text = "ĐỔI MẬT KHẨU";
            // 
            // _tBoxOldPass
            // 
            this._tBoxOldPass.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tBoxOldPass.Location = new System.Drawing.Point(135, 123);
            this._tBoxOldPass.Name = "_tBoxOldPass";
            this._tBoxOldPass.Size = new System.Drawing.Size(116, 23);
            this._tBoxOldPass.TabIndex = 1;
            this._tBoxOldPass.TextChanged += new System.EventHandler(this._tBoxOldPass_TextChanged);
            // 
            // _tBoxNewPass
            // 
            this._tBoxNewPass.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tBoxNewPass.Location = new System.Drawing.Point(135, 158);
            this._tBoxNewPass.Name = "_tBoxNewPass";
            this._tBoxNewPass.Size = new System.Drawing.Size(116, 23);
            this._tBoxNewPass.TabIndex = 2;
            this._tBoxNewPass.TextChanged += new System.EventHandler(this._tBoxNewPass_TextChanged);
            // 
            // _tBoxNewPassAgain
            // 
            this._tBoxNewPassAgain.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tBoxNewPassAgain.Location = new System.Drawing.Point(135, 193);
            this._tBoxNewPassAgain.Name = "_tBoxNewPassAgain";
            this._tBoxNewPassAgain.Size = new System.Drawing.Size(116, 23);
            this._tBoxNewPassAgain.TabIndex = 3;
            this._tBoxNewPassAgain.TextChanged += new System.EventHandler(this._tBoxNewPassAgain_TextChanged);
            // 
            // _labelOldPass
            // 
            this._labelOldPass.AutoSize = true;
            this._labelOldPass.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelOldPass.Location = new System.Drawing.Point(23, 127);
            this._labelOldPass.Name = "_labelOldPass";
            this._labelOldPass.Size = new System.Drawing.Size(83, 19);
            this._labelOldPass.TabIndex = 4;
            this._labelOldPass.Text = "Mật khẩu cũ:";
            // 
            // _labelNewPass
            // 
            this._labelNewPass.AutoSize = true;
            this._labelNewPass.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNewPass.Location = new System.Drawing.Point(12, 162);
            this._labelNewPass.Name = "_labelNewPass";
            this._labelNewPass.Size = new System.Drawing.Size(93, 19);
            this._labelNewPass.TabIndex = 5;
            this._labelNewPass.Text = "Mật khẩu mới:";
            // 
            // _labelNewPassAgain
            // 
            this._labelNewPassAgain.AutoSize = true;
            this._labelNewPassAgain.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNewPassAgain.Location = new System.Drawing.Point(45, 195);
            this._labelNewPassAgain.Name = "_labelNewPassAgain";
            this._labelNewPassAgain.Size = new System.Drawing.Size(61, 19);
            this._labelNewPassAgain.TabIndex = 6;
            this._labelNewPassAgain.Text = "Nhập lại:";
            // 
            // _buttonChangePass
            // 
            this._buttonChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this._buttonChangePass.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonChangePass.Location = new System.Drawing.Point(102, 252);
            this._buttonChangePass.Name = "_buttonChangePass";
            this._buttonChangePass.Size = new System.Drawing.Size(103, 30);
            this._buttonChangePass.TabIndex = 7;
            this._buttonChangePass.Text = "Thay đổi";
            this._buttonChangePass.UseVisualStyleBackColor = false;
            this._buttonChangePass.Click += new System.EventHandler(this._buttonChangePass_Click);
            // 
            // _labelMess
            // 
            this._labelMess.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelMess.Location = new System.Drawing.Point(83, 223);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(150, 26);
            this._labelMess.TabIndex = 8;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelNameAcc
            // 
            this._labelNameAcc.AutoSize = true;
            this._labelNameAcc.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelNameAcc.Location = new System.Drawing.Point(16, 93);
            this._labelNameAcc.Name = "_labelNameAcc";
            this._labelNameAcc.Size = new System.Drawing.Size(90, 19);
            this._labelNameAcc.TabIndex = 9;
            this._labelNameAcc.Text = "Tên tài khoản:";
            // 
            // _tBoxNameAcc
            // 
            this._tBoxNameAcc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._tBoxNameAcc.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tBoxNameAcc.Location = new System.Drawing.Point(135, 88);
            this._tBoxNameAcc.Name = "_tBoxNameAcc";
            this._tBoxNameAcc.ReadOnly = true;
            this._tBoxNameAcc.Size = new System.Drawing.Size(116, 24);
            this._tBoxNameAcc.TabIndex = 10;
            // 
            // _FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 310);
            this.Controls.Add(this._labelNameAcc);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._buttonChangePass);
            this.Controls.Add(this._labelNewPassAgain);
            this.Controls.Add(this._labelNewPass);
            this.Controls.Add(this._labelOldPass);
            this.Controls.Add(this._tBoxNewPassAgain);
            this.Controls.Add(this._tBoxNewPass);
            this.Controls.Add(this._tBoxOldPass);
            this.Controls.Add(this._labelChangePass);
            this.Controls.Add(this._tBoxNameAcc);
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_FormChangePass";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this._FormChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelChangePass;
        private System.Windows.Forms.TextBox _tBoxOldPass;
        private System.Windows.Forms.TextBox _tBoxNewPass;
        private System.Windows.Forms.TextBox _tBoxNewPassAgain;
        private System.Windows.Forms.Label _labelOldPass;
        private System.Windows.Forms.Label _labelNewPass;
        private System.Windows.Forms.Label _labelNewPassAgain;
        private System.Windows.Forms.Button _buttonChangePass;
        private System.Windows.Forms.Label _labelMess;
        private System.Windows.Forms.Label _labelNameAcc;
        private System.Windows.Forms.TextBox _tBoxNameAcc;
    }
}