namespace QuanLyNhanSu
{
    partial class _FormMessComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormMessComplete));
            this._labelComplete = new System.Windows.Forms.Label();
            this._buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelComplete
            // 
            this._labelComplete.AutoSize = true;
            this._labelComplete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._labelComplete.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelComplete.Location = new System.Drawing.Point(17, 42);
            this._labelComplete.Name = "_labelComplete";
            this._labelComplete.Size = new System.Drawing.Size(215, 28);
            this._labelComplete.TabIndex = 0;
            this._labelComplete.Text = "Cập nhật thành công!";
            // 
            // _buttonOk
            // 
            this._buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonOk.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonOk.Location = new System.Drawing.Point(84, 97);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(62, 30);
            this._buttonOk.TabIndex = 1;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = false;
            this._buttonOk.Click += new System.EventHandler(this._buttonOk_Click);
            // 
            // _FormMessComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 151);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._labelComplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormMessComplete";
            this.Text = "Hoàn Thành";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelComplete;
        private System.Windows.Forms.Button _buttonOk;
    }
}