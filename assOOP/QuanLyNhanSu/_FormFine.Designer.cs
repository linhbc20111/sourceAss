namespace QuanLyNhanSu
{
    partial class _FormFine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormFine));
            this.label1 = new System.Windows.Forms.Label();
            this._labelnumVnd = new System.Windows.Forms.Label();
            this._labelVND = new System.Windows.Forms.Label();
            this._labelMess = new System.Windows.Forms.Label();
            this._tBoxnumVnd = new System.Windows.Forms.TextBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phạt";
            // 
            // _labelnumVnd
            // 
            this._labelnumVnd.AutoSize = true;
            this._labelnumVnd.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelnumVnd.Location = new System.Drawing.Point(37, 78);
            this._labelnumVnd.Name = "_labelnumVnd";
            this._labelnumVnd.Size = new System.Drawing.Size(59, 19);
            this._labelnumVnd.TabIndex = 1;
            this._labelnumVnd.Text = "Số tiền:";
            // 
            // _labelVND
            // 
            this._labelVND.AutoSize = true;
            this._labelVND.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelVND.Location = new System.Drawing.Point(219, 82);
            this._labelVND.Name = "_labelVND";
            this._labelVND.Size = new System.Drawing.Size(33, 16);
            this._labelVND.TabIndex = 2;
            this._labelVND.Text = "VND";
            // 
            // _labelMess
            // 
            this._labelMess.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._labelMess.Location = new System.Drawing.Point(61, 101);
            this._labelMess.Name = "_labelMess";
            this._labelMess.Size = new System.Drawing.Size(167, 23);
            this._labelMess.TabIndex = 3;
            this._labelMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._labelMess.Click += new System.EventHandler(this._labelMess_Click);
            // 
            // _tBoxnumVnd
            // 
            this._tBoxnumVnd.Location = new System.Drawing.Point(102, 78);
            this._tBoxnumVnd.Name = "_tBoxnumVnd";
            this._tBoxnumVnd.Size = new System.Drawing.Size(111, 20);
            this._tBoxnumVnd.TabIndex = 4;
            // 
            // _buttonOk
            // 
            this._buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._buttonOk.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._buttonOk.Location = new System.Drawing.Point(115, 127);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(62, 33);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = false;
            this._buttonOk.Click += new System.EventHandler(this._buttonOk_Click_1);
            // 
            // _FormFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._tBoxnumVnd);
            this.Controls.Add(this._labelMess);
            this.Controls.Add(this._labelVND);
            this.Controls.Add(this._labelnumVnd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_FormFine";
            this.Text = "Phạt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _labelnumVnd;
        private System.Windows.Forms.Label _labelVND;
        private System.Windows.Forms.Label _labelMess;
        private System.Windows.Forms.TextBox _tBoxnumVnd;
        private System.Windows.Forms.Button _buttonOk;
    }
}