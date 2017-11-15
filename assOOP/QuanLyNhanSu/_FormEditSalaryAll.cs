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
    public partial class _FormEditSalaryAll : Form
    {
        public _FormEditSalaryAll()
        {
            InitializeComponent();
        }

        private void _labelMess_Click(object sender, EventArgs e)
        {

        }

        private void _FormEditSalaryAll_Load(object sender, EventArgs e)
        {
            try
            {
                String getData = "SELECT [luong/ngay], chietKhau FROM _luongTong";
                class_CRUD get = new class_CRUD();
                DataTable datatb = get.uploadData(getData);

                _tBoxChietKhau.Text = datatb.Rows[0][1].ToString();
                _tBoxLuongNgay.Text = datatb.Rows[0][0].ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_tBoxChietKhau.Text == "" || _tBoxLuongNgay.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin.";
            }
            try
            {
                String update = "UPDATE _luongTong SET [luong/ngay] = '" + _tBoxLuongNgay.Text + "', chietKhau = '" + _tBoxChietKhau.Text + "'";
                class_CRUD updateData = new class_CRUD();
                if (updateData.handleData(update))
                {
                    _FormMessComplete f = new _FormMessComplete();
                    f.Show();
                    this.Close();
                }
                else
                {
                    _labelMess.Text = "Vui lòng nhập đúng định dạng.";
                }
                
            }
            catch
            {

            }
        }
    }
}
