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
        private String IDuser;                                                                                  // string to transmist ID    
        public _FormChangeAcc()
        {
            InitializeComponent();
        }

        /* 
         * Function constructor receive a string is id
         * Function tranmist string from this form to another form
         */
        public _FormChangeAcc(String IDuser):this()
        {
            this.IDuser = IDuser;                                                                       // tranmist ID
        }

        /* 
         * Function load handle upload data when open interface
         * This is a event
         * get name account
         * get status
         * get quyen
         */
        private void _FormChangeAcc_Load(object sender, EventArgs e)
        {
            _tBoxID.Text = IDuser;

            DataTable column = new DataTable();                                                         // creat datatable to store data
            class_CRUD data = new class_CRUD();                                                         // creat class to handle data
            String getnameAcc = "SELECT tenTaiKhoan FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";  // command SQL to get name
            String getState = "SELECT trangthai FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";      // command SQl to get status
            String getquyen = "SELECT quyensudung FROM _acc WHERE id_User = '" + _tBoxID.Text + "'";    // command SQL to get quyen

            
            try
            {
                column = data.uploadData(getnameAcc);                                                   // handle
                _tBoxNameAcc.Text = column.Rows[0][0].ToString();                                       // fill data
                column = data.uploadData(getState);                                                     // handle
                _tBoxState.Text = column.Rows[0][0].ToString();                                         // fill data
                column = data.uploadData(getquyen);                                                     // handle
                _cBoxChoseCv.Text = column.Rows[0][0].ToString();                                       // fill data

            }
            catch
            {
                // Exception , don't nothing
            }
 
        }
        /*  
         *  Function is a event
         *  when click at btton change fuction will handle data by update
         *  pass
         *  status
         *  quyensudung
         */
        private void _buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tBoxNewPass.Text == "" || _tBoxPassAgain.Text == "" || _tBoxState.Text == "" || _cBoxChoseCv.Text == "")           // check null data in text box
                {
                    _labelMess.Text = "Vui lòng điền đủ thông tin.";                                                                    // mess when text box null

                }
                else if (_tBoxNewPass.Text != _tBoxPassAgain.Text)
                {                                                                                                                       // check pass again
                    _labelMess.Text = "Mật khẩu nhập lại không khớp.";                                                                  // mess when pass again !=
                }                                                                     
                else if (_tBoxState.Text != "1" && _tBoxState.Text != "-1" && _tBoxState.Text != "0")
                {
                    _labelMess.Text = "Vui lòng điền đúng trạng thái.";                                                                 // Mess when status != int
                }
                else
                {
                    String updateAcc = "UPDATE _acc SET matkhau = N'" + _tBoxNewPass.Text + "', trangthai = '" + _tBoxState.Text + "', quyensudung = N'" + _cBoxChoseCv.Text + "' WHERE id_User = '" + _tBoxID.Text + "'";
                    class_CRUD update = new class_CRUD();                                                                               // creat class to handle
                    if (update.handleData(updateAcc))                                                                                   // handle data
                    {
                        _FormMessComplete f = new _FormMessComplete();                                                                  // mess when complete
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        _labelMess.Text = "Không thể cập nhật.";                                                                        // Mess when not handle
                    }

                }

            }
            catch
            {
                //Exception
            }
        }

        private void _tBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            this._tBoxNewPass.PasswordChar = '*';                                                                                       // convert char to * when textchange
        }

        private void _tBoxPassAgain_TextChanged(object sender, EventArgs e)
        {
            this._tBoxPassAgain.PasswordChar = '*';
        }
    }
}
