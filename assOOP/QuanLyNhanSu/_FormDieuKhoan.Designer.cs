namespace QuanLyNhanSu
{
    partial class _FormDieuKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormDieuKhoan));
            this._labelDieuKhoan = new System.Windows.Forms.Label();
            this._buttonDahieu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _labelDieuKhoan
            // 
            this._labelDieuKhoan.AutoSize = true;
            this._labelDieuKhoan.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelDieuKhoan.Location = new System.Drawing.Point(269, 22);
            this._labelDieuKhoan.Name = "_labelDieuKhoan";
            this._labelDieuKhoan.Size = new System.Drawing.Size(143, 30);
            this._labelDieuKhoan.TabIndex = 0;
            this._labelDieuKhoan.Text = "ĐIỀU KHOẢN";
            // 
            // _buttonDahieu
            // 
            this._buttonDahieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonDahieu.Location = new System.Drawing.Point(291, 378);
            this._buttonDahieu.Name = "_buttonDahieu";
            this._buttonDahieu.Size = new System.Drawing.Size(86, 30);
            this._buttonDahieu.TabIndex = 1;
            this._buttonDahieu.Text = "Đã hiểu";
            this._buttonDahieu.UseVisualStyleBackColor = false;
            this._buttonDahieu.Click += new System.EventHandler(this._buttonDahieu_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(26, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(631, 317);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // _FormDieuKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._buttonDahieu);
            this.Controls.Add(this._labelDieuKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormDieuKhoan";
            this.Text = "Điều khoản công ty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelDieuKhoan;
        private System.Windows.Forms.Button _buttonDahieu;
        private System.Windows.Forms.TextBox textBox1;
    }
}