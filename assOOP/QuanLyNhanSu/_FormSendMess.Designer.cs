namespace QuanLyNhanSu
{
    partial class _FormSendMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormSendMess));
            this._labelNameSendMess = new System.Windows.Forms.Label();
            this._labelSendTo = new System.Windows.Forms.Label();
            this._labelTieuDe = new System.Windows.Forms.Label();
            this._chBoxSendAll = new System.Windows.Forms.CheckBox();
            this._labelContent = new System.Windows.Forms.Label();
            this._tBoxTieuDe = new System.Windows.Forms.TextBox();
            this._tBoxContent = new System.Windows.Forms.TextBox();
            this._tBoxIDSendTo = new System.Windows.Forms.TextBox();
            this._buttonSend = new System.Windows.Forms.Button();
            this._labelMessWErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelNameSendMess
            // 
            this._labelNameSendMess.AutoSize = true;
            this._labelNameSendMess.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelNameSendMess.ForeColor = System.Drawing.Color.MediumBlue;
            this._labelNameSendMess.Location = new System.Drawing.Point(99, 37);
            this._labelNameSendMess.Name = "_labelNameSendMess";
            this._labelNameSendMess.Size = new System.Drawing.Size(152, 28);
            this._labelNameSendMess.TabIndex = 0;
            this._labelNameSendMess.Text = "Gửi Thông Báo";
            // 
            // _labelSendTo
            // 
            this._labelSendTo.AutoSize = true;
            this._labelSendTo.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelSendTo.Location = new System.Drawing.Point(28, 96);
            this._labelSendTo.Name = "_labelSendTo";
            this._labelSendTo.Size = new System.Drawing.Size(95, 16);
            this._labelSendTo.TabIndex = 1;
            this._labelSendTo.Text = "ID Người Nhận:";
            // 
            // _labelTieuDe
            // 
            this._labelTieuDe.AutoSize = true;
            this._labelTieuDe.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelTieuDe.Location = new System.Drawing.Point(70, 174);
            this._labelTieuDe.Name = "_labelTieuDe";
            this._labelTieuDe.Size = new System.Drawing.Size(53, 16);
            this._labelTieuDe.TabIndex = 2;
            this._labelTieuDe.Text = "Tiêu Đề:";
            // 
            // _chBoxSendAll
            // 
            this._chBoxSendAll.AutoSize = true;
            this._chBoxSendAll.Location = new System.Drawing.Point(121, 128);
            this._chBoxSendAll.Name = "_chBoxSendAll";
            this._chBoxSendAll.Size = new System.Drawing.Size(77, 17);
            this._chBoxSendAll.TabIndex = 3;
            this._chBoxSendAll.Text = "Gửi Tất Cả";
            this._chBoxSendAll.UseVisualStyleBackColor = true;
            this._chBoxSendAll.CheckedChanged += new System.EventHandler(this._chBoxSendAll_CheckedChanged);
            // 
            // _labelContent
            // 
            this._labelContent.AutoSize = true;
            this._labelContent.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelContent.Location = new System.Drawing.Point(138, 204);
            this._labelContent.Name = "_labelContent";
            this._labelContent.Size = new System.Drawing.Size(60, 16);
            this._labelContent.TabIndex = 5;
            this._labelContent.Text = "Nội Dung";
            // 
            // _tBoxTieuDe
            // 
            this._tBoxTieuDe.Location = new System.Drawing.Point(129, 170);
            this._tBoxTieuDe.Name = "_tBoxTieuDe";
            this._tBoxTieuDe.Size = new System.Drawing.Size(182, 20);
            this._tBoxTieuDe.TabIndex = 7;
            // 
            // _tBoxContent
            // 
            this._tBoxContent.Location = new System.Drawing.Point(31, 223);
            this._tBoxContent.Multiline = true;
            this._tBoxContent.Name = "_tBoxContent";
            this._tBoxContent.Size = new System.Drawing.Size(280, 180);
            this._tBoxContent.TabIndex = 8;
            // 
            // _tBoxIDSendTo
            // 
            this._tBoxIDSendTo.Location = new System.Drawing.Point(129, 92);
            this._tBoxIDSendTo.Name = "_tBoxIDSendTo";
            this._tBoxIDSendTo.Size = new System.Drawing.Size(131, 20);
            this._tBoxIDSendTo.TabIndex = 6;
            // 
            // _buttonSend
            // 
            this._buttonSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonSend.Location = new System.Drawing.Point(128, 434);
            this._buttonSend.Name = "_buttonSend";
            this._buttonSend.Size = new System.Drawing.Size(75, 32);
            this._buttonSend.TabIndex = 9;
            this._buttonSend.Text = "Gửi";
            this._buttonSend.UseVisualStyleBackColor = false;
            this._buttonSend.Click += new System.EventHandler(this._buttonSend_Click);
            // 
            // _labelMessWErr
            // 
            this._labelMessWErr.Location = new System.Drawing.Point(73, 410);
            this._labelMessWErr.Name = "_labelMessWErr";
            this._labelMessWErr.Size = new System.Drawing.Size(181, 23);
            this._labelMessWErr.TabIndex = 10;
            this._labelMessWErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _FormSendMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 474);
            this.Controls.Add(this._labelMessWErr);
            this.Controls.Add(this._buttonSend);
            this.Controls.Add(this._tBoxContent);
            this.Controls.Add(this._tBoxTieuDe);
            this.Controls.Add(this._tBoxIDSendTo);
            this.Controls.Add(this._labelContent);
            this.Controls.Add(this._chBoxSendAll);
            this.Controls.Add(this._labelTieuDe);
            this.Controls.Add(this._labelSendTo);
            this.Controls.Add(this._labelNameSendMess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormSendMess";
            this.Text = "Gửi Thông Báo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelNameSendMess;
        private System.Windows.Forms.Label _labelSendTo;
        private System.Windows.Forms.Label _labelTieuDe;
        private System.Windows.Forms.CheckBox _chBoxSendAll;
        private System.Windows.Forms.Label _labelContent;
        private System.Windows.Forms.TextBox _tBoxTieuDe;
        private System.Windows.Forms.TextBox _tBoxContent;
        private System.Windows.Forms.TextBox _tBoxIDSendTo;
        private System.Windows.Forms.Button _buttonSend;
        private System.Windows.Forms.Label _labelMessWErr;
    }
}