using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace LibraryManagementSystem.General_Class
{
    internal class SqlConnection
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
      

        //FOR LOGIN
        public void Login(string user, string password)
        {
            string query = "SELECT user_id, user_level FROM user_accounts WHERE email = @email AND password = @password";
            
            
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                
                cmd.Parameters.AddWithValue("@email", user);
                cmd.Parameters.AddWithValue ("@password", password); 
                MySqlDataReader result = cmd.ExecuteReader();

                if (result.Read())
                {
                    int id = result.GetInt32(0);
                    openForm(result.GetString(1).ToLower(), id);
                    
                    connection.Close();
                    logHistory(id);
                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void openForm(string userLevel, int id)
        {
            Form target;

            switch (userLevel)
            {
                case "admin":
                    target = new F_Admin();
                    break;
                case "librarian":
                    target = new F_Library(id);
                    break;
                default:
                    return;
            }
            target.Show();
        }

        public void logHistory(int id)
        {
            
            try
            {
                connection.Open();
                string history = "INSERT into user_history(user_id, created_by, updated_by) VALUES (@user_id, NOW(), NOW())";
                cmd = new MySqlCommand(history, connection);
                cmd.Parameters.AddWithValue("@user_id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
