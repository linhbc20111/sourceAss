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
        private String nameAcc;                                                 // string to store name acc


        public _FormMessToChangeInfo()
        {
            InitializeComponent();
        }

        // This constructor receive a string name acc and set name acc
        public _FormMessToChangeInfo(String nameAccount) : this()
        {
            this.nameAcc = nameAccount;                                         // set name acc
        }

        /*
         * This is a event 
         * When click this button fuction check pass to continues
         */
        private void _buttonOK_Click(object sender, EventArgs e)
        {
            class_CRUD check = new class_CRUD();
            String cmd = "SELECT * FROM _acc WHERE matkhau = N'" + _tBoxPass.Text + "' AND tenTaiKhoan = '"+nameAcc+"'";    // Command to check data
            if (check.checkData(cmd) )                                          // check data
            {
                this.Close();
            }
            else
            {
                _labelMess.Text = "Nhập sai mật khẩu!";                         // Wrong pass
            }
        }


        //
        private void _tBoxPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPass.PasswordChar = '*';                                  // Convert char to '*" when text change
        }
    }
}
