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
    public partial class _FormBonus : Form
    {
        String ID;
        public _FormBonus()
        {
            InitializeComponent();
        }

        public _FormBonus(String Id) : this()
        {
            this.ID = Id;
        }

        private void _buttonOK_Click(object sender, EventArgs e)
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
                    String Bonus;
                    if (ID != "all")
                    {
                        Bonus = "UPDATE _luongCaNhan SET thuongCanhan += '" + _tBoxnumVnd.Text + "' WHERE id_User = '" + ID + "'";
                        if (handle.handleData(Bonus))
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
                        Bonus = "UPDATE _luongCaNhan SET thuongCanhan += '" + _tBoxnumVnd.Text + "'";
                        if (handle.handleData(Bonus))
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
