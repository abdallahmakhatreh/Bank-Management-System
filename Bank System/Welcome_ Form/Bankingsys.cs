using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace Welcome__Form
{
    class Bankingsys
    {
        private static string myConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Abdallah\Documents\Projects\Final Project CIS 214\Final Project\dbBankSystem.mdb";
        private static string selectQuery = "SELECT * FROM User_Tables";
        public bool AddUser(string UserName, string Password, string FullName, string Contact, string Address, string Gender)
        {
            int rows = 0;

            string addquery = "Insert Into User_Table(User_UserName, User_Password, User_FullName, User_Contact, User_Address, User_Gender) Values(@u_un_p, u_pw_p, u_fn_p, u_c_p, u_a_p, u_g_p) ";

            DataTable dataTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(myConn))
            {
                connection.Open();
                using (OleDbCommand com = new OleDbCommand(addquery, connection))
                {
                    com.Parameters.AddWithValue("@u_un_p", UserName);
                    com.Parameters.AddWithValue("@u_pw_p", Password);
                    com.Parameters.AddWithValue("@u_fn_p", FullName);
                    com.Parameters.AddWithValue("@u_c_p", Contact);
                    com.Parameters.AddWithValue("@u_a_p", Address);
                    com.Parameters.AddWithValue("@u_g_p", Gender);

                    rows = com.ExecuteNonQuery();

                }
            }

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateUser(string UserName, string Password, string FullName, string Contact, string Address, string Gender)
        {
            int rows = 0;

            string updatequery = "Update User_Table SET User_UserName = @u_un_p, User_Password = @u_pw_p, User_FullName = @u_fn_p, User_Contact = @u_c_p, User_Address = @u_a_p, User_Gender = @u_g_p WHERE User_UserName = @u_un_p ";

            DataTable dataTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(myConn))
            {
                connection.Open();
                using (OleDbCommand com = new OleDbCommand(updatequery, connection))
                {
                    com.Parameters.AddWithValue("@u_un_p", UserName);
                    com.Parameters.AddWithValue("@u_pw_p", Password);
                    com.Parameters.AddWithValue("@u_fn_p", FullName);
                    com.Parameters.AddWithValue("@u_c_p", Contact);
                    com.Parameters.AddWithValue("@u_a_p", Address);
                    com.Parameters.AddWithValue("@u_g_p", Gender);

                    rows = com.ExecuteNonQuery();

                }
            }

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
            
        
}
