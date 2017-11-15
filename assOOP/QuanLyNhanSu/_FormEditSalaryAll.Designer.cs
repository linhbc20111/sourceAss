namespace QuanLyNhanSu
{
    partial class _FormEditSalaryAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormEditSalaryAll));
            this._labelHeader = new System.Windows.Forms.Label();
            this._labelChietKhau = new System.Windows.Forms.Label();
            this._labelLuongNgay = new System.Windows.Forms.Label();
            this._labelMess = new System.Windows.Forms.Label();
            this._tBoxChietKhau = new System.Windows.Forms.TextBox();
            this._tBoxLuongNgay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._labelVND = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelHeader
            // 
            this._labelHeader.AutoSize = true;
            this._labelHeader.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelHeader.ForeColor = System.Drawing.Color.Blue;
            this._labelHeader.Location = new System.Drawing.Point(80, 20);
            this._labelHeader.Name = "_labelHeader";
            this._labelHeader.Size = new System.Drawing.Size(125, 28);
            this._labelHeader.TabIndex = 0;
            this._labelHeader.Text = "Lương Tổng";
            // 
            // _labelChietKhau
            // 
            this._labelChietKhau.AutoSize = true;
            this._labelChietKhau.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelChietKhau.Location = new System.Drawing.Point(32, 78);
            this._labelChietKhau.Name = "_labelChietKhau";
            this._labelChietKhau.Size = new System.Drawing.Size(85, 19);
            this._labelChietKhau.TabIndex = 1;
            this._labelChietKhau.Text = "Chiết Khấu:";
            // 
            // _labelLuongNgay
            // 
            this._labelLuongNgay.AutoSize = true;
            this._labelLuongNgay.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelLuongNgay.Location = new System.Drawing.Point(12, 114);
            this._labelLuongNgay.Name = "_labelLuongNgay";
            this._labelLuongNgay.Size = new System.Drawing.Size(106, 19);
            this._labelLuongNgay.TabIndex = 2;
            this._labelLuongNgay.Text = "Lương / Ngày:";
            // 
            // _labelMess
            // 
            this._labelMess.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelMess.Location = new System.Drawing.Point(53, 137);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(165, 23);
            this._labelMess.TabIndex = 3;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._labelMess.Click += new System.EventHandler(this._labelMess_Click);
            // 
            // _tBoxChietKhau
            // 
            this._tBoxChietKhau.Location = new System.Drawing.Point(123, 77);
            this._tBoxChietKhau.Name = "_tBoxChietKhau";
            this._tBoxChietKhau.Size = new System.Drawing.Size(115, 20);
            this._tBoxChietKhau.TabIndex = 4;
            // 
            // _tBoxLuongNgay
            // 
            this._tBoxLuongNgay.Location = new System.Drawing.Point(123, 114);
            this._tBoxLuongNgay.Name = "_tBoxLuongNgay";
            this._tBoxLuongNgay.Size = new System.Drawing.Size(115, 20);
            this._tBoxLuongNgay.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(96, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _labelVND
            // 
            this._labelVND.AutoSize = true;
            this._labelVND.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelVND.Location = new System.Drawing.Point(241, 118);
            this._labelVND.Name = "_labelVND";
            this._labelVND.Size = new System.Drawing.Size(33, 16);
            this._labelVND.TabIndex = 7;
            this._labelVND.Text = "VND";
            // 
            // _FormEditSalaryAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 234);
            this.Controls.Add(this._labelVND);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._tBoxLuongNgay);
            this.Controls.Add(this._tBoxChietKhau);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._labelLuongNgay);
            this.Controls.Add(this._labelChietKhau);
            this.Controls.Add(this._labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormEditSalaryAll";
            this.Text = "Sửa Lương Tổng";
            this.Load += new System.EventHandler(this._FormEditSalaryAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelHeader;
        private System.Windows.Forms.Label _labelChietKhau;
        private System.Windows.Forms.Label _labelLuongNgay;
        private System.Windows.Forms.Label _labelMess;
        private System.Windows.Forms.TextBox _tBoxChietKhau;
        private System.Windows.Forms.TextBox _tBoxLuongNgay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _labelVND;
    }
}