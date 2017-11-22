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
    public partial class _FormSendMess : Form
    {
        private String nameAcc;                                                                     // string use to store name acc

        public _FormSendMess()
        {
            InitializeComponent();
        }


        // Constructor receive a string is name acc and set this name acc
        public _FormSendMess(String nameAcc) : this()
        {
            this.nameAcc = nameAcc;                                                                 // set name acc
        }

        // This function receive a string is nameacc and return ID
        public String getID(String nameAcc)
        {

                class_CRUD get = new class_CRUD();                                                  // class to upload data
                String id = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";       // command SQL to upload
                DataTable idtb = get.uploadData(id);                                                // upload

                return idtb.Rows[0][0].ToString();                                                  // return data
            
            
        }

        // This function to set value for check box
        private void _chBoxSendAll_CheckedChanged(object sender, EventArgs e)
        {
            if(_chBoxSendAll.Checked == true)
            {
                _tBoxIDSendTo.ReadOnly = true;
            }
            else
            {
                _tBoxIDSendTo.ReadOnly = false;
            }
        }

        /*
         * Event will Insert data get from all text box and date time box to insert database
         * Check null and mess
         * Insert Mess
         */
        private void _buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                class_CRUD handle = new class_CRUD();                                       // class to insert data
                if (_chBoxSendAll.Checked == true)                                          // check send all
                {

                    String sendAll = "INSERT INTO thongBao (id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + getID(nameAcc) + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Thông Báo', '-2')";
                    handle.handleData(sendAll);                                             // Insert data into database
                    this.Close();   
                }
                else
                {
                    try
                    {
                        String CheckData = "SELECT id_User FROM _acc WHERE id_User = '" + _tBoxIDSendTo.Text + "'";     // Command to check data

                        if (handle.checkData(CheckData) == true)                             // check data
                        {
                            String SendId = "INSERT INTO thongBao(id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + _tBoxIDSendTo.Text + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Thông Báo', '-3')";
                            handle.handleData(SendId);                                      // Insert data
                            this.Close();
                        }
                        else if(_tBoxContent.Text == "" || _tBoxTieuDe.Text == "")
                        {
                            _labelMessWErr.Text = "Vui lòng nhập đủ thông tin.";            // Mess if text box null
                        }
 
                        else
                        {
                            _labelMessWErr.Text = "Vui lòng nhập đúng ID.";                 // mess if text box ID not like as default
                        }
                    }
                    catch
                    {
                         // Exceptiom
                    }
                }
                
            }
            catch
            {
                // Exception
            }

        }
    }
}
