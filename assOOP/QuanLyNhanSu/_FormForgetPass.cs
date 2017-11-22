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
    public partial class _FormForgetPass : Form
    {
        public _FormForgetPass()
        {
            InitializeComponent();
        }

        private void _tBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPass.PasswordChar = '*';             // Convert char input to '*"
        }

        private void _tBoxNewPassAgain_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPassAgain.PasswordChar = '*';             // Convert char input to '*"
        }


        /*
         * Function is a event
         * when click function will update data by update pass and set status = -1
         * Function use to Command UPDATE of SQL to update data
         */
        private void _buttonSendRequire_Click(object sender, EventArgs e)
        {
            String checkPass = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + _tBoxNameAcc.Text + "' AND trangthai = '1' ";              // command SQL check pass
            String changePass = "UPDATE _acc SET matkhau = N'" + _tBoxNewPass.Text + "', trangthai = '-3' WHERE tenTaikhoan = N'" + _tBoxNameAcc.Text + "'"; // command SQL to update data
            class_CRUD pass = new class_CRUD();                    // creat class to update data
            if (_tBoxNewPass.Text == "" || _tBoxNewPassAgain.Text == "")       
            {
                _labelMess.Text = "Bạn chưa nhập mật khẩu.";       // New pass = Null => out mess
            }
            else if (_tBoxNameAcc.Text == "")
            {
                _labelMess.Text = "Bạn chưa nhập tài khoản.";      // Name acc = Null => out mess
            }
            else if (pass.checkData(checkPass))                     // check pass
            {
                if (_tBoxNewPass.Text == _tBoxNewPassAgain.Text && _chBoxRequire.Checked == true && _tBoxNewPass.Text != "")
                {
                    if (pass.handleData(changePass))                // handle data by update
                    {
                         
                        this.Close();
                    }
                }
                else if (_chBoxRequire.Checked == false)            // check null check box
                {
                    _labelMess.Text = "Vui lòng xác nhận yêu cầu.";
                }
                else if (_tBoxNewPass.Text != _tBoxNewPassAgain.Text)       // check pass again = pass
                {
                    _labelMess.Text = "Bạn nhập sai mật khẩu.";
                }

            }

            else
            {
                _labelMess.Text = "Không tìm thấy tài khoản";     // else pass wrong
            }
        }
    }
}
