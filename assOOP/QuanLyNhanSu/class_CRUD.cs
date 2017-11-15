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
        public Boolean checkData(string cmd)
        {
            openconnect();
            Boolean check = false;
            try {  
            SqlCommand sc = new SqlCommand(cmd, con);
            SqlDataReader read;
            read = sc.ExecuteReader();
            if (read.Read())
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
            
            closeconnect();
            return check;
        }
        public Boolean handleData(string cmd)
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        //
        public DataTable uploadData(String cmd)
        {
            DataTable column = new DataTable();
            try
            {
                openconnect();
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter read = new SqlDataAdapter(sc);
                
                read.Fill(column);

                sc.Dispose();
                read.Dispose();
                closeconnect();
                return column;
            }
            catch
            {

            }
            return column;
        }

        //
        public int readData(String cmd)
        {
            openconnect();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataReader read;
                read = sc.ExecuteReader();
                if (read.Read())
                {
                    return Convert.ToInt32(read[0]);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

    }
}
