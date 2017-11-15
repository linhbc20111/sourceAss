using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class _FormChangePass : Form
    {
        String nameAcc;
        public _FormChangePass()
        {
            InitializeComponent();
        }

        public _FormChangePass(String nameAcc) : this()
        {
            this.nameAcc = nameAcc;
        }

        private void _tBoxOldPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxOldPass.PasswordChar = '*';             // Convert char input to '*"
        }

        private void _tBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPass.PasswordChar = '*';             // Convert char input to '*"
        }

        private void _tBoxNewPassAgain_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPassAgain.PasswordChar = '*';             // Convert char input to '*"
        }

        private void _buttonChangePass_Click(object sender, EventArgs e)
        {
            String checkPass = "SELECT * FROM _acc WHERE tenTaikhoan = N'"+_tBoxNameAcc.Text+"' AND trangthai = '1' AND matkhau = N'"+_tBoxOldPass.Text+"' ";
            String changePass = "UPDATE _acc SET matkhau = N'"+_tBoxNewPass.Text+"' WHERE tenTaikhoan = N'"+_tBoxNameAcc.Text+"'";
            class_CRUD pass = new class_CRUD();
 
            if (_tBoxNewPass.Text != _tBoxNewPassAgain.Text)
            {
                _labelMess.Text = "Mật khẩu không khớp.";
            }


            else if (_tBoxNewPass.Text == "" || _tBoxOldPass.Text == "" || _tBoxNewPassAgain.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin!";
            }

            else if (pass.checkData(checkPass))
            {
                 
                if (pass.handleData(changePass))
                {
                    _FormMessComplete f = new _FormMessComplete();
                    f.Show();
                    this.Close();
                }
                
            }
            else
            {
                _labelMess.Text = "Sai tài khoản hoặc mật khẩu.";
            }
        }

        private void _FormChangePass_Load(object sender, EventArgs e)
        {
            _tBoxNameAcc.Text = nameAcc;
        }
    }
}
