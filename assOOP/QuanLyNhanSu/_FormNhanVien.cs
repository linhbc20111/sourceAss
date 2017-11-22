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
        private String nameAcc;                         // string to store name acc
        private int numrowMess;                         // int to store row click

        public _FormNhanVien()
        {
            InitializeComponent();
        }


        // Constructor receive a sting is name acc and set name acc
        public _FormNhanVien(String nameAcc) : this()
        {
            this.nameAcc = nameAcc;
        }

        // Fuction get id from name acc 
        // Get data by command select SQL
        public String getID(String nameAcc)
        {

            class_CRUD get = new class_CRUD();          // creat class to upload data
            String id = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";  // command SQL to upload data
            DataTable idtb = get.uploadData(id);        // data table to store data data

            return idtb.Rows[0][0].ToString();
        }


        /*
         * Function receive a string is name acc
         * retuurn a string pass
         */
        public String getpass(String nameAcc)
        {

            class_CRUD get = new class_CRUD();          // creat class to updata
            String pass = "SELECT matkhau FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'"; // command SQL to upload data
            DataTable idtb = get.uploadData(pass);      // upload data

            return idtb.Rows[0][0].ToString();
        }



        /* 
         * Event load data into text box and caculator salary 
         * By SQL SELECT command
         */
        private void _FormNhanVien_Load(object sender, EventArgs e)
        {
            try {
                
                class_CRUD loadData = new class_CRUD();                                                         // creat class to upload data
                DataTable dataName;                                                                             // dataa table to store data
                String loadname = "SELECT lastName FROM _user WHERE id_User = '" + getID(nameAcc) + "'";        // command SQL
                dataName = loadData.uploadData(loadname);                                                       // upload data
                this._labelHello.Text = "Xin chào " + dataName.Rows[0][0].ToString();                           // Fill data


                // Load Mess int datagritview mess
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR thongBao.id_User = '" + getID(nameAcc) + "')";
                class_CRUD dataSend = new class_CRUD();
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);                                       // uploaddata

                // Set name header 
                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";

                class_CRUD updata = new class_CRUD();                                                             // class to upload data
                String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = N'" + nameAcc + "'";                // Command SQL to upload


                DataTable column = new DataTable();                                                               // data table to store data
                column = updata.uploadData(loadID);                                                               // upload
                this._tBoxID.Text = column.Rows[0][0].ToString();

                // Command to upload data and put in text box
                String loadFirstName = "SELECT firstName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";        // First name
                String loadLastName = "SELECT lastName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";          // Last name
                String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID.Text + "'";          // Birthday
                String loadCMND = "SELECT CMND FROM _user WHERE id_User = '" + _tBoxID.Text + "'";                  // CMND
                String loadAddress = "SELECT Address FROM _user WHERE id_User = '" + _tBoxID.Text + "'";            // Address
                String loadEmail = "SELECT Email FROM _user WHERE id_User = '" + _tBoxID.Text + "'";                // Email

                column = updata.uploadData(loadFirstName);
                this._tBoxFirstName.Text = column.Rows[0][0].ToString();                                            // First name

                column = updata.uploadData(loadLastName);
                this._tBoxLastName.Text = column.Rows[0][0].ToString();                                             // Last name

                column = updata.uploadData(loadbirthDay);
                this._dateBoxBDay.Text = column.Rows[0][0].ToString();                                              // Birthday

                column = updata.uploadData(loadCMND);
                this._tBoxCMND.Text = column.Rows[0][0].ToString();                                                 // CMND

                column = updata.uploadData(loadEmail);
                this._tBoxEmail.Text = column.Rows[0][0].ToString();                                                // Email

                column = updata.uploadData(loadAddress);
                this._tBoxAddress.Text = column.Rows[0][0].ToString();                                              // Address




                // Load salary

                // Command to upload data
                String loadchietKhau = "SELECT chietKhau FROM _luongTong";
                String loadsoNgaynghi = "SELECT soNgaynghi FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadngayVao = "SELECT ngayVaocty FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadthuongPhat = "SELECT thuongCanhan, phatCanhan FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadngaybatdau = "SELECT ngayBatdauthang FROM _luongCanhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadheSo = "SELECT heSo FROM _luongCaNhan WHERE id_User = '" + _tBoxID.Text + "'";
                String loadluong1Day = "SELECT [luong/ngay] FROM _luongTong";


                _tBoxLastName2.Text = _tBoxLastName.Text;
                _tBoxID2.Text = _tBoxID.Text;

                column = updata.uploadData(loadbirthDay);                        // Birthday
                this._dateBirthDay.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadngaybatdau);                      // Date start
                this._dateStartMonth.Text = column.Rows[0][0].ToString();


                column = updata.uploadData(loadheSo);                            // He so
                this._tBoxheSo.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadluong1Day);                       // Slary / 1 day
                this._tBoxSalary1Day.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadchietKhau);
                this._tBoxchietKhau.Text = column.Rows[0][0].ToString();         // Chiet khau

                column = updata.uploadData(loadsoNgaynghi);
                this._tBoxnumRelax.Text = column.Rows[0][0].ToString();         // number relax

                column = updata.uploadData(loadngayVao);
                int a = (DateTime.Now - Convert.ToDateTime(column.Rows[0][0])).Days;        // date come in company

                // Solve year exp
                this._tBoxnumWork.Text = (a / 365).ToString();
                
                // load money bonus and fine
                column = updata.uploadData(loadthuongPhat);
                _tBoxBonus.Text = column.Rows[0][0].ToString();
                _tBoxFine.Text = column.Rows[0][1].ToString();


                int songayLam = (DateTime.Now - Convert.ToDateTime(_dateStartMonth.Value)).Days;
                int songayLamThuc = songayLam - Convert.ToInt32(_tBoxnumRelax.Text);
                double heSo = Convert.ToDouble(_tBoxheSo.Text) - 0.2 * Convert.ToDouble(_tBoxnumWork.Text);
                
                // Solve salary real
                _tBoxSalary.Text = ((1.0 - Convert.ToDouble(_tBoxchietKhau.Text)) * (Convert.ToDouble(_tBoxSalary1Day.Text) * songayLamThuc + Convert.ToDouble(column.Rows[0][0]) - Convert.ToDouble(column.Rows[0][1]))).ToString();
            }
            catch
            {

            }
        }


        // Event click change pass
        private void _buttonChangePass_Click(object sender, EventArgs e)
        {
            _FormChangePass f = new _FormChangePass(nameAcc);
            f.Show();
        }


        // Event when click change info
        private void _buttonChangeInfo_Click(object sender, EventArgs e)
        {
            _FormChangeInfo f = new _FormChangeInfo(nameAcc);
            f.Show();
        }


        // Event when click see new
        private void _buttonSeeNew_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR (thongBao.id_User = '" + getID(nameAcc) + "' AND state = -3))";
                class_CRUD dataSend = new class_CRUD();                                 // class to upload data
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);              // fill data

                // Set name header for datagritview
                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";
            }
            catch
            {
                // Exception
            }
        }


        // Event when click delete requei Mess
        private void _buttonDelReq_Click(object sender, EventArgs e)
        {
            try
            {
                String SeeLate = "DELETE FROM thongBao WHERE id_User = '" + _dtgrtViewMess.Rows[numrowMess].Cells[0].Value.ToString() + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[numrowMess].Cells[3].Value.ToString() + "' AND state = -3";
                class_CRUD dataSend = new class_CRUD();             // class to handle data
                dataSend.handleData(SeeLate);                       // handle data
                _buttonSeeNew_Click(sender, e);                     // load
            }
            catch
            {
                // Exception
            }
        }



        // Event when click in datagritview
        private void _dtgrtViewMess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrowMess = e.RowIndex;                                                        // numrow click
                _lbIDUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[0].Value.ToString();       // set text for text box id
                _lbNameSendUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[1].Value.ToString();
                String Content = "SELECT noiDung FROM thongBao WHERE id_User = '" + _lbIDUp.Text + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
                class_CRUD upContent = new class_CRUD();                                        // class to upload data
                DataTable tableContent;                                                         // datatable to store data
                tableContent = upContent.uploadData(Content);                                   // upload data

                _tBContentSend.Text = tableContent.Rows[0][0].ToString();                       // Fill data into text box
            }
            catch
            {
                // Exception
            }

        }

        // Event when click send idea
        private void _buttonSendIdea_Click(object sender, EventArgs e)
        {
            _FormSendFeedBack f = new _FormSendFeedBack(nameAcc);
            f.Show();
        }

        // Event when click button dang xuat

        private void _buttonDangXuat_Click(object sender, EventArgs e)
        {
            _FormLogin _frmFormLogin = new _FormLogin();
            _frmFormLogin.Show();
            this.Close();
        }

        // Event when click button chuyen CV
        private void _labelchuyenCV_Click(object sender, EventArgs e)
        {
            _FormChuyen f = new _FormChuyen(nameAcc, getpass(nameAcc));
            this.Close();
            f.Show();
        }
    }
}
