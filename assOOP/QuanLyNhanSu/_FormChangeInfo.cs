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
        private String nameAcc;                                                          // string to tranmist ID 
        public _FormChangeInfo()
        {
            InitializeComponent();
        }

        /* 
         * Function constructor receive a string name acc
         * Set name acc
         */
        public _FormChangeInfo(String mes)  : this()
        {
            this.nameAcc = mes;                                                         // Set name acc
        }

        /* 
         * Function get name acc
         * Return a string
         */
        public String getnameAcc()
        {
            return this.nameAcc;                                                        // get
        }
        private void _tBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void _tBoxID_CursorChanged(object sender, EventArgs e)
        {

        }
        private int i = 0;     
                                                                 
        // Function set value global i
        public void _seti(int i)
        {
            this.i = i;
        }


        /*
         * This is a event
         * Function use to update info
         * Get data in text box and update by command SQL
         */
        private void _buttonComplete_Click(object sender, EventArgs e)
        {
            if (_tBoxAddress.Text == "" || _dateBoxBDay.Text == "" || _tBoxCMND.Text == "" || _tBoxFirstName.Text == ""  || _tBoxLastName.Text == "" || _tBoxEmail.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin.";                            // Mess when data in text boxs null
            }
            else if (_chBoxRequirepass.Checked == false)
            {
                _labelMess.Text = "Vui lòng xác nhận thông tin là đúng sự thật.";           // Check this truth
            }
            else{
                class_CRUD changeInfo = new class_CRUD();                                   // creat class to handle
                String updateData = "UPDATE _user SET firstName = N'" + _tBoxFirstName.Text + "', lastName = N'" + _tBoxLastName.Text + "', birthDay = '" + _dateBoxBDay.Value.ToString("yyyy-MM-dd") + "', Address = N'" + _tBoxAddress.Text + "', CMND = '" + _tBoxCMND.Text + "', Email = N'" + _tBoxEmail.Text + "' WHERE id_User = N'" + _tBoxID.Text + "'";
                if (changeInfo.handleData(updateData))                                      // Handle data
                {
                    _FormMessComplete f = new _FormMessComplete();
                    f.Show();
                    this.Close();
                }
                else
                {
                    _labelMess.Text = "Xảy ra lỗi trong quá trình cập nhật.";                // Mess if can't handle data
                }
            }

        }


        /*
         * Requiement enter pass to continues
         * Function is called when check info is truth
         */
        private void _chBoxRequirepass_CheckedChanged(object sender, EventArgs e)
        {
            _FormMessToChangeInfo f = new _FormMessToChangeInfo(nameAcc);                   // Call form enter pass
            f.Show();
            
        }

        /*
         * Function to load when open form 
         * Up load data in text box
         */
        private void _FormChangeInfo_Load(object sender, EventArgs e)
        {
            nameAcc = getnameAcc();                                                                 // get name acc
            class_CRUD updata = new class_CRUD();                                                   // creat class to upload data
            String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = N'"+nameAcc+"'";          // Command SQL to upload ID
            


            // Upload ID and put in text box ID
            DataTable column = new DataTable();
            column = updata.uploadData(loadID);
            this._tBoxID.Text = column.Rows[0][0].ToString();
            // Command SQL to load data and put in text box
            String loadFirstName = "SELECT firstName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadLastName = "SELECT lastName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadCMND = "SELECT CMND FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadAddress = "SELECT Address FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            String loadEmail = "SELECT Email FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
            
            // Upload data
            column = updata.uploadData(loadFirstName);                                              // Upload first name
            this._tBoxFirstName.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadLastName);                                               // Upload last name
            this._tBoxLastName.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadbirthDay);                                               // Upload birthday
            this._dateBoxBDay.Text = column.Rows[0][0].ToString();                                  

            column = updata.uploadData(loadCMND);                                                   // Upload CMND
            this._tBoxCMND.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadEmail);                                                  // Upload Email
            this._tBoxEmail.Text = column.Rows[0][0].ToString();

            column = updata.uploadData(loadAddress);                                                // Upload address
            this._tBoxAddress.Text = column.Rows[0][0].ToString();


        }
    }
}
