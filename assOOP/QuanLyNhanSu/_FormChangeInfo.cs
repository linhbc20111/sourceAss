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
    public partial class _FormChangeInfo : Form
    {
        private String nameAcc;
        public _FormChangeInfo()
        {
            InitializeComponent();
        }
        public _FormChangeInfo(String mes)  : this()
        {
            this.nameAcc = mes;
        }

        public String getnameAcc()
        {
            return this.nameAcc;
        }
        private void _tBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _tBoxID_CursorChanged(object sender, EventArgs e)
        {

        }
        private int i = 0;
        public void _seti(int i)
        {
            this.i = i;
        }
        private void _buttonComplete_Click(object sender, EventArgs e)
        {
            if (_tBoxAddress.Text == "" || _dateBoxBDay.Text == "" || _tBoxCMND.Text == "" || _tBoxFirstName.Text == ""  || _tBoxLastName.Text == "" || _tBoxEmail.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin.";
            }
            else if (_chBoxRequirepass.Checked == false)
            {
                _labelMess.Text = "Vui lòng xác nhận thông tin là đúng sự thật.";  
            }
            else{
                class_CRUD changeInfo = new class_CRUD();
                String updateData = "UPDATE _user SET firstName = N'" + _tBoxFirstName.Text + "', lastName = N'" + _tBoxLastName.Text + "', birthDay = '" + _dateBoxBDay.Value.ToString("yyyy-MM-dd") + "', Address = N'" + _tBoxAddress.Text + "', CMND = '" + _tBoxCMND.Text + "', Email = N'" + _tBoxEmail.Text + "' WHERE id_User = N'" + _tBoxID.Text + "'";
                if (changeInfo.handleData(updateData))
                {
                    _FormMessComplete f = new _FormMessComplete();
                    f.Show();
                    this.Close();
                }
                else
                {
                    _labelMess.Text = "Xảy ra lỗi trong quá trình cập nhật.";
                }
            }

        }

        private void _chBoxRequirepass_CheckedChanged(object sender, EventArgs e)
        {
            _FormMessToChangeInfo f = new _FormMessToChangeInfo(nameAcc);
            f.Show();
            
        }

        private void _FormChangeInfo_Load(object sender, EventArgs e)
        {
            nameAcc = getnameAcc();
            class_CRUD updata = new class_CRUD();
            String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = N'"+nameAcc+"'";
            



            DataTable column = new DataTable();
            column = updata.uploadData(loadID);
            this._tBoxID.Text = column.Rows[0][0].ToString();

            String loadFirstName = "SELECT firstName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadLastName = "SELECT lastName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadCMND = "SELECT CMND FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadAddress = "SELECT Address FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadEmail = "SELECT Email FROM _user WHERE id_User = '" + _tBoxID.Text + "'";

            column = updata.uploadData(loadFirstName);
            this._tBoxFirstName.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadLastName);
            this._tBoxLastName.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadbirthDay);
            this._dateBoxBDay.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadCMND);
            this._tBoxCMND.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadEmail);
            this._tBoxEmail.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadAddress);
            this._tBoxAddress.Text = column.Rows[0][0].ToString();


        }
    }
}
