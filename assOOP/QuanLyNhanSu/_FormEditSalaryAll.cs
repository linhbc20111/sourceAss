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

        // Don't care this function
        private void _labelMess_Click(object sender, EventArgs e)
        {

        }


        /*
         * This function use to upload data when this from open
         * Get data from database and put in text box
         */
        private void _FormEditSalaryAll_Load(object sender, EventArgs e)
        {
            try
            {
                String getData = "SELECT [luong/ngay], chietKhau FROM _luongTong";          // command SQL to up load data
                class_CRUD get = new class_CRUD();                                          // creat class to upload data
                DataTable datatb = get.uploadData(getData);                                 // data table use to store data

                _tBoxChietKhau.Text = datatb.Rows[0][1].ToString();                         // put in text box
                _tBoxLuongNgay.Text = datatb.Rows[0][0].ToString();

            }
            catch
            {
                // Exception
            }
        }

        /*
         * This is a event
         * When click to this button function will be update data by get data from text box
         * And store in data base
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if(_tBoxChietKhau.Text == "" || _tBoxLuongNgay.Text == "")
            {
                _labelMess.Text = "Vui lòng điền đủ thông tin.";                                    // Mess when content in text box null
            }
            try
            {
                String update = "UPDATE _luongTong SET [luong/ngay] = '" + _tBoxLuongNgay.Text + "', chietKhau = '" + _tBoxChietKhau.Text + "'";  // Command SQL to update
                class_CRUD updateData = new class_CRUD();                                           // creat class to update
                if (updateData.handleData(update))                                                  // handle data
                {
                    _FormMessComplete f = new _FormMessComplete();                                  // Mess when complete
                    f.Show();
                    this.Close();
                }
                else
                {
                    _labelMess.Text = "Vui lòng nhập đúng định dạng.";                              // else mess error
                }
                
            }
            catch
            {
                // Exception
            }
        }
    }
}
