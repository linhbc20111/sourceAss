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
    public partial class _FormChuyen : Form
    {

        private String nameAcc, pass;                                                               // value to store name acc and pass use to tranmist


        public _FormChuyen()
        {
            InitializeComponent();
        }

        /*
         * Function constructor receive two string is name acc and pass
         * Get string and set 
         */
        public _FormChuyen(String nameAcc, String pass) : this()
        {
            this.nameAcc = nameAcc;                                                                 // set name acc
            this.pass = pass;                                                                       // set pass                                       
        }


        private void _chBoxQuanLy_CheckedChanged(object sender, EventArgs e)                        // check chuc vu
        {
            if (_chBoxQuanLy.Checked == true)
            {
                _chBoxNhanVien.Checked = false;
            }
            else
            {
                _chBoxNhanVien.Checked = true;
            }
        }

        private void _chBoxNhanVien_CheckedChanged(object sender, EventArgs e)                      // check chuc vu
        {
            if (_chBoxNhanVien.Checked == true)
            {
                _chBoxQuanLy.Checked = false;
            }
            else
            {
                _chBoxQuanLy.Checked = true;
            }
            
        }


        /*
         * Funtion is a event
         * Fuvtion will call form with chuc vu tuong ung
         */
        private void _buttonChuyen_Click(object sender, EventArgs e)
        {
            if (_chBoxQuanLy.Text == "Quản Lý Nhân Sự" && _chBoxQuanLy.Checked == true)                 // check QLNS
            {
                Main f = new Main(nameAcc);
                this.Hide();
                f.Show();
            }
            else if (_chBoxQuanLy.Text == "Quản Lý Tài Chính" && _chBoxQuanLy.Checked == true)          // check QLTC
            {
                _FormQuanLyTaiChinh f = new _FormQuanLyTaiChinh(nameAcc);
                this.Hide();

                f.Show();
            }
            else
            {
                _FormNhanVien f = new _FormNhanVien(nameAcc);                                           // check NV
                this.Hide();

                f.Show();
            }
        }

        /*
         * Fuction check chuc vu and hide chuc vu not need
         */
        private void _FormChuyen_Load(object sender, EventArgs e)
        {
            _chBoxQuanLy.Checked = true;
            _chBoxNhanVien.Checked = false;

            // Command SQL to check chuc vu
            String dangnhapQLNS = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Nhân Sự' AND trangthai = '1'";
            String dangnhapNV = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Nhân Viên' AND trangthai = '1'";
            String dangnhapQLTC = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Tài Chính' AND trangthai = '1'";
            class_CRUD crud = new class_CRUD();


            // check
            if (crud.exedata(dangnhapQLNS))                             // check QLNS
            {
                _chBoxQuanLy.Text = "Quản Lý Nhân Sự";
            }
            else if (crud.exedata(dangnhapQLTC))                        // check QLTC
            {

                _chBoxQuanLy.Text = "Quản Lý Tài Chính";
            }
            else if (crud.exedata(dangnhapNV))                          // check NV
            {
                _chBoxQuanLy.Hide();
                _chBoxQuanLy.Checked = false;
            }

        }
    }
}
