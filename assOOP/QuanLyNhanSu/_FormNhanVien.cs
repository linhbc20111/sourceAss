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
    public partial class _FormNhanVien : Form
    {
        String nameAcc;
        int numrowMess;

        public _FormNhanVien()
        {
            InitializeComponent();
        }

        public _FormNhanVien(String nameAcc) : this()
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

        public String getpass(String nameAcc)
        {

            class_CRUD get = new class_CRUD();
            String pass = "SELECT matkhau FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";
            DataTable idtb = get.uploadData(pass);

            return idtb.Rows[0][0].ToString();


        }


        private void _FormNhanVien_Load(object sender, EventArgs e)
        {
            try {
                
                class_CRUD loadData = new class_CRUD();
                DataTable dataName;
                String loadname = "SELECT lastName FROM _user WHERE id_User = '" + getID(nameAcc) + "'";
                dataName = loadData.uploadData(loadname);
                this._labelHello.Text = "Xin chào " + dataName.Rows[0][0].ToString();



                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR thongBao.id_User = '" + getID(nameAcc) + "')";
                class_CRUD dataSend = new class_CRUD();
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);

                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";

                class_CRUD updata = new class_CRUD();
                String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = N'" + nameAcc + "'";


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






                String loadchietKhau = "SELECT chietKhau FROM _luongTong";
                String loadsoNgaynghi = "SELECT soNgaynghi FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadngayVao = "SELECT ngayVaocty FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadthuongPhat = "SELECT thuongCanhan, phatCanhan FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadngaybatdau = "SELECT ngayBatdauthang FROM _luongCanhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadheSo = "SELECT heSo FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadluong1Day = "SELECT [luong/ngay] FROM _luongTong";


                _tBoxLastName2.Text = _tBoxLastName.Text;
                _tBoxID2.Text = _tBoxID.Text;

                column = updata.uploadData(loadbirthDay);                        //
                this._dateBirthDay.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadngaybatdau);                        //
                this._dateStartMonth.Text = column.Rows[0][0].ToString();


                column = updata.uploadData(loadheSo);                        //
                this._tBoxheSo.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadluong1Day);                        //
                this._tBoxSalary1Day.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadchietKhau);
                this._tBoxchietKhau.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadsoNgaynghi);
                this._tBoxnumRelax.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadngayVao);
                int a = (DateTime.Now - Convert.ToDateTime(column.Rows[0][0])).Days;

                this._tBoxnumWork.Text = (a / 365).ToString();
                column = updata.uploadData(loadthuongPhat);
                _tBoxBonus.Text = column.Rows[0][0].ToString();
                _tBoxFine.Text = column.Rows[0][1].ToString();


                int songayLam = (DateTime.Now - Convert.ToDateTime(_dateStartMonth.Value)).Days;
                int songayLamThuc = songayLam - Convert.ToInt32(_tBoxnumRelax.Text);
                double heSo = Convert.ToDouble(_tBoxheSo.Text) - 0.2 * Convert.ToDouble(_tBoxnumWork.Text);

                _tBoxSalary.Text = ((1.0 - Convert.ToDouble(_tBoxchietKhau.Text)) * (Convert.ToDouble(_tBoxSalary1Day.Text) * songayLamThuc + Convert.ToDouble(column.Rows[0][0]) - Convert.ToDouble(column.Rows[0][1]))).ToString();
            }
            catch
            {

            }
        }

        private void _buttonChangePass_Click(object sender, EventArgs e)
        {
            _FormChangePass f = new _FormChangePass(nameAcc);
            f.Show();
        }

        private void _buttonChangeInfo_Click(object sender, EventArgs e)
        {
            _FormChangeInfo f = new _FormChangeInfo(nameAcc);
            f.Show();
        }

        private void _buttonSeeNew_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR (thongBao.id_User = '" + getID(nameAcc) + "' AND state = -3))";
                class_CRUD dataSend = new class_CRUD();
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);

                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";
            }
            catch
            {

            }
        }

        private void _buttonDelReq_Click(object sender, EventArgs e)
        {
            
            String SeeLate = "DELETE FROM thongBao WHERE id_User = '" + _dtgrtViewMess.Rows[numrowMess].Cells[0].Value.ToString() + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[numrowMess].Cells[3].Value.ToString() + "' AND state = -3";
            class_CRUD dataSend = new class_CRUD();
            dataSend.handleData(SeeLate);
            _buttonSeeNew_Click(sender, e);
        }

        private void _dtgrtViewMess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrowMess = e.RowIndex;
                _lbIDUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[0].Value.ToString();
                _lbNameSendUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[1].Value.ToString();
                String Content = "SELECT noiDung FROM thongBao WHERE id_User = '" + _lbIDUp.Text + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
                class_CRUD upContent = new class_CRUD();
                DataTable tableContent;
                tableContent = upContent.uploadData(Content);

                _tBContentSend.Text = tableContent.Rows[0][0].ToString();
            }
            catch
            {

            }

        }

        private void _buttonSendIdea_Click(object sender, EventArgs e)
        {
            _FormSendFeedBack f = new _FormSendFeedBack(nameAcc);
            f.Show();
        }

        private void _buttonDangXuat_Click(object sender, EventArgs e)
        {
            _FormLogin _frmFormLogin = new _FormLogin();
            _frmFormLogin.Show();
            this.Close();
        }

        private void _labelchuyenCV_Click(object sender, EventArgs e)
        {
            _FormChuyen f = new _FormChuyen(nameAcc, getpass(nameAcc));
            this.Close();
            f.Show();
        }
    }
}
