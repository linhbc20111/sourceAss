using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu
{
    public class class_CRUD
    {
        // Constructer connection with database
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BQA7EMM\SQLEXPRESS;Initial Catalog=DBQLNS;Integrated Security=True");

        // Fuction open and close connetion, check to not fail
        public void openconnect()                  // open connect
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }   
        public void closeconnect()                 //close connect
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // Handle cmd command

        public Boolean exedata(string cmd)
        {
            openconnect();                  // open connect
            Boolean check = false;          // defautl 
            SqlDataReader reader ;
            SqlCommand sc = new SqlCommand(cmd, con);
            reader = sc.ExecuteReader();
            if (reader.Read())
            {
                check = true;
            }
            sc.Dispose();
            reader.Dispose();
            closeconnect();
            return check;
        }

        /*
         * Check NULL data
         * If data NULL return false
         * Else data not NULL return true
         */
        public Boolean checkData(string cmd)
        {
            openconnect();   // open connect
            Boolean check = false;    // value check
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);   // command SQL
                SqlDataReader read;         
                read = sc.ExecuteReader();                      
                if (read.Read())                        // check
                {
                    check = true;
                }
                sc.Dispose();
                read.Dispose();
            }
            catch
            {
                check = false;
            }
            
            closeconnect();                             // close connect
            return check;
        }
        /*
         * Function return true if handle data success
         * else return false
         */
        public Boolean handleData(string cmd)
        {
            openconnect();                                  //  open connect
            Boolean check = false;                          //  value check
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);   //  get command SQL
                sc.ExecuteNonQuery();                       //  handle
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();                                 // close connect
            return check;                                   // return
        }
        //
        /* 
         * Function return Datatable
         * Receive a string command SQL
         */
        public DataTable uploadData(String cmd)
        {
            DataTable column = new DataTable();                 // value datatable to store
            try
            {
                openconnect();                                  // open connect
                SqlCommand sc = new SqlCommand(cmd, con);       // get command SQL
                SqlDataAdapter read = new SqlDataAdapter(sc);   // value to fill data for datatable
                
                read.Fill(column);                              // fill data

                sc.Dispose();
                read.Dispose();
                closeconnect();                                 // close connect
                return column;                                  // return
            }
            catch
            {

            }
            return column;                                      // return
        }

        //
        /* 
         * Fuction receive a string is command SQL
         * Return a number int if have data
         * Else return 0
         */
        public int readData(String cmd)
        {
            openconnect();                                      // open connect
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);       // get command at connect
                SqlDataReader read;                             // creat a SqlDataReader
                read = sc.ExecuteReader();                      // Handle
                
                return Convert.ToInt32(read[0]);                // Return number if have data else go to exeption
            }
            catch
            {
                return 0;                                       // Return 0 if have not data
            }
        }

    }
}
