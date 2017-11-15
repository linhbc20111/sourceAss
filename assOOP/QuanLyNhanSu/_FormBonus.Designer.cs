namespace QuanLyNhanSu
{
    partial class _FormBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormBonus));
            this._labelHeader = new System.Windows.Forms.Label();
            this._labelnumVnd = new System.Windows.Forms.Label();
            this._tBoxnumVnd = new System.Windows.Forms.TextBox();
            this._buttonOK = new System.Windows.Forms.Button();
            this._labelMess = new System.Windows.Forms.Label();
            this._labelVnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelHeader
            // 
            this._labelHeader.AutoSize = true;
            this._labelHeader.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelHeader.ForeColor = System.Drawing.Color.Blue;
            this._labelHeader.Location = new System.Drawing.Point(97, 20);
            this._labelHeader.Name = "_labelHeader";
            this._labelHeader.Size = new System.Drawing.Size(86, 28);
            this._labelHeader.TabIndex = 0;
            this._labelHeader.Text = "Thưởng";
            // 
            // _labelnumVnd
            // 
            this._labelnumVnd.AutoSize = true;
            this._labelnumVnd.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelnumVnd.Location = new System.Drawing.Point(45, 80);
            this._labelnumVnd.Name = "_labelnumVnd";
            this._labelnumVnd.Size = new System.Drawing.Size(59, 19);
            this._labelnumVnd.TabIndex = 1;
            this._labelnumVnd.Text = "Số tiền:";
            // 
            // _tBoxnumVnd
            // 
            this._tBoxnumVnd.Location = new System.Drawing.Point(110, 79);
            this._tBoxnumVnd.Name = "_tBoxnumVnd";
            this._tBoxnumVnd.Size = new System.Drawing.Size(124, 20);
            this._tBoxnumVnd.TabIndex = 2;
            // 
            // _buttonOK
            // 
            this._buttonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonOK.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonOK.Location = new System.Drawing.Point(102, 133);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(75, 29);
            this._buttonOK.TabIndex = 3;
            this._buttonOK.Text = "OK";
            this._buttonOK.UseVisualStyleBackColor = false;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // _labelMess
            // 
            this._labelMess.Location = new System.Drawing.Point(60, 106);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(169, 23);
            this._labelMess.TabIndex = 4;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _labelVnd
            // 
            this._labelVnd.AutoSize = true;
            this._labelVnd.Location = new System.Drawing.Point(240, 86);
            this._labelVnd.Name = "_labelVnd";
            this._labelVnd.Size = new System.Drawing.Size(30, 13);
            this._labelVnd.TabIndex = 5;
            this._labelVnd.Text = "VND";
            // 
            // _FormBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 199);
            this.Controls.Add(this._labelVnd);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._buttonOK);
            this.Controls.Add(this._tBoxnumVnd);
            this.Controls.Add(this._labelnumVnd);
            this.Controls.Add(this._labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormBonus";
            this.Text = "Thưởng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelHeader;
        private System.Windows.Forms.Label _labelnumVnd;
        private System.Windows.Forms.TextBox _tBoxnumVnd;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Label _labelMess;
        private System.Windows.Forms.Label _labelVnd;
    }
}