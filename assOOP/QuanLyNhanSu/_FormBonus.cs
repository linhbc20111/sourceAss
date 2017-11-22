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
        private String ID;                                       // value to tranmist ID
        public _FormBonus()
        {
            InitializeComponent();
        }
        /* 
         * Function constructor to tranmist from form to another form
         * Function receive a string is ID
         */
        public _FormBonus(String Id) : this()
        {
            this.ID = Id;                                       // tranmist ID
        }
        /* 
         * Fuction to when click button OK, it will update money bonus
         * This is event 
         */
        private void _buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tBoxnumVnd.Text == "")
                {
                    _labelMess.Text = "Vui lòng nhập số tiền."; // check null text box monney bonus
                }
                else
                {
                    class_CRUD handle = new class_CRUD();       // creat class handle
                    String Bonus;                               // command SQL to update
                    if (ID != "all")
                    {
                        Bonus = "UPDATE _luongCaNhan SET thuongCanhan += '" + _tBoxnumVnd.Text + "' WHERE id_User = '" + ID + "'";   // command update all
                        if (handle.handleData(Bonus))                                                                                // handle update all
                        {
                            _FormMessComplete f = new _FormMessComplete();                                                          // Mess when complete
                            f.Show();
                            this.Close();
                        }
                        else
                        {
                            _labelMess.Text = "Vui lòng nhập đúng định dạng.";                                                      // Check fault int of monney
                        }

                    }
                    else
                    {
                        Bonus = "UPDATE _luongCaNhan SET thuongCanhan += '" + _tBoxnumVnd.Text + "'";                               // command update one
                        if (handle.handleData(Bonus))                                                                               // handle update
                        {
                            _FormMessComplete f = new _FormMessComplete();
                            f.Show();
                            this.Close();
                        }
                        else
                        {
                            _labelMess.Text = "Vui lòng nhập đúng định dạng.";                                                      // Check fault int of monney
                        }
                    }
                    
                }
            }
            catch
            {
                // Exception
            }
        }
    }
}
