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
    public partial class _FormLogin : Form
    {
        public _FormLogin()
        {
            InitializeComponent();
        }

        private void _iconPass_Click(object sender, EventArgs e)
        {

        }

        private void _account_TextChanged(object sender, EventArgs e)
        {

        }

        private void _passWord_TextChanged(object sender, EventArgs e)
        {
            this._passWord.PasswordChar = '*';             // Convert char input to '*"
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String dangnhapQLNS = "SELECT * FROM _acc WHERE tenTaikhoan = N'"+_account.Text+"' AND matkhau = N'"+_passWord.Text+ "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Nhân Sự' AND trangthai = '1'";
            String dangnhapNV = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + _account.Text + "' AND matkhau = N'" + _passWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Nhân Viên' AND trangthai = '1'";
            String dangnhapQLTC = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + _account.Text + "' AND matkhau = N'" + _passWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Tài Chính' AND trangthai = '1'";
            class_CRUD crud = new class_CRUD();

             
             
            if (crud.exedata(dangnhapQLNS))
            {
                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (crud.exedata(dangnhapQLTC))
            {

                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (crud.exedata(dangnhapNV))
            {
                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (_passWord.Text == "")
            {
                _labelHideMess.Text = "Bạn chưa nhập mật khẩu.";
            }

            else
            {
                _labelHideMess.Text = "Sai thông tin tài khoản hoặc mật khẩu.";
            }
        }

        private void _account_KeyDown(object sender, KeyEventArgs e)
        {  
            if (e.KeyCode == Keys.CapsLock)
            {
                _labelHideMess.Text = "Kiểm tra Caplock";
            }
            if (e.KeyCode == Keys.Enter && _passWord.Text == "")
            {               
                _labelHideMess.Text = "Bạn chưa nhập mật khẩu";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void _labelclickForgetPass_Click(object sender, EventArgs e)
        {
            _FormForgetPass f = new _FormForgetPass();
            f.Show();
        }

        private void _labelClickSignUp_Click(object sender, EventArgs e)
        {
            _FormSignUp f = new _FormSignUp();
            f.Show();
        }

        private void _passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender,e);
            }
        }
    }
}
