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
    public partial class _FormSendFeedBack : Form
    {
        private String nameAcc;                                                             // string to store name acc


        public _FormSendFeedBack()
        {
            InitializeComponent();
        }


        // Constructor receive a string name acc and set this name acc
        public _FormSendFeedBack(String nameAcc) : this()
        {
            this.nameAcc = nameAcc;                                                         // set name acc
        }

        // This function get ID by get from data base where have name acc = this name acc
        // This function return a string is name acc
        public String getID(String nameAcc)
        {

            class_CRUD get = new class_CRUD();                                              // class to upload data
            String id = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";   // Command SQL to upload data
            DataTable idtb = get.uploadData(id);                                            // data table store data after get from data base

            return idtb.Rows[0][0].ToString();


        }


        // Event load set text in label ID = ID
        private void _FormSendFeedBack_Load(object sender, EventArgs e)
        {
            _labelID.Text = getID(nameAcc);
        }

        // Event insert mess into database
        // All content in text box must not null
        private void _buttonSend_Click(object sender, EventArgs e)
        {
            if (_tBoxContent.Text == "" || _tBoxTieuDe.Text == "")
            {
                _labelMess.Text = "Vui lòng nhập đủ thông tin.";                        // check null in text box
            }
            else
            {
                try
                {
                    class_CRUD handle = new class_CRUD();                               // creat class to handle
                    String SendId = "INSERT INTO thongBao(id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + _labelID.Text + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Phản Hồi', '1')";
                    handle.handleData(SendId);                                          // handle data
                    this.Close();   
                }
                catch
                {
                    // Exceptiom
                }
            }
        }
    }
}
