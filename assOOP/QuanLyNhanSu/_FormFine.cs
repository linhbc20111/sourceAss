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
    public partial class _FormFine : Form
    {
        String ID;

        public _FormFine()
        {
            InitializeComponent();
        }

        private void _labelMess_Click(object sender, EventArgs e)
        {

        }

        public _FormFine(String Id) : this()
        {
            this.ID = Id;
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
           
        }

        private void _buttonOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_tBoxnumVnd.Text == "")
                {
                    _labelMess.Text = "Vui lòng nhập số tiền.";
                }
                else
                {
                    class_CRUD handle = new class_CRUD();
                    String Fine;
                    if (ID != "all")
                    {
                        Fine = "UPDATE _luongCaNhan SET phatCanhan += '" + _tBoxnumVnd.Text + "' WHERE id_User = '" + ID + "'";
                        if (handle.handleData(Fine))
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
                    else
                    {
                        Fine = "UPDATE _luongCaNhan SET phatCanhan += '" + _tBoxnumVnd.Text + "'";
                        if (handle.handleData(Fine))
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
                    
                }
            }
            catch
            {

            }
        }
    }
}
