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
        String nameAcc;
        public _FormSendMess()
        {
            InitializeComponent();
        }

        public _FormSendMess(String nameAcc) : this()
        {
            this.nameAcc = nameAcc;
        }

        public String getID(String nameAcc)
        {

                class_CRUD get = new class_CRUD();
                String id = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";
                DataTable idtb = get.uploadData(id);

                return idtb.Rows[0][0].ToString();
            
            
        }


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

        private void _buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                class_CRUD handle = new class_CRUD();
                if (_chBoxSendAll.Checked == true)
                {
                    String sendAll = "INSERT INTO thongBao (id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + getID(nameAcc) + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Thông Báo', '-2')";
                    handle.handleData(sendAll);
                }
                else
                {
                    try
                    {
                        String SendId = "INSERT INTO thongBao(id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + _tBoxIDSendTo.Text + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Thông Báo', '-3')";
                        handle.handleData(SendId);
                    }
                    catch
                    {
                        _labelMessWErr.Text = "Vui lòng nhập đúng ID.";
                    }
                }
                this.Close();
            }
            catch
            {

            }

        }
    }
}
