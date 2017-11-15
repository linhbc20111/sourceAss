namespace QuanLyNhanSu
{
    partial class _FormSendFeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormSendFeedBack));
            this._labelHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._labelTieuDe = new System.Windows.Forms.Label();
            this._labelContent = new System.Windows.Forms.Label();
            this._tBoxTieuDe = new System.Windows.Forms.TextBox();
            this._tBoxContent = new System.Windows.Forms.TextBox();
            this._labelID = new System.Windows.Forms.Label();
            this._buttonSend = new System.Windows.Forms.Button();
            this._labelMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelHeader
            // 
            this._labelHeader.AutoSize = true;
            this._labelHeader.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelHeader.ForeColor = System.Drawing.Color.MediumBlue;
            this._labelHeader.Location = new System.Drawing.Point(116, 31);
            this._labelHeader.Name = "_labelHeader";
            this._labelHeader.Size = new System.Drawing.Size(99, 28);
            this._labelHeader.TabIndex = 0;
            this._labelHeader.Text = "Phản Hồi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Người Gửi:";
            // 
            // _labelTieuDe
            // 
            this._labelTieuDe.AutoSize = true;
            this._labelTieuDe.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelTieuDe.Location = new System.Drawing.Point(61, 124);
            this._labelTieuDe.Name = "_labelTieuDe";
            this._labelTieuDe.Size = new System.Drawing.Size(64, 19);
            this._labelTieuDe.TabIndex = 2;
            this._labelTieuDe.Text = "Tiêu Đề:";
            // 
            // _labelContent
            // 
            this._labelContent.AutoSize = true;
            this._labelContent.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelContent.Location = new System.Drawing.Point(130, 157);
            this._labelContent.Name = "_labelContent";
            this._labelContent.Size = new System.Drawing.Size(76, 19);
            this._labelContent.TabIndex = 3;
            this._labelContent.Text = "Nội Dung:";
            // 
            // _tBoxTieuDe
            // 
            this._tBoxTieuDe.Location = new System.Drawing.Point(134, 123);
            this._tBoxTieuDe.Name = "_tBoxTieuDe";
            this._tBoxTieuDe.Size = new System.Drawing.Size(181, 20);
            this._tBoxTieuDe.TabIndex = 5;
            // 
            // _tBoxContent
            // 
            this._tBoxContent.Location = new System.Drawing.Point(26, 179);
            this._tBoxContent.Multiline = true;
            this._tBoxContent.Name = "_tBoxContent";
            this._tBoxContent.Size = new System.Drawing.Size(289, 189);
            this._tBoxContent.TabIndex = 6;
            // 
            // _labelID
            // 
            this._labelID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelID.Location = new System.Drawing.Point(131, 89);
            this._labelID.Name = "_labelID";
            this._labelID.Size = new System.Drawing.Size(156, 23);
            this._labelID.TabIndex = 7;
            this._labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _buttonSend
            // 
            this._buttonSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonSend.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonSend.Location = new System.Drawing.Point(134, 400);
            this._buttonSend.Name = "_buttonSend";
            this._buttonSend.Size = new System.Drawing.Size(72, 34);
            this._buttonSend.TabIndex = 8;
            this._buttonSend.Text = "Gửi";
            this._buttonSend.UseVisualStyleBackColor = false;
            this._buttonSend.Click += new System.EventHandler(this._buttonSend_Click);
            // 
            // _labelMess
            // 
            this._labelMess.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelMess.Location = new System.Drawing.Point(65, 374);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(204, 23);
            this._labelMess.TabIndex = 9;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _FormSendFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 446);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._buttonSend);
            this.Controls.Add(this._labelID);
            this.Controls.Add(this._tBoxContent);
            this.Controls.Add(this._tBoxTieuDe);
            this.Controls.Add(this._labelContent);
            this.Controls.Add(this._labelTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormSendFeedBack";
            this.Text = "Gửi Phản Hồi";
            this.Load += new System.EventHandler(this._FormSendFeedBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _labelTieuDe;
        private System.Windows.Forms.Label _labelContent;
        private System.Windows.Forms.TextBox _tBoxTieuDe;
        private System.Windows.Forms.TextBox _tBoxContent;
        private System.Windows.Forms.Label _labelID;
        private System.Windows.Forms.Button _buttonSend;
        private System.Windows.Forms.Label _labelMess;
    }
}