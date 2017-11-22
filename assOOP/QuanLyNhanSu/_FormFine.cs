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
        private String ID;                                                  // string to store id 

        public _FormFine()
        {
            InitializeComponent();
        }

        // don't care this function
        private void _labelMess_Click(object sender, EventArgs e)
        {

        }

        /*
        * Fuction constructor receive a tring and set ID
        */
        public _FormFine(String Id) : this()
        {
            this.ID = Id;                                                   // set ID
        }

        private void _buttonOK_Click(object sender, EventArgs e)
        {
           
        }
        /*
        * This is a event
        * When click this button , this fuction will fine salary of ID 
        * Exception if error
        * 
        */
        private void _buttonOk_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_tBoxnumVnd.Text == "")
                {
                    _labelMess.Text = "Vui lòng nhập số tiền.";                     // Mess if text box null
                }
                else
                {
                    class_CRUD handle = new class_CRUD();                           // creat class to handle data
                    String Fine;                                                    // String command SQL to update
                    if (ID != "all")
                    {
                        Fine = "UPDATE _luongCaNhan SET phatCanhan += '" + _tBoxnumVnd.Text + "' WHERE id_User = '" + ID + "'";             // Command SQL
                        if (handle.handleData(Fine))                                // handle data
                        {
                            _FormMessComplete f = new _FormMessComplete();          // Mess when complete
                            f.Show();
                            this.Close();
                        }
                        else
                        {
                            _labelMess.Text = "Vui lòng nhập đúng định dạng.";      // Mess when error
                        }

                    }
                    else
                    {
                        Fine = "UPDATE _luongCaNhan SET phatCanhan += '" + _tBoxnumVnd.Text + "'";                      // Fine salary all
                        if (handle.handleData(Fine))                                // Handle data
                        {
                            _FormMessComplete f = new _FormMessComplete();          // Mess when complete 
                            f.Show();
                            this.Close();
                        }
                        else
                        {
                            _labelMess.Text = "Vui lòng nhập đúng định dạng.";      // Mess when error
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
