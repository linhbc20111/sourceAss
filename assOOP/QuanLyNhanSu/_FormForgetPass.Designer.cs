namespace QuanLyNhanSu
{
    partial class _FormForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormForgetPass));
            this._labelForgetPass = new System.Windows.Forms.Label();
            this._tBoxNameAcc = new System.Windows.Forms.TextBox();
            this._tBoxNewPass = new System.Windows.Forms.TextBox();
            this._tBoxNewPassAgain = new System.Windows.Forms.TextBox();
            this._labelNameAcc = new System.Windows.Forms.Label();
            this._labelNewPass = new System.Windows.Forms.Label();
            this._labelNewPassAgain = new System.Windows.Forms.Label();
            this._labelRequire = new System.Windows.Forms.Label();
            this._buttonSendRequire = new System.Windows.Forms.Button();
            this._labelMess = new System.Windows.Forms.Label();
            this._chBoxRequire = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _labelForgetPass
            // 
            this._labelForgetPass.AutoSize = true;
            this._labelForgetPass.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelForgetPass.Location = new System.Drawing.Point(53, 25);
            this._labelForgetPass.Name = "_labelForgetPass";
            this._labelForgetPass.Size = new System.Drawing.Size(185, 30);
            this._labelForgetPass.TabIndex = 0;
            this._labelForgetPass.Text = "QUÊN MẬT KHẨU";
            // 
            // _tBoxNameAcc
            // 
            this._tBoxNameAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._tBoxNameAcc.Location = new System.Drawing.Point(125, 85);
            this._tBoxNameAcc.Name = "_tBoxNameAcc";
            this._tBoxNameAcc.Size = new System.Drawing.Size(113, 26);
            this._tBoxNameAcc.TabIndex = 1;
            // 
            // _tBoxNewPass
            // 
            this._tBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._tBoxNewPass.Location = new System.Drawing.Point(125, 137);
            this._tBoxNewPass.Name = "_tBoxNewPass";
            this._tBoxNewPass.Size = new System.Drawing.Size(113, 26);
            this._tBoxNewPass.TabIndex = 2;
            this._tBoxNewPass.TextChanged += new System.EventHandler(this._tBoxNewPass_TextChanged);
            // 
            // _tBoxNewPassAgain
            // 
            this._tBoxNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._tBoxNewPassAgain.Location = new System.Drawing.Point(125, 182);
            this._tBoxNewPassAgain.Name = "_tBoxNewPassAgain";
            this._tBoxNewPassAgain.Size = new System.Drawing.Size(113, 26);
            this._tBoxNewPassAgain.TabIndex = 3;
            this._tBoxNewPassAgain.TextChanged += new System.EventHandler(this._tBoxNewPassAgain_TextChanged);
            // 
            // _labelNameAcc
            // 
            this._labelNameAcc.AutoSize = true;
            this._labelNameAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelNameAcc.Location = new System.Drawing.Point(37, 91);
            this._labelNameAcc.Name = "_labelNameAcc";
            this._labelNameAcc.Size = new System.Drawing.Size(82, 20);
            this._labelNameAcc.TabIndex = 4;
            this._labelNameAcc.Text = "Tài khoản:";
            // 
            // _labelNewPass
            // 
            this._labelNewPass.AutoSize = true;
            this._labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelNewPass.Location = new System.Drawing.Point(11, 143);
            this._labelNewPass.Name = "_labelNewPass";
            this._labelNewPass.Size = new System.Drawing.Size(108, 20);
            this._labelNewPass.TabIndex = 5;
            this._labelNewPass.Text = "Mật khẩu mới:";
            // 
            // _labelNewPassAgain
            // 
            this._labelNewPassAgain.AutoSize = true;
            this._labelNewPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelNewPassAgain.Location = new System.Drawing.Point(49, 188);
            this._labelNewPassAgain.Name = "_labelNewPassAgain";
            this._labelNewPassAgain.Size = new System.Drawing.Size(70, 20);
            this._labelNewPassAgain.TabIndex = 6;
            this._labelNewPassAgain.Text = "Nhập lại:";
            // 
            // _labelRequire
            // 
            this._labelRequire.Location = new System.Drawing.Point(55, 238);
            this._labelRequire.Name = "_labelRequire";
            this._labelRequire.Size = new System.Drawing.Size(188, 40);
            this._labelRequire.TabIndex = 7;
            this._labelRequire.Text = "Sau khi gửi yêu cầu, anh/chị vui lòng    đến bộ phận nhân sự để xác nhận!        " +
    "              Xin cảm ơn!";
            // 
            // _buttonSendRequire
            // 
            this._buttonSendRequire.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonSendRequire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonSendRequire.Location = new System.Drawing.Point(93, 296);
            this._buttonSendRequire.Name = "_buttonSendRequire";
            this._buttonSendRequire.Size = new System.Drawing.Size(99, 33);
            this._buttonSendRequire.TabIndex = 8;
            this._buttonSendRequire.Text = "Gửi yêu cầu";
            this._buttonSendRequire.UseVisualStyleBackColor = false;
            this._buttonSendRequire.Click += new System.EventHandler(this._buttonSendRequire_Click);
            // 
            // _labelMess
            // 
            this._labelMess.Location = new System.Drawing.Point(69, 215);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(156, 23);
            this._labelMess.TabIndex = 9;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _chBoxRequire
            // 
            this._chBoxRequire.AutoSize = true;
            this._chBoxRequire.Location = new System.Drawing.Point(34, 247);
            this._chBoxRequire.Name = "_chBoxRequire";
            this._chBoxRequire.Size = new System.Drawing.Size(15, 14);
            this._chBoxRequire.TabIndex = 10;
            this._chBoxRequire.UseVisualStyleBackColor = true;
            // 
            // _FormForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 341);
            this.Controls.Add(this._chBoxRequire);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._buttonSendRequire);
            this.Controls.Add(this._labelRequire);
            this.Controls.Add(this._labelNewPassAgain);
            this.Controls.Add(this._labelNewPass);
            this.Controls.Add(this._labelNameAcc);
            this.Controls.Add(this._tBoxNewPassAgain);
            this.Controls.Add(this._tBoxNewPass);
            this.Controls.Add(this._tBoxNameAcc);
            this.Controls.Add(this._labelForgetPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormForgetPass";
            this.Text = "Quên Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelForgetPass;
        private System.Windows.Forms.TextBox _tBoxNameAcc;
        private System.Windows.Forms.TextBox _tBoxNewPass;
        private System.Windows.Forms.TextBox _tBoxNewPassAgain;
        private System.Windows.Forms.Label _labelNameAcc;
        private System.Windows.Forms.Label _labelNewPass;
        private System.Windows.Forms.Label _labelNewPassAgain;
        private System.Windows.Forms.Label _labelRequire;
        private System.Windows.Forms.Button _buttonSendRequire;
        private System.Windows.Forms.Label _labelMess;
        private System.Windows.Forms.CheckBox _chBoxRequire;
    }
}