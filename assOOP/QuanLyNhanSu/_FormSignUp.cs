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
    public partial class _FormSignUp : Form
    {
        public _FormSignUp()
        {
            InitializeComponent();
        }

        private void _cBoxChoseChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._cBoxChoseChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        static int i = 0;
        private void _labelDieukhoan_Click(object sender, EventArgs e)
        {
            _FormDieuKhoan f = new _FormDieuKhoan();
            f.Show();
            i = 1;
        }


        private void _chBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (_chBoxFemale.Checked == true)
            {
                _chBoxMale.Checked = false;
            }
        }

        private void _chBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if(_chBoxMale.Checked == true)
            {
                _chBoxFemale.Checked = false;
            }
        }

        private void _tBoxPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPass.PasswordChar = '*';             // Convert char input to '*"
        }

        private void _tBoxPassAgain_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPassAgain.PasswordChar = '*';             // Convert char input to '*"
        }


        private void _buttonOk_Click(object sender, EventArgs e)
        {
            try { 
            String check = "SELECT * FROM _acc WHERE tenTaiKhoan = N'"+_tBoxNewNameAcc.Text+"'";
            String checkCMND = "SELECT * FROM _user WHERE CMND = N'" + _tBoxCMND.Text + "'";

            class_CRUD checkacc = new class_CRUD();

                if (checkacc.checkData(check) == true || checkacc.checkData(checkCMND) == true)
                {
                    _labelMessDK.Text = "Tài khoản đã tồn tại.";
                }
                else if (_tBoxPass.Text != _tBoxPassAgain.Text)
                {
                    _labelMessDK.Text = "Bạn nhập sai mật khẩu.";
                }
                else if (_tBoxAddress.Text == "" || _dateBoxBDay.Text == "" || _tBoxCMND.Text == "" || _tBoxFirstName.Text == "" || (_chBoxFemale.Checked == false && _chBoxMale.Checked == false) || _tBoxLastName.Text == "" || _tBoxEmail.Text == "")
                {
                    _labelMessDK.Text = "Vui lòng điền đủ thông tin cá nhân.";
                }
                else if (_tBoxNewNameAcc.Text == "" || _tBoxPass.Text == "" || _tBoxPassAgain.Text == "")
                {
                    _labelMessDK.Text = "Vui lòng điền đủ thông tin tài khoản.";
                }
                else if (_checkDieukhoan.Checked == false)
                {
                    _labelMessDK.Text = "Bạn chưa đồng ý với điều khoản công ty.";
                }
                else if (i == 0)
                {
                    _labelMessDK.Text = "Vui lòng đọc kỹ điều khoản.";
                }
                else if (_dateBoxComein.Value > DateTime.Now)
                {
                    _labelMessDK.Text = "Vui lòng nhập đúng ngày vào.";
                }
                else
                {
                    String heSo = "1";

                    if (_cBoxChoseChucvu.Text == "")
                    {
                        _cBoxChoseChucvu.Text = "Nhân Viên";
                    }
                    if (_cBoxChoseChucvu.Text == "Nhân Viên")
                    {
                        heSo = "1";
                    }
                    else if (_cBoxChoseChucvu.Text == "Quản Lý Nhân Sự" || _cBoxChoseChucvu.Text == "Quản Lý Tài Chính")
                    {
                        heSo = "1.2";
                    }


                    String Sex = "Nữ";
                    if (_chBoxFemale.Checked == true)
                    {
                        Sex = "Nam";
                    }

                    String insert = "INSERT INTO _acc (id_User, tenTaikhoan, matkhau, trangthai, quyensudung) VALUES('" + _tBoxCMND.Text + "', N'" + _tBoxNewNameAcc.Text + "', N'" + _tBoxPass.Text + "', -1, N'" + _cBoxChoseChucvu.Text + "')";
                    String insert1 = "INSERT INTO _user (id_User, firstName, lastName, birthDay, CMND, Email, Address, Sex, ngayVaocty ) VALUES('" + _tBoxCMND.Text + " ', N'" + _tBoxFirstName.Text + "', N'" + _tBoxLastName.Text + "', '" + _dateBoxBDay.Value.ToString("yyyy-MM-dd") + "', '" + _tBoxCMND.Text + "' , N'" + _tBoxEmail.Text + "', N'" + _tBoxAddress.Text + "', '" + Sex + "', '" + _dateBoxComein.Value.ToString("yyyy-MM-dd") + "')";
                    String insert3 = "INSERT INTO _luongCanhan (id_User, heSo, thuongCanhan, phatCanhan, ngayBatdauthang, soNgaynghi) VALUES('" + _tBoxCMND.Text + "', '" + heSo +"', '0', '0', '"+ _dateBoxComein.Value.ToString("yyyy-MM-dd") + "', '0')";
                    class_CRUD insert2 = new class_CRUD();
                    if (insert2.handleData(insert1) == false || insert2.handleData(insert3) == false)
                    {
                        _labelMessDK.Text = "Bạn vui lòng kiểm tra dạng nhập ngày.";

                    }
                    else
                    {
                        insert2.handleData(insert);
                        
                        this.Close();
                        i = 0;
                    }
                }
            }
            catch
            {

            }
        }

        private void _FormSignUp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
