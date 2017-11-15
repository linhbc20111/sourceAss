namespace QuanLyNhanSu
{
    partial class _FormMessToChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormMessToChangeInfo));
            this._tBoxPass = new System.Windows.Forms.TextBox();
            this._labelRequire = new System.Windows.Forms.Label();
            this._buttonOK = new System.Windows.Forms.Button();
            this._labelMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tBoxPass
            // 
            this._tBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._tBoxPass.Location = new System.Drawing.Point(59, 89);
            this._tBoxPass.Name = "_tBoxPass";
            this._tBoxPass.Size = new System.Drawing.Size(138, 22);
            this._tBoxPass.TabIndex = 0;
            this._tBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._tBoxPass.TextChanged += new System.EventHandler(this._tBoxPass_TextChanged);
            // 
            // _labelRequire
            // 
            this._labelRequire.AutoSize = true;
            this._labelRequire.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelRequire.Location = new System.Drawing.Point(12, 56);
            this._labelRequire.Name = "_labelRequire";
            this._labelRequire.Size = new System.Drawing.Size(242, 19);
            this._labelRequire.TabIndex = 1;
            this._labelRequire.Text = "Vui lòng nhập mật khẩu để tiếp tục!";
            // 
            // _buttonOK
            // 
            this._buttonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonOK.Location = new System.Drawing.Point(97, 138);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(58, 23);
            this._buttonOK.TabIndex = 2;
            this._buttonOK.Text = "OK";
            this._buttonOK.UseVisualStyleBackColor = false;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _labelMess
            // 
            this._labelMess.Location = new System.Drawing.Point(59, 119);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(138, 16);
            this._labelMess.TabIndex = 3;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _FormMessToChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(259, 244);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._buttonOK);
            this.Controls.Add(this._labelRequire);
            this.Controls.Add(this._tBoxPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormMessToChangeInfo";
            this.Text = "Yêu cầu Mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tBoxPass;
        private System.Windows.Forms.Label _labelRequire;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Label _labelMess;
    }
}