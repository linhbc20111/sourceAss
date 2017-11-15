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
    public partial class _FormChangeAcc : Form
    {
        String IDuser;
        public _FormChangeAcc()
        {
            InitializeComponent();
        }
        public _FormChangeAcc(String IDuser):this()
        {
            this.IDuser = IDuser;
        }
        private void _FormChangeAcc_Load(object sender, EventArgs e)
        {
            _tBoxID.Text = IDuser;

            DataTable column = new DataTable();
            class_CRUD data = new class_CRUD();
            String getnameAcc = "SELECT tenTaiKhoan FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";
            String getState = "SELECT trangthai FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";
            String getquyen = "SELECT quyensudung FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";

            
            try
            {
                column = data.uploadData(getnameAcc);
                _tBoxNameAcc.Text = column.Rows[0][0].ToString();
                column = data.uploadData(getState);
                _tBoxState.Text = column.Rows[0][0].ToString();
                column = data.uploadData(getquyen);
                _cBoxChoseCv.Text = column.Rows[0][0].ToString();

            }
            catch
            {

            }


        }

        private void _buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tBoxNewPass.Text == "" || _tBoxPassAgain.Text == "" || _tBoxState.Text == "" || _cBoxChoseCv.Text == "")
                {
                    _labelMess.Text = "Vui lòng điền đủ thông tin.";

                }
                else if (_tBoxNewPass.Text != _tBoxPassAgain.Text){
                    _labelMess.Text = "Mật khẩu nhập lại không khớp.";
                }
                else if (_tBoxState.Text != "1" && _tBoxState.Text != "-1" && _tBoxState.Text != "0")
                {
                    _labelMess.Text = "Vui lòng điền đúng trạng thái.";
                }
                else
                {
                    String updateAcc = "UPDATE _acc SET matkhau = N'" + _tBoxNewPass.Text + "', trangthai = '" + _tBoxState.Text + "', quyensudung = N'" + _cBoxChoseCv.Text + "' WHERE id_User = '"+_tBoxID.Text+"'";
                    class_CRUD update = new class_CRUD();
                    if (update.handleData(updateAcc))
                    {
                        _FormMessComplete f = new _FormMessComplete();
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        _labelMess.Text = "Không thể cập nhật.";
                    }

                }

            }
            catch
            {

            }
        }

        private void _tBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPass.PasswordChar = '*'; 
        }

        private void _tBoxPassAgain_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPassAgain.PasswordChar = '*';
        }
    }
}
