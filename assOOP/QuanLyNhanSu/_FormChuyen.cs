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

        String nameAcc, pass;
        public _FormChuyen()
        {
            InitializeComponent();
        }

        public _FormChuyen(String nameAcc, String pass) : this()
        {
            this.nameAcc = nameAcc;
            this.pass = pass;
        }

        private void _chBoxQuanLy_CheckedChanged(object sender, EventArgs e)
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

        private void _chBoxNhanVien_CheckedChanged(object sender, EventArgs e)
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

        private void _buttonChuyen_Click(object sender, EventArgs e)
        {
            if (_chBoxQuanLy.Text == "Quản Lý Nhân Sự" && _chBoxQuanLy.Checked == true)
            {
                Main f = new Main(nameAcc);
                this.Hide();
                f.Show();
            }
            else if (_chBoxQuanLy.Text == "Quản Lý Tài Chính" && _chBoxQuanLy.Checked == true)
            {
                _FormQuanLyTaiChinh f = new _FormQuanLyTaiChinh(nameAcc);
                this.Hide();

                f.Show();
            }
            else
            {
                _FormNhanVien f = new _FormNhanVien(nameAcc);
                this.Hide();

                f.Show();
            }
        }

        private void _FormChuyen_Load(object sender, EventArgs e)
        {
            _chBoxQuanLy.Checked = true;
            _chBoxNhanVien.Checked = false;

            String dangnhapQLNS = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Nhân Sự' AND trangthai = '1'";
            String dangnhapNV = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Nhân Viên' AND trangthai = '1'";
            String dangnhapQLTC = "SELECT * FROM _acc WHERE tenTaikhoan = N'" + nameAcc + "' AND matkhau = N'" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND quyensudung = N'Quản Lý Tài Chính' AND trangthai = '1'";
            class_CRUD crud = new class_CRUD();



            if (crud.exedata(dangnhapQLNS))
            {
                _chBoxQuanLy.Text = "Quản Lý Nhân Sự";
            }
            else if (crud.exedata(dangnhapQLTC))
            {

                _chBoxQuanLy.Text = "Quản Lý Tài Chính";
            }
            else if (crud.exedata(dangnhapNV))
            {
                _chBoxQuanLy.Hide();
                _chBoxQuanLy.Checked = false;
            }

        }
    }
}
