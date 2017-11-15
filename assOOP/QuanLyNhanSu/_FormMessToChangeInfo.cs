using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class _FormMessToChangeInfo : Form
    {
        private String nameAcc;
        public _FormMessToChangeInfo()
        {
            InitializeComponent();
        }
        public _FormMessToChangeInfo(String nameAccount) : this()
        {
            this.nameAcc = nameAccount;
        }
        private void _buttonOK_Click(object sender, EventArgs e)
        {
            class_CRUD check = new class_CRUD();
            String cmd = "SELECT * FROM _acc WHERE matkhau = N'" + _tBoxPass.Text + "' AND tenTaiKhoan = '"+nameAcc+"'";
            if (check.checkData(cmd) )
            {
                this.Close();
            }
            else
            {
                _labelMess.Text = "Nhập sai mật khẩu!";
            }
        }

        private void _tBoxPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPass.PasswordChar = '*';
        }
    }
}
