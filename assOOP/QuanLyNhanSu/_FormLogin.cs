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

        /*
         * This is a event
         * When click Function check null all text box and check data in data base
         */
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Command check data and chuc vu of data base
            String dangnhapQLNS = "SELECT * FROM _acc WHERE tenTaikhoan = N'"+_account.Text+"' AND matkhau = N'"+_passWord.Text+ "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Nhân Sự' AND trangthai = '1'";
            String dangnhapNV = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + _account.Text + "' AND matkhau = N'" + _passWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Nhân Viên' AND trangthai = '1'";
            String dangnhapQLTC = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + _account.Text + "' AND matkhau = N'" + _passWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Tài Chính' AND trangthai = '1'";
           
            // creat class to check data
            class_CRUD crud = new class_CRUD();

            // Check chuc vu and data tuy vao tung truong hop
            if (crud.exedata(dangnhapQLNS))                                             // check QLNS
            {
                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (crud.exedata(dangnhapQLTC))                                        // check QLTC
            {

                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (crud.exedata(dangnhapNV))                                          // check NV
            {
                _FormChuyen f = new _FormChuyen(_account.Text, _passWord.Text);
                this.Hide();
                f.Show();
            }
            else if (_passWord.Text == "")                                              // check null text box pass
            {
                _labelHideMess.Text = "Bạn chưa nhập mật khẩu.";
            }

            else
            {
                _labelHideMess.Text = "Sai thông tin tài khoản hoặc mật khẩu.";         // Mess when have not data in database
            }
        }


        /*
         * Function receive key click
         * Handle event
         */
        private void _account_KeyDown(object sender, KeyEventArgs e)
        {  
            if (e.KeyCode == Keys.CapsLock)
            {
                _labelHideMess.Text = "Kiểm tra Caplock";                   // key caplock
            }
            if (e.KeyCode == Keys.Enter && _passWord.Text == "")
            {               
                _labelHideMess.Text = "Bạn chưa nhập mật khẩu";             // check text box pass and account null when key enter click
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }


        // Call form forget pass when click this button
        private void _labelclickForgetPass_Click(object sender, EventArgs e)
        {
            _FormForgetPass f = new _FormForgetPass();
            f.Show();
        }


        // Call form SignUp when click this button
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
