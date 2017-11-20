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
    public partial class Main : Form
    {
        private int numrow, numrowWait, numrowMess;
        private int i = 0, j = 0, a = 0;
        private String nameAcc;
        public Main()
        {
            InitializeComponent();
        }

        public Main(String mes) : this()
        {
            this.nameAcc = mes;
        }

        public String getnameAcc()
        {
            return this.nameAcc;
        }

        public String getpass(String nameAcc)
        {

            class_CRUD get = new class_CRUD();
            String pass = "SELECT matkhau FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";
            DataTable idtb = get.uploadData(pass);

            return idtb.Rows[0][0].ToString();


        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND state > -2";
                class_CRUD dataSend = new class_CRUD();
                _dtgrtViewMess.DataSource = dataSend.uploadData(LoadSend);

                _dtgrtViewMess.Columns[0].HeaderText = "Mã Số";
                _dtgrtViewMess.Columns[1].HeaderText = "Tên";
                _dtgrtViewMess.Columns[2].HeaderText = "Kiểu";
                _dtgrtViewMess.Columns[3].HeaderText = "Tiêu Đề";



                j = 0; // To know now show list 

                _chBoxChoseAll.Checked = false;
                _chBoxChoseOne.Checked = true;


                nameAcc = getnameAcc();
                String loadacc = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND trangthai = '1'";
                String loadaccWait = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai < 1 AND _user.id_User = _acc.id_User";
                class_CRUD loadData = new class_CRUD();
                _dtgrViewAcc.DataSource = loadData.uploadData(loadacc);
                _dtgrViewWait.DataSource = loadData.uploadData(loadaccWait);

                _dtgrViewAcc.Columns[0].HeaderText = "Mã Số";
                _dtgrViewAcc.Columns[1].HeaderText = "Tài Khoản";
                _dtgrViewAcc.Columns[2].HeaderText = "Họ Đệm";
                _dtgrViewAcc.Columns[3].HeaderText = "Tên";
                _dtgrViewAcc.Columns[4].HeaderText = "Mật Khẩu";
                _dtgrViewAcc.Columns[5].HeaderText = "Trạng Thái";

                _dtgrViewWait.Columns[0].HeaderText = "Mã Số";
                _dtgrViewWait.Columns[1].HeaderText = "Tài Khoản";
                _dtgrViewWait.Columns[2].HeaderText = "Họ Đệm";
                _dtgrViewWait.Columns[3].HeaderText = "Tên";
                _dtgrViewWait.Columns[4].HeaderText = "Mật Khẩu";
                _dtgrViewWait.Columns[5].HeaderText = "Trạng Thái";

                String loadID = "SELECT id_User FROM _acc WHERE tenTaiKhoan = '" + nameAcc + "'";
                DataTable data = new DataTable();
                data = loadData.uploadData(loadID);
                String ID = data.Rows[0][0].ToString();
                String loadname = "SELECT lastName FROM _user WHERE id_User = '" + ID + "'";
                data = loadData.uploadData(loadname);
                this._labelHello.Text = "Xin chào " + data.Rows[0][0].ToString();



                // Load bieu do
                String datachart = "SELECT birthDay FROM _user, _acc WHERE _user.id_User = _acc.id_User AND trangthai = 1";
                
                class_CRUD updata = new class_CRUD();
                DataTable datatb;
                int _20down = 0, _20x = 0, _30x = 0, _40x = 0, _50up = 0;
                datatb = updata.uploadData(datachart);
                

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

       

        private void _buttonDangXuat_Click(object sender, EventArgs e)
        {
            _FormLogin _frmFormLogin = new _FormLogin();
            _frmFormLogin.Show();
            this.Close();
        }

        private void _buttonAddAcc_Click(object sender, EventArgs e)
        {
            _FormSignUp f = new _FormSignUp();
            f.Show();
        }

        private void _quanlyHeThong_Click(object sender, EventArgs e)
        {

        }

        private void _buttonComplete_Click(object sender, EventArgs e)
        {
            if (_tBoxAddress.Text == "" || _dateBoxBDay.Text == "" || _tBoxCMND.Text == "" || _tBoxFirstName.Text == "" || _tBoxLastName.Text == "" || _tBoxEmail.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin.";
            }

            else
            {
                class_CRUD changeInfo = new class_CRUD();
                String updateData = "UPDATE _user SET firstName = N'" + _tBoxFirstName.Text + "', lastName = N'" + _tBoxLastName.Text + "', birthDay = '" + _dateBoxBDay.Value.ToString("yyyy/MM/dd") + "', Address = N'" + _tBoxAddress.Text + "', CMND = '" + _tBoxCMND.Text + "', Email = N'" + _tBoxEmail.Text + "' WHERE id_User = N'" + _tBoxID.Text + "'";
                if (changeInfo.handleData(updateData))
                {
                    _labelMess.Text = "Cập nhật thành công";
                    Main_Load(sender, e);
                }
                else
                {
                    _labelMess.Text = "Xảy ra lỗi trong lúc cập nhật.";
                }
            }
        }

        private void _dtgrViewAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable column = new DataTable();
            class_CRUD updata = new class_CRUD();
            numrow = e.RowIndex;
            try
            {
                _tBoxID.Text = _dtgrViewAcc.Rows[numrow].Cells[0].Value.ToString();
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
            catch
            {

            }

        }

       
        private void _buttonFind_Click(object sender, EventArgs e)
        {
            String loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND trangthai = 1";
            if (_cBoxChoseFind.Text == "" || _tBoxInfo.Text == "")
            {
                _labelMessFind.Text = "Vui lòng điền đủ thông tin";
            }
            else
            {
                if (_cBoxChoseFind.Text == "ID")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = 1 AND _user.id_User = _acc.id_User AND _user.id_User LIKE '%" + _tBoxInfo.Text + "%'";       
                }
                else if (_cBoxChoseFind.Text == "Tên")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = 1 AND _user.id_User = _acc.id_User AND lastName LIKE N'%" + _tBoxInfo.Text + "%'";
                }
                else if (_cBoxChoseFind.Text == "Họ Đệm")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = 1 AND _user.id_User = _acc.id_User AND firstName LIKE N'%" + _tBoxInfo.Text + "%'";
                }
                else if (_cBoxChoseFind.Text == "Địa Chỉ")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = 1 AND _user.id_User = _acc.id_User AND Address LIKE N'%" + _tBoxInfo.Text + "%'";
                }
                else if (_cBoxChoseFind.Text == "CMND")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = 1 AND _user.id_User = _acc.id_User AND CMND LIKE '%" + _tBoxInfo.Text + "%'";
                }
                else if (_cBoxChoseFind.Text == "Email")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai =  1 AND _user.id_User = _acc.id_User AND Email LIKE N'%" + _tBoxInfo.Text + "%'";
                }
                else if (_cBoxChoseFind.Text == "Tên Tài Khoản")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai =  1 AND _user.id_User = _acc.id_User AND tenTaiKhoan LIKE N'%" + _tBoxInfo.Text + "%'";
                }
                
                try
                {
                    class_CRUD loadData = new class_CRUD();
                    _dtgrViewAcc.DataSource = loadData.uploadData(loadInfo);
                }
                catch
                {
                    _labelMessContent.Text = "Không tìm thấy!";
                }
            }
        }

        private void _tBoxInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _buttonFind_Click(sender, e);
            }
        }
        private void _buttonDelAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    _FormMessToChangeInfo f = new _FormMessToChangeInfo(nameAcc);
                    i = 1;
                    f.Show();
                }
                else
                {
                    String delAcc = "DELETE FROM _acc WHERE id_User = '" + _dtgrViewAcc.Rows[numrow].Cells[0].Value.ToString() + "'";
                    String delAcc1 = "DELETE FROM _user WHERE id_User = '" + _dtgrViewAcc.Rows[numrow].Cells[0].Value.ToString() + "'";
                    String delAcc2 = "DELETE FROM _luongCanhan WHERE id_User = '" + _dtgrViewAcc.Rows[numrow].Cells[0].Value.ToString() + "'";
                    class_CRUD delAccount = new class_CRUD();

                    delAccount.handleData(delAcc);
                    delAccount.handleData(delAcc1);
                    delAccount.handleData(delAcc2);
                    Main_Load(sender, e);

                    i = 0;
                }
            }
            catch
            {

            }

        }

        private void _buttonEditAcc_Click(object sender, EventArgs e)
        {
            try
            {
                _FormChangeAcc f = new _FormChangeAcc(_dtgrViewAcc.Rows[numrow].Cells[0].Value.ToString());
                f.Show();
            }
            catch
            {

            }     
        }

        private void _buttonLoad_Click(object sender, EventArgs e)
        {
            this.Main_Load(sender, e);
        }

        private void _buttonFindContent_Click(object sender, EventArgs e)
        {
            String loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND trangthai < 1";
            if (_cBoxChoseType.Text == "" || _tBoxContent.Text == "")
            {
                _labelMessContent.Text = "Vui lòng điền đủ thông tin";
            }
            else
            {
                if (_cBoxChoseType.Text == "ID")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND _user.id_User LIKE '%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "Tên")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND lastName LIKE N'%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "Họ Đệm")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND firstName LIKE N'%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "Địa Chỉ")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND Address LIKE N'%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "CMND")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND CMND LIKE '%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "Email")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND Email LIKE N'%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                else if (_cBoxChoseType.Text == "Tên Tài Khoản")
                {
                    loadInfo = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE _user.id_User = _acc.id_User AND tenTaiKhoan LIKE N'%" + _tBoxContent.Text + "%' AND trangthai < 1";
                }
                try
                {
                    class_CRUD loadData = new class_CRUD();
                    _dtgrViewWait.DataSource = loadData.uploadData(loadInfo);
                }
                catch
                {
                    _labelMessContent.Text = "Không tìm thấy!";
                }
            }
        }

        private void _buttonLoadList_Click(object sender, EventArgs e)
        {
            Main_Load(sender, e);
        }

        private void _buttonListAll_Click(object sender, EventArgs e)
        {
            try
            {
                j = 0;

                String loadaccWait = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai < 1 AND _user.id_User = _acc.id_User";
                class_CRUD loadagain = new class_CRUD();
                _dtgrViewWait.DataSource = loadagain.uploadData(loadaccWait);
            }
            catch
            {

            }
        }

        private void _buttonListNew_Click(object sender, EventArgs e)
        {
            try
            {
                j = 1;

                String loadaccWait = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = '-1' AND _user.id_User = _acc.id_User";
                class_CRUD loadagain = new class_CRUD();
                _dtgrViewWait.DataSource = loadagain.uploadData(loadaccWait);
            }
            catch
            {

            }
        }


        private void _buttonAgree_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_chBoxChoseOne.Checked == true)
                {
                    String id = _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString();
                    String agree = "UPDATE _acc SET trangthai = '1' WHERE id_User = '" + id + "'";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                else if (j == 1)
                {
                    String agree = "UPDATE _acc SET trangthai = '1' WHERE trangthai = '-1'";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                else if (j == 2)
                {
                    String agree = "UPDATE _acc SET trangthai = '1' WHERE trangthai = '0'";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                else
                {
                    String agree = "UPDATE _acc SET trangthai = '1' WHERE trangthai < 1";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                Main_Load(sender, e);
            }
            catch
            {

            }
        }

        private void _buttonListWaitlate_Click(object sender, EventArgs e)
        {

            try
            {
                j = 2;

                String loadaccWait = "SELECT _acc.id_User, tenTaiKhoan, firstName, lastName, matkhau, trangthai FROM _acc, _user WHERE trangthai = '0' AND _user.id_User = _acc.id_User";
                class_CRUD loadagain = new class_CRUD();
                _dtgrViewWait.DataSource = loadagain.uploadData(loadaccWait);
            }
            catch
            {

            }
        }

        private void _buttonSeeLate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_chBoxChoseOne.Checked == true)
                {
                    String id = _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString();
                    String agree = "UPDATE _acc SET trangthai = '0' WHERE id_User = '" + id + "'";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                else if (j == 1)
                {
                    String agree = "UPDATE _acc SET trangthai = '0' WHERE trangthai = '-1'";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                else if (j == 2)
                {
                    
                }
                else
                {
                    String agree = "UPDATE _acc SET trangthai = '0' WHERE trangthai < 1";
                    class_CRUD agreeUpdate = new class_CRUD();
                    agreeUpdate.handleData(agree);
                }
                Main_Load(sender, e);
            }
            catch
            {

            }
        }

        private void _chBoxChoseOne_CheckedChanged(object sender, EventArgs e)
        {
            if(_chBoxChoseOne.Checked == true)
            {
                _chBoxChoseAll.Checked = false;
            }
            else
            {
                _chBoxChoseAll.Checked = true;
            }
        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (i == 0)
                {
                    _FormMessToChangeInfo f = new _FormMessToChangeInfo(nameAcc);
                    i = 1;
                    f.Show();
                }
                else
                {
                    String delAcc = "DELETE FROM _acc WHERE id_User = '" + _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString() + "'";
                    String delAcc1 = "DELETE FROM _user WHERE id_User = '" + _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString() + "'";
                    String delAcc2 = "DELETE FROM _luongCanhan WHERE id_User = '" + _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString() + "'";
                    class_CRUD delAccount = new class_CRUD();

                    delAccount.handleData(delAcc);
                    delAccount.handleData(delAcc1);
                    delAccount.handleData(delAcc2);
                    Main_Load(sender, e);

                    i = 0;
                }
            }
            catch
            {

            }
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
                else if (_cBoxChoseStatistic.Text == "Năm Kinh Nghiệm")
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

                        if (a / 365 < 1)
                        {
                            _1down++;
                        }
                        else if (a / 365 < 2)
                        {
                            _1t2++;
                        }
                        else if (a / 365 < 3)
                        {
                            _2t3++;
                        }
                        else if (a / 365 < 5)
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
                    _chartStatisticCot.Series["Age"].Points[0].AxisLabel = "Under 1";
                    _chartStatisticCot.Series["Age"].Points[0].LegendText = "Under 1";
                    _chartStatisticCot.Series["Age"].Points[0].Label = _1down.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_1t2);
                    _chartStatisticCot.Series["Age"].Points[1].AxisLabel = "1 to 2";
                    _chartStatisticCot.Series["Age"].Points[1].LegendText = "1 to 2";
                    _chartStatisticCot.Series["Age"].Points[1].Label = _1t2.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_2t3);
                    _chartStatisticCot.Series["Age"].Points[2].AxisLabel = "2 to 3";
                    _chartStatisticCot.Series["Age"].Points[2].LegendText = "2 to 3";
                    _chartStatisticCot.Series["Age"].Points[2].Label = _2t3.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_3t5);
                    _chartStatisticCot.Series["Age"].Points[3].AxisLabel = "3 to 5";
                    _chartStatisticCot.Series["Age"].Points[3].LegendText = "3 to 5";
                    _chartStatisticCot.Series["Age"].Points[3].Label = _3t5.ToString();


                    _chartStatisticCot.Series["Age"].Points.Add(_5up);
                    _chartStatisticCot.Series["Age"].Points[4].AxisLabel = "Over 5";
                    _chartStatisticCot.Series["Age"].Points[4].LegendText = "Over 5";
                    _chartStatisticCot.Series["Age"].Points[4].Label = _5up.ToString();

                    // Bieu do tron
                    _chartStatistic.Series["Age"].Points.AddXY("Under 1", _1down);
                    _chartStatistic.Series["Age"].Points.AddXY("1 to 2", _1t2);
                    _chartStatistic.Series["Age"].Points.AddXY("2 to 3", _2t3);
                    _chartStatistic.Series["Age"].Points.AddXY("3 to 5", _3t5);
                    _chartStatistic.Series["Age"].Points.AddXY("Over 5", _5up);
                }
            }
            catch
            {
                _labelMessStatistic.Text = "Không có dữ liệu.";
            }
        }

        private void _Mess_Click(object sender, EventArgs e)
        {

        }

        private void _dtgrtViewMess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numrowMess = e.RowIndex;
                _lbIDUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[0].Value.ToString();
                _lbNameSendUp.Text = _dtgrtViewMess.Rows[e.RowIndex].Cells[1].Value.ToString();
                String Content = "SELECT noiDung FROM thongBao WHERE id_User = '" + _lbIDUp.Text + "' AND tieuDe = N'"+ _dtgrtViewMess.Rows[e.RowIndex].Cells[3].Value.ToString() + "'";
                class_CRUD upContent = new class_CRUD();
                DataTable tableContent;
                tableContent = upContent.uploadData(Content);

                _tBContentSend.Text = tableContent.Rows[0][0].ToString();
            }
            catch
            {

            }

        }

        private void _buttonSeeAll_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND state > -2";
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

        private void _buttonSeeNew_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND state = 1";
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

        private void _buttonSeen_Click(object sender, EventArgs e)
        {
            try
            {
                String LoadSend = "SELECT thongbao.id_User, lastName, kieuSend, tieuDe FROM thongBao, _user WHERE thongBao.id_User = _user.id_User AND state = 0";
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

        private void _buttonSendMess_Click(object sender, EventArgs e)
        {
            _FormSendMess f = new _FormSendMess(nameAcc);
            f.Show();
        }

        private void _labelchuyenCV_Click(object sender, EventArgs e)
        {
            _FormChuyen f = new _FormChuyen(nameAcc, getpass(nameAcc));
            this.Close();
            f.Show();
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
                    String SeeLate = "DELETE FROM thongBao WHERE id_User = '" + _dtgrtViewMess.Rows[numrowMess].Cells[0].Value.ToString() + "' AND tieuDe = N'" + _dtgrtViewMess.Rows[numrowMess].Cells[3].Value.ToString() + "'";
                    class_CRUD dataSend = new class_CRUD();
                    dataSend.handleData(SeeLate);
                    _buttonSeeAll_Click(sender, e);


                    a = 0;
                }
            }
            catch
            {

            }
                

        }

        private void _buttonSeeLateReq_Click(object sender, EventArgs e)
        {
            try
            {
                String SeeLate = "UPDATE thongBao SET state = 0 WHERE id_User = '"+_dtgrtViewMess.Rows[numrowMess].Cells[0].Value.ToString()+"' AND tieuDe = N'"+_dtgrtViewMess.Rows[numrowMess].Cells[3].Value.ToString() + "' AND state != -2";
                class_CRUD dataSend = new class_CRUD();
                dataSend.handleData(SeeLate);
                _buttonSeen_Click(sender,e);


            }
            catch
            {

            }
            
        }

        private void _dtgrViewWait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataTable column = new DataTable();
            class_CRUD updata = new class_CRUD();
            numrowWait = e.RowIndex;
            try
            {
                _tBoxID2.Text = _dtgrViewWait.Rows[numrowWait].Cells[0].Value.ToString();
                String loadFirstName = "SELECT firstName FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadLastName = "SELECT lastName FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadbirthDay = "SELECT birthDay FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadCMND = "SELECT CMND FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadAddress = "SELECT Address FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";
                String loadEmail = "SELECT Email FROM _user WHERE id_User = '" + _tBoxID2.Text + "'";

                column = updata.uploadData(loadFirstName);
                this._tBoxFirstName2.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadLastName);
                this._tBoxLastName2.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadbirthDay);
                this._tBoxBirthDay2.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadCMND);
                this._tBoxCMND2.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadEmail);
                this._tBoxEmail2.Text = column.Rows[0][0].ToString();

                column = updata.uploadData(loadAddress);
                this._tBoxAddress2.Text = column.Rows[0][0].ToString();
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
    }
}
