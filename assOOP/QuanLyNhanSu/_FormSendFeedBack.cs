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
        String nameAcc;
        public _FormSendFeedBack()
        {
            InitializeComponent();
        }

        public _FormSendFeedBack(String nameAcc) : this()
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

        private void _FormSendFeedBack_Load(object sender, EventArgs e)
        {
            _labelID.Text = getID(nameAcc);
        }

        private void _buttonSend_Click(object sender, EventArgs e)
        {
            if (_tBoxContent.Text == "" || _tBoxTieuDe.Text == "")
            {
                _labelMess.Text = "Vui lòng nhập đủ thông tin.";
            }
            else
            {
                try
                {
                    class_CRUD handle = new class_CRUD();
                    String SendId = "INSERT INTO thongBao(id_User, tieuDe, noiDung, kieuSend, state) VALUES('" + _labelID.Text + "', N'" + _tBoxTieuDe.Text + "', N'" + _tBoxContent.Text + "', N'Phản Hồi', '1')";
                    handle.handleData(SendId);
                    this.Close();
                }
                catch
                {
                    
                }
            }
        }
    }
}
