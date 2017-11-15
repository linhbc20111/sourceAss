namespace QuanLyNhanSu
{
    partial class _FormChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormChuyen));
            this._labelChuyenChucVu = new System.Windows.Forms.Label();
            this._chBoxQuanLy = new System.Windows.Forms.CheckBox();
            this._chBoxNhanVien = new System.Windows.Forms.CheckBox();
            this._buttonChuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelChuyenChucVu
            // 
            this._labelChuyenChucVu.AutoSize = true;
            this._labelChuyenChucVu.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelChuyenChucVu.ForeColor = System.Drawing.Color.Blue;
            this._labelChuyenChucVu.Location = new System.Drawing.Point(67, 25);
            this._labelChuyenChucVu.Name = "_labelChuyenChucVu";
            this._labelChuyenChucVu.Size = new System.Drawing.Size(167, 28);
            this._labelChuyenChucVu.TabIndex = 0;
            this._labelChuyenChucVu.Text = "Chuyển Chức Vụ";
            // 
            // _chBoxQuanLy
            // 
            this._chBoxQuanLy.AutoSize = true;
            this._chBoxQuanLy.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._chBoxQuanLy.Location = new System.Drawing.Point(83, 88);
            this._chBoxQuanLy.Name = "_chBoxQuanLy";
            this._chBoxQuanLy.Size = new System.Drawing.Size(15, 14);
            this._chBoxQuanLy.TabIndex = 1;
            this._chBoxQuanLy.UseVisualStyleBackColor = true;
            this._chBoxQuanLy.CheckedChanged += new System.EventHandler(this._chBoxQuanLy_CheckedChanged);
            // 
            // _chBoxNhanVien
            // 
            this._chBoxNhanVien.AutoSize = true;
            this._chBoxNhanVien.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._chBoxNhanVien.Location = new System.Drawing.Point(83, 119);
            this._chBoxNhanVien.Name = "_chBoxNhanVien";
            this._chBoxNhanVien.Size = new System.Drawing.Size(96, 23);
            this._chBoxNhanVien.TabIndex = 2;
            this._chBoxNhanVien.Text = "Nhân Viên";
            this._chBoxNhanVien.UseVisualStyleBackColor = true;
            this._chBoxNhanVien.CheckedChanged += new System.EventHandler(this._chBoxNhanVien_CheckedChanged);
            // 
            // _buttonChuyen
            // 
            this._buttonChuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonChuyen.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonChuyen.Location = new System.Drawing.Point(104, 174);
            this._buttonChuyen.Name = "_buttonChuyen";
            this._buttonChuyen.Size = new System.Drawing.Size(82, 40);
            this._buttonChuyen.TabIndex = 3;
            this._buttonChuyen.Text = "Chuyển";
            this._buttonChuyen.UseVisualStyleBackColor = false;
            this._buttonChuyen.Click += new System.EventHandler(this._buttonChuyen_Click);
            // 
            // _FormChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._buttonChuyen);
            this.Controls.Add(this._chBoxNhanVien);
            this.Controls.Add(this._chBoxQuanLy);
            this.Controls.Add(this._labelChuyenChucVu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormChuyen";
            this.Text = "Chuyển Chức Vụ";
            this.Load += new System.EventHandler(this._FormChuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelChuyenChucVu;
        private System.Windows.Forms.CheckBox _chBoxQuanLy;
        private System.Windows.Forms.CheckBox _chBoxNhanVien;
        private System.Windows.Forms.Button _buttonChuyen;
    }
}