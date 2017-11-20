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
    public partial class _FormQuanLyTaiChinh : Form
    {
        String nameAcc;                                     // it is static value , transmitted from login form'

        int numrowMess, a = 0, numrowSalary;                // number row cell messenger and salary in data gritview, handle data when cell click , value a to check read
        public _FormQuanLyTaiChinh()
        {
            InitializeComponent();
        }
        /*
         *Constructor have a argument is string Name acc to receive name acc from Login form
             
         */
        public _FormQuanLyTaiChinh(String nameAcc):this()
        {
            this.nameAcc = nameAcc;     // transmitted from login form and name acc riceive
        }


        /* 
         * Function getId use command SQL to get Id if have name acc 
         */

        public String getID(String nameAcc)
        {
            
            class_CRUD get = new class_CRUD();                                            // creat class to up data
            String id = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'"; // comand SQL
            DataTable idtb = get.uploadData(id);                                          // creat data table to store data 

            return idtb.Rows[0][0].ToString();                                            // return ID (string)

        }

        /* 
         * Function get pass as function get ID
         * 
         
         */
        public String getpass(String nameAcc)
        {

            class_CRUD get = new class_CRUD();                                              // creat class to up data
            String pass = "SELECT matkhau FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'"; // command SQL
            DataTable idtb = get.uploadData(pass);
                        
            return idtb.Rows[0][0].ToString();                                              // return pass (string)


        }
        /* 
         * Up data to data gritview, chart
         * Set value defaul for check box  
         */
        private void _FormQuanLyTaiChinh_Load(object sender, EventArgs e)
        {
            try
            {
                class_CRUD loadData = new class_CRUD();
                DataTable dataName;
                String loadname = "SELECT lastName FROM _user WHERE id_User = '" + getID(nameAcc) + "'";
                dataName = loadData.uploadData(loadname);
                this._labelHello.Text = "Xin chào " + dataName.Rows[0][0].ToString();

                _chBoxChoseOne.Checked = true;
                _chBoxChoseAll.Checked = false;
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR thongBao.id_User = '" + getID(nameAcc) + "')";
                class_CRUD dataSend = new class_CRUD();
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);
                // Set header for cell 
                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";


                String LoadSalary = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong WHERE _luongCaNhan.id_User = _user.id_User AND _user.id_User = _acc.id_User AND trangthai = '1'";
                _dtgrViewSalary.DataSource = dataSend.uploadData(LoadSalary);
                // set header for cell
                _dtgrViewSalary.Columns[0].HeaderText = "Mã Số";
                _dtgrViewSalary.Columns[1].HeaderText = "Tên";
                _dtgrViewSalary.Columns[2].HeaderText = "Chức Vụ";
                _dtgrViewSalary.Columns[3].HeaderText = "Hệ Số";
                _dtgrViewSalary.Columns[4].HeaderText = "Lương Ngày";
                _dtgrViewSalary.Columns[5].HeaderText = "Ngày Bắt Đầu";



                class_CRUD updata = new class_CRUD();
                String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = N'" + nameAcc + "'";


                DataTable column = new DataTable();
                column = updata.uploadData(loadID);
                this._tBoxID.Text = column.Rows[0][0].ToString();

                // SQL command to load data
                String loadFirstName = "SELECT firstName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadLastName = "SELECT lastName FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadCMND = "SELECT CMND FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadAddress = "SELECT Address FROM _user WHERE id_User = '" + _tBoxID.Text + "'";
                String loadEmail = "SELECT Email FROM _user WHERE id_User = '" + _tBoxID.Text + "'";


                // Load data to text box 
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




                //Load bieu do
                String datachart = "SELECT birthDay FROM _user, _acc WHERE _user.id_User = _acc.id_User AND trangthai = 1";

                class_CRUD updatachart = new class_CRUD();
                DataTable datatb;
                int _20down = 0, _20x = 0, _30x = 0, _40x = 0, _50up = 0;
                datatb = updatachart.uploadData(datachart);


                foreach (var series in _chartStatistic.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in _chartStatisticCot.Series)
                {
                    series.Points.Clear();
                }
                for (int i = 0; i < datatb.Rows.Count; i++)
                {

                    int a = (DateTime.Now - Convert.ToDateTime(datatb.Rows[i][0])).Days;

                    if (a / 365 < 20)
                    {
                        _20down++;
                    }
                    else if (a / 365 < 30)
                    {
                        _20x++;
                    }
                    else if (a / 365 < 40)
                    {
                        _30x++;
                    }
                    else if (a / 365 < 50)
                    {
                        _40x++;
                    }
                    else
                    {
                        _50up++;
                    }
                }


                //Bieu do cot
                _chartStatisticCot.Series["Age"].Points.Add(_20down);
                _chartStatisticCot.Series["Age"].Points[0].AxisLabel = "Under 20";
                _chartStatisticCot.Series["Age"].Points[0].LegendText = "Under 20";
                _chartStatisticCot.Series["Age"].Points[0].Label = _20down.ToString();


                _chartStatisticCot.Series["Age"].Points.Add(_20x);
                _chartStatisticCot.Series["Age"].Points[1].AxisLabel = "20 to 30";
                _chartStatisticCot.Series["Age"].Points[1].LegendText = "20 to 30";
                _chartStatisticCot.Series["Age"].Points[1].Label = _20x.ToString();


                _chartStatisticCot.Series["Age"].Points.Add(_30x);
                _chartStatisticCot.Series["Age"].Points[2].AxisLabel = "30 to 40";
                _chartStatisticCot.Series["Age"].Points[2].LegendText = "30 to 40";
                _chartStatisticCot.Series["Age"].Points[2].Label = _30x.ToString();


                _chartStatisticCot.Series["Age"].Points.Add(_40x);
                _chartStatisticCot.Series["Age"].Points[3].AxisLabel = "40 to 50";
                _chartStatisticCot.Series["Age"].Points[3].LegendText = "40 to 50";
                _chartStatisticCot.Series["Age"].Points[3].Label = _40x.ToString();


                _chartStatisticCot.Series["Age"].Points.Add(_50up);
                _chartStatisticCot.Series["Age"].Points[4].AxisLabel = "Over 50";
                _chartStatisticCot.Series["Age"].Points[4].LegendText = "Over 50";
                _chartStatisticCot.Series["Age"].Points[4].Label = _50up.ToString();

                // Bieu do tron
                _chartStatistic.Series["Age"].Points.AddXY("Under 20", _20down);
                _chartStatistic.Series["Age"].Points.AddXY("20 to 30", _20x);
                _chartStatistic.Series["Age"].Points.AddXY("30 to 40", _30x);
                _chartStatistic.Series["Age"].Points.AddXY("40 to 50", _40x);
                _chartStatistic.Series["Age"].Points.AddXY("Over 50", _50up);
            }
            catch
            {

            }
        }
        private void _buttonDangXuat_Click(object sender, EventArgs e)
        {

            _FormLogin _frmFormLogin = new _FormLogin();
            _frmFormLogin.Show();
            this.Close();
        }

        private void _buttonSeeLateReq_Click(object sender, EventArgs e)
        {

        }

        private void _buttonChangeInfo_Click(object sender, EventArgs e)
        {
            _FormChangeInfo f = new _FormChangeInfo(nameAcc);
            f.Show();
        }

        private void _buttonChangePass_Click(object sender, EventArgs e)
        {
            _FormChangePass f = new _FormChangePass(nameAcc);
            f.Show();
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

        private void _buttonSeeNew_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND (state = -2 OR thongBao.id_User = '" + getID(nameAcc) + "')";
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

        private void _buttonSeenMess_Click(object sender, EventArgs e)
        {
            _FormSendMess f = new _FormSendMess(nameAcc);
            f.Show();
        }

        private void _buttonSendIdea_Click(object sender, EventArgs e)
        {
            _FormSendFeedBack f = new _FormSendFeedBack(nameAcc);
            f.Show();
        }

        private void _dtgrViewSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrowSalary = e.RowIndex;
                _tBoxID2.Text = _dtgrViewSalary.Rows[numrowSalary].Cells[0].Value.ToString();
                _tBoxLastName2.Text = _dtgrViewSalary.Rows[numrowSalary].Cells[1].Value.ToString();
                DataTable column = new DataTable();
                class_CRUD updata = new class_CRUD();


                String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadchietKhau = "SELECT chietKhau FROM _luongTong";
                String loadsoNgaynghi = "SELECT soNgaynghi FROM _luongCaNhan WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadngayVao = "SELECT ngayVaocty FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadthuongPhat = "SELECT thuongCanhan, phatCanhan FROM _luongCaNhan WHERE id_User = '" + _tBoxID2.Text + "'";

                column = updata.uploadData(loadbirthDay);                        //
                this._dateBirthDay.Text = column.Rows[0][0].ToString();

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


                int songayLam = (DateTime.Now - Convert.ToDateTime(_dtgrViewSalary.Rows[numrowSalary].Cells[5].Value)).Days;
                int songayLamThuc = songayLam - Convert.ToInt32(_tBoxnumRelax.Text);
                double heSo = Convert.ToDouble(_dtgrViewSalary.Rows[numrowSalary].Cells[3].Value) - 0.2 * Convert.ToDouble(_tBoxnumWork.Text);

                _tBoxSalary.Text = ((1.0 - Convert.ToDouble(_tBoxchietKhau.Text)) * (Convert.ToDouble(_dtgrViewSalary.Rows[numrowSalary].Cells[4].Value) * songayLamThuc + Convert.ToDouble(column.Rows[0][0]) - Convert.ToDouble(column.Rows[0][1]))).ToString();
            }
            catch
            {

            }

        }

        private void _buttonListAll_Click(object sender, EventArgs e)
        {
            try
            {
                class_CRUD dataSend = new class_CRUD();
                String LoadSalary = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong WHERE _luongCaNhan.id_User = _user.id_User AND _user.id_User = _acc.id_User AND trangthai = '1'";
                _dtgrViewSalary.DataSource = dataSend.uploadData(LoadSalary);

                _dtgrViewSalary.Columns[0].HeaderText = "Mã Số";
                _dtgrViewSalary.Columns[1].HeaderText = "Tên";
                _dtgrViewSalary.Columns[2].HeaderText = "Chức Vụ";
                _dtgrViewSalary.Columns[3].HeaderText = "Hệ Số";
                _dtgrViewSalary.Columns[4].HeaderText = "Lương Ngày";
                _dtgrViewSalary.Columns[5].HeaderText = "Ngày Bắt Đầu";
            }
            catch
            {

            }
        }

        private void _buttonPayed_Click(object sender, EventArgs e)
        {
            
        }

        private void _buttonPaySalary_Click(object sender, EventArgs e)
        {
            try
            {
                class_CRUD handle = new class_CRUD();
                String Pay;
                if (_chBoxChoseOne.Checked == true)
                {
                    Pay = "UPDATE _luongCaNhan SET thuongCanhan = '0', phatCanhan = '0', ngayBatdauthang = '" + DateTime.Now.ToString("yyyy/MM/dd") + "', soNgaynghi = '0' WHERE id_User = '" + _dtgrViewSalary.Rows[numrowSalary].Cells[0].Value.ToString() + "'";
                    handle.handleData(Pay);

                }
                else
                {
                    Pay = "UPDATE _luongCaNhan SET thuongCanhan = '0', phatCanhan = '0', ngayBatdauthang = '" + DateTime.Now.ToString("yyyy/MM/dd") + "', soNgaynghi = '0'";
                    handle.handleData(Pay);
                }
                _buttonListAll_Click(sender, e);
            }
            catch
            {

            }
        }

        private void _chBoxChoseAll_CheckedChanged(object sender, EventArgs e)
        {
            if (_chBoxChoseAll.Checked == true)
            {
                _chBoxChoseOne.Checked = false;
            }
            else
            {
                _chBoxChoseOne.Checked = true;
            }
        }

        private void _chBoxChoseOne_CheckedChanged(object sender, EventArgs e)
        {
            if (_chBoxChoseOne.Checked == true)
            {
                _chBoxChoseAll.Checked = false;
            }
            else
            {
                _chBoxChoseAll.Checked = true;
            }
        }

        private void _buttonBonus_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;
                if (_chBoxChoseOne.Checked == true)
                {
                    ID = _dtgrViewSalary.Rows[numrowSalary].Cells[0].Value.ToString();
                }
                else
                {
                    ID = "all";
                }
                _FormBonus f = new _FormBonus(ID);
                f.Show();
            }
            catch
            {

            }
        }

        private void _buttonFine_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;
                if (_chBoxChoseOne.Checked == true)
                {
                    ID = _dtgrViewSalary.Rows[numrowSalary].Cells[0].Value.ToString();
                }
                else
                {
                    ID = "all";
                }
                _FormFine f = new _FormFine(ID);
                f.Show();
            }
            catch
            {

            }
        }

        private void _buttonEditAll_Click(object sender, EventArgs e)
        {
            _FormEditSalaryAll f = new _FormEditSalaryAll();
            f.Show();
        }

        private void _buttonFindContent_Click(object sender, EventArgs e)
        {
            String loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong WHERE _luongCaNhan.id_User = _user.id_User AND _user.id_User = _acc.id_User AND trangthai = '1'";
            if (_cBoxChoseType.Text == "" || _tBoxContent.Text == "")
            {
                _labelMessContent.Text = "Vui lòng điền đủ thông tin";
            }
            else
            {
                if (_cBoxChoseType.Text == "ID")
                {
                    loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong WHERE _luongCanhan.id_User = _user.id_User AND trangthai = 1 AND _user.id_User = _acc.id_User AND _user.id_User LIKE '%" + _tBoxContent.Text + "%'";
                }
                else if (_cBoxChoseType.Text == "Tên")
                {
                    loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong WHERE _luongCanhan.id_User = _user.id_User AND trangthai = 1 AND _user.id_User = _acc.id_User AND lastName LIKE N'%" + _tBoxContent.Text + "%'";
                }
                else if (_cBoxChoseType.Text == "Chức Vụ")
                {
                    loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong  WHERE _luongCanhan.id_User = _user.id_User AND trangthai = 1 AND _user.id_User = _acc.id_User AND quyensudung LIKE N'%" + _tBoxContent.Text + "%'";
                }
                else if (_cBoxChoseType.Text == "Hệ Số")
                {
                    loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong  WHERE _luongCanhan.id_User = _user.id_User AND trangthai = 1 AND _user.id_User = _acc.id_User AND heSo LIKE N'%" + _tBoxContent.Text + "%'";
                }
                else if (_cBoxChoseType.Text == "CMND")
                {
                    loadInfo = "SELECT _luongCaNhan.id_User, lastName, quyensudung, heSo, [luong/ngay], ngayBatdauthang FROM _acc, _luongCaNhan, _user, _luongTong  WHERE _luongCanhan.id_User = _user.id_User AND trangthai = 1 AND _user.id_User = _acc.id_User AND CMND LIKE '%" + _tBoxContent.Text + "%'";
                }
                try
                {
                    class_CRUD loadData = new class_CRUD();
                    _dtgrViewSalary.DataSource = loadData.uploadData(loadInfo);
                }
                catch
                {
                    _labelMessContent.Text = "Không tìm thấy!";
                }
            }
        }

        private void _labelchuyenCV_Click(object sender, EventArgs e)
        {
            _FormChuyen f = new _FormChuyen(nameAcc, getpass(nameAcc));
            this.Close();
            f.Show();
            
        }

        private void _buttonStatistic_Click(object sender, EventArgs e)
        {
            try
            {
                String data = "SELECT birthDay FROM _user, _acc WHERE _user.id_User = _acc.id_User AND trangthai = 1";
                String data2 = "SELECT ngayVaocty FROM _user, _acc WHERE _user.id_User = _acc.id_User AND trangthai = 1";
                class_CRUD updata = new class_CRUD();
                DataTable datatb, datatbquat;
                int _20down = 0, _20x = 0, _30x = 0, _40x = 0, _50up = 0;
                int _1down = 0, _1t2 = 0, _2t3 = 0, _3t5 = 0, _5up = 0;
                datatb = updata.uploadData(data);
                datatbquat = updata.uploadData(data2);


                if (_cBoxChoseStatistic.Text == "")
                {
                    _labelMessStatistic.Text = "Vui lòng chọn thông tin xem.";
                }
                else if (_cBoxChoseStatistic.Text == "Độ Tuổi")
                {
                    foreach (var series in _chartStatistic.Series)
                    {
                        series.Points.Clear();
                    }
                    foreach (var series in _chartStatisticCot.Series)
                    {
                        series.Points.Clear();
                    }
                    for (int i = 0; i < datatb.Rows.Count; i++)
                    {

                        int a = (DateTime.Now - Convert.ToDateTime(datatb.Rows[i][0])).Days;

                        if (a / 365 < 20)
                        {
                            _20down++;
                        }
                        else if (a / 365 < 30)
                        {
                            _20x++;
                        }
                        else if (a / 365 < 40)
                        {
                            _30x++;
                        }
                        else if (a / 365 < 50)
                        {
                            _40x++;
                        }
                        else
                        {
                            _50up++;
                        }
                    }


                    //Bieu do cot
                    _chartStatisticCot.Series["Age"].Points.Add(_20down);
                    _chartStatisticCot.Series["Age"].Points[0].AxisLabel = "Under 20";
                    _chartStatisticCot.Series["Age"].Points[0].LegendText = "Under 20";
                    _chartStatisticCot.Series["Age"].Points[0].Label = _20down.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_20x);
                    _chartStatisticCot.Series["Age"].Points[1].AxisLabel = "20 to 30";
                    _chartStatisticCot.Series["Age"].Points[1].LegendText = "20 to 30";
                    _chartStatisticCot.Series["Age"].Points[1].Label = _20x.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_30x);
                    _chartStatisticCot.Series["Age"].Points[2].AxisLabel = "30 to 40";
                    _chartStatisticCot.Series["Age"].Points[2].LegendText = "30 to 40";
                    _chartStatisticCot.Series["Age"].Points[2].Label = _30x.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_40x);
                    _chartStatisticCot.Series["Age"].Points[3].AxisLabel = "40 to 50";
                    _chartStatisticCot.Series["Age"].Points[3].LegendText = "40 to 50";
                    _chartStatisticCot.Series["Age"].Points[3].Label = _40x.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_50up);
                    _chartStatisticCot.Series["Age"].Points[4].AxisLabel = "Over 50";
                    _chartStatisticCot.Series["Age"].Points[4].LegendText = "Over 50";
                    _chartStatisticCot.Series["Age"].Points[4].Label = _50up.ToString();

                    // Bieu do tron
                    _chartStatistic.Series["Age"].Points.AddXY("Under 20", _20down);
                    _chartStatistic.Series["Age"].Points.AddXY("20 to 30", _20x);
                    _chartStatistic.Series["Age"].Points.AddXY("30 to 40", _30x);
                    _chartStatistic.Series["Age"].Points.AddXY("40 to 50", _40x);
                    _chartStatistic.Series["Age"].Points.AddXY("Over 50", _50up);

                }
                else if (_cBoxChoseStatistic.Text == "Hệ Số")
                {
                    foreach (var series in _chartStatistic.Series)
                    {
                        series.Points.Clear();
                    }
                    foreach (var series in _chartStatisticCot.Series)
                    {
                        series.Points.Clear();
                    }
                    for (int i = 0; i < datatb.Rows.Count; i++)
                    {

                        int a = (DateTime.Now - Convert.ToDateTime(datatb.Rows[i][0])).Days;

                        if (a / 365 < 3)
                        {
                            _1down++;
                        }
                        else if (a / 365 < 5)
                        {
                            _1t2++;
                        }
                        else if (a / 365 < 8)
                        {
                            _2t3++;
                        }
                        else if (a / 365 < 10)
                        {
                            _3t5++;
                        }
                        else
                        {
                            _5up++;
                        }
                    }


                    //Bieu do cot
                    _chartStatisticCot.Series["Age"].Points.Add(_1down);
                    _chartStatisticCot.Series["Age"].Points[0].AxisLabel = "1 - 1.6";
                    _chartStatisticCot.Series["Age"].Points[0].LegendText = "1 - 1.6";
                    _chartStatisticCot.Series["Age"].Points[0].Label = _1down.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_1t2);
                    _chartStatisticCot.Series["Age"].Points[1].AxisLabel = "1.6 to 2";
                    _chartStatisticCot.Series["Age"].Points[1].LegendText = "1.6 to 2";
                    _chartStatisticCot.Series["Age"].Points[1].Label = _1t2.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_2t3);
                    _chartStatisticCot.Series["Age"].Points[2].AxisLabel = "2 to 2.6";
                    _chartStatisticCot.Series["Age"].Points[2].LegendText = "2 to 2.6";
                    _chartStatisticCot.Series["Age"].Points[2].Label = _2t3.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_3t5);
                    _chartStatisticCot.Series["Age"].Points[3].AxisLabel = "2.6 - 3";
                    _chartStatisticCot.Series["Age"].Points[3].LegendText = "2.6 - 3";
                    _chartStatisticCot.Series["Age"].Points[3].Label = _3t5.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_5up);
                    _chartStatisticCot.Series["Age"].Points[4].AxisLabel = "Over 3";
                    _chartStatisticCot.Series["Age"].Points[4].LegendText = "Over 3";
                    _chartStatisticCot.Series["Age"].Points[4].Label = _5up.ToString();

                    // Bieu do tron
                    _chartStatistic.Series["Age"].Points.AddXY("1 - 1.6", _1down);
                    _chartStatistic.Series["Age"].Points.AddXY("1.6 to 2", _1t2);
                    _chartStatistic.Series["Age"].Points.AddXY("2 to 2.6", _2t3);
                    _chartStatistic.Series["Age"].Points.AddXY("2.6 to 3", _3t5);
                    _chartStatistic.Series["Age"].Points.AddXY("Over 3", _5up);
                }

                else if (_cBoxChoseStatistic.Text == "Lương") {


                    foreach (var series in _chartStatistic.Series)
                    {
                        series.Points.Clear();
                    }
                    foreach (var series in _chartStatisticCot.Series)
                    {
                        series.Points.Clear();
                    }
                    for (int i = 0; i < datatb.Rows.Count; i++)
                    {
                        numrowSalary = i;
                        _tBoxID2.Text = _dtgrViewSalary.Rows[numrowSalary].Cells[0].Value.ToString();
                        _tBoxLastName2.Text = _dtgrViewSalary.Rows[numrowSalary].Cells[1].Value.ToString();
                        DataTable column = new DataTable();
                        class_CRUD updataSalary = new class_CRUD();


                        String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                        String loadchietKhau = "SELECT chietKhau FROM _luongTong";
                        String loadsoNgaynghi = "SELECT soNgaynghi FROM _luongCaNhan WHERE id_User = '" + _tBoxID2.Text + "'";
                        String loadngayVao = "SELECT ngayVaocty FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                        String loadthuongPhat = "SELECT thuongCanhan, phatCanhan FROM _luongCaNhan WHERE id_User = '" + _tBoxID2.Text + "'";

                        column = updataSalary.uploadData(loadbirthDay);                        //
                        this._dateBirthDay.Text = column.Rows[0][0].ToString();

                        column = updataSalary.uploadData(loadchietKhau);
                        this._tBoxchietKhau.Text = column.Rows[0][0].ToString();

                        column = updataSalary.uploadData(loadsoNgaynghi);
                        this._tBoxnumRelax.Text = column.Rows[0][0].ToString();

                        column = updataSalary.uploadData(loadngayVao);
                        int a = (DateTime.Now - Convert.ToDateTime(column.Rows[0][0])).Days;

                        this._tBoxnumWork.Text = (a / 365).ToString();
                        column = updataSalary.uploadData(loadthuongPhat);
                        _tBoxBonus.Text = column.Rows[0][0].ToString();
                        _tBoxFine.Text = column.Rows[0][1].ToString();


                        int songayLam = (DateTime.Now - Convert.ToDateTime(_dtgrViewSalary.Rows[numrowSalary].Cells[5].Value)).Days;
                        int songayLamThuc = songayLam - Convert.ToInt32(_tBoxnumRelax.Text);
                        double heSo = Convert.ToDouble(_dtgrViewSalary.Rows[numrowSalary].Cells[3].Value) - 0.2 * Convert.ToDouble(_tBoxnumWork.Text);

                        double b = (1.0 - Convert.ToDouble(_tBoxchietKhau.Text)) * (Convert.ToDouble(_dtgrViewSalary.Rows[numrowSalary].Cells[4].Value) * songayLamThuc + Convert.ToDouble(column.Rows[0][0]) - Convert.ToDouble(column.Rows[0][1]));
                        if (b < 2000000)
                        {
                            _1down++;
                        }
                        else if (b < 5000000)
                        {
                            _1t2++;
                        }
                        else if (b < 10000000)
                        {
                            _2t3++;
                        }
                        else if (b < 15000000)
                        {
                            _3t5++;
                        }
                        else
                        {
                            _5up++;
                        }

                    }
                    //Bieu do cot
                    _chartStatisticCot.Series["Age"].Points.Add(_1down);
                    _chartStatisticCot.Series["Age"].Points[0].AxisLabel = "0tr - 2tr";
                    _chartStatisticCot.Series["Age"].Points[0].LegendText = "0tr - 2tr";
                    _chartStatisticCot.Series["Age"].Points[0].Label = _1down.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_1t2);
                    _chartStatisticCot.Series["Age"].Points[1].AxisLabel = "2tr - 5tr";
                    _chartStatisticCot.Series["Age"].Points[1].LegendText = "2tr - 5tr";
                    _chartStatisticCot.Series["Age"].Points[1].Label = _1t2.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_2t3);
                    _chartStatisticCot.Series["Age"].Points[2].AxisLabel = "5tr - 10tr";
                    _chartStatisticCot.Series["Age"].Points[2].LegendText = "5tr - 10tr";
                    _chartStatisticCot.Series["Age"].Points[2].Label = _2t3.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_3t5);
                    _chartStatisticCot.Series["Age"].Points[3].AxisLabel = "10tr - 15tr";
                    _chartStatisticCot.Series["Age"].Points[3].LegendText = "10tr - 15tr";
                    _chartStatisticCot.Series["Age"].Points[3].Label = _3t5.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_5up);
                    _chartStatisticCot.Series["Age"].Points[4].AxisLabel = "Over 15tr";
                    _chartStatisticCot.Series["Age"].Points[4].LegendText = "Over 15tr";
                    _chartStatisticCot.Series["Age"].Points[4].Label = _5up.ToString();

                    // Bieu do tron
                    _chartStatistic.Series["Age"].Points.AddXY("0tr - 2tr", _1down);
                    _chartStatistic.Series["Age"].Points.AddXY("2tr - 5tr", _1t2);
                    _chartStatistic.Series["Age"].Points.AddXY("5tr - 10tr", _2t3);
                    _chartStatistic.Series["Age"].Points.AddXY("10tr - 15tr", _3t5);
                    _chartStatistic.Series["Age"].Points.AddXY("Over 15tr", _5up);
                }

            }
            catch
            {
                _labelMessStatistic.Text = "Không có dữ liệu.";
            }
        }

        private void _labelMess2_Click(object sender, EventArgs e)
        {
            //Dont'care
        }

        private void _buttonDelReq_Click(object sender, EventArgs e)
        {
            try
            {

                if (a == 0)
                {
                    _FormMessToChangeInfo f = new _FormMessToChangeInfo(nameAcc);
                    a = 1;
                    f.Show();
                }
                else
                {
                    String SeeLate = "DELETE FROM thongBao WHERE id_User = '" + _dtgrtViewMess.Rows[numrowMess].Cells[0].Value.ToString() + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[numrowMess].Cells[3].Value.ToString() + "' AND state != -2";
                    class_CRUD dataSend = new class_CRUD();
                    dataSend.handleData(SeeLate);
                    _buttonSeeNew_Click(sender, e);


                    a = 0;
                }
            }
            catch
            {

            }
        }
    }
}
