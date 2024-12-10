using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class F_ShowTransact : Form
    {

        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement"; 
        public F_ShowTransact(int id, string date)
        {
            InitializeComponent();
            getTransact(id, date);
            getNameAndDate(id, date);
            
        }

        private void getTransact(int id, string date)
        {
            string query = 
            "SELECT " +
                "b.title, " +
                "b.author " +
            "FROM " +
                "books b " +
            "JOIN " +
                "copies c ON b.book_id = c.book_id " +
            "JOIN " +
                "transactions t ON c.copy_id = t.copy_id " +
            //"JOIN " +
            //    "students s ON t.student_id = s.student_id " +
            "WHERE " +
                "t.student_id = @id AND " +
                "t.borrow_date = @date";
            try
            {
                dgvResults.AutoGenerateColumns = false;
                dgvResults.Rows.Clear();

                connection = new MySqlConnection(conn);
                connection.Open();
                //DateTime dateBorrow = DateTime.Parse(date);

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvResults.Rows.Add(
                        dr["title"], 
                        dr["author"]
                        );
                }


                connection.Close();
                
            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void getNameAndDate(int id, string date)
        {
            string query = 
            "SELECT " +
                "CONCAT(s.first_name, ' ', last_name) AS fullname, " +
                "t.due_date " +
            "FROM " +
                "transactions t " +
            "JOIN " +
                "students s ON t.student_id = s.student_id " +
            "WHERE " +
                "t.student_id = @id AND " +
                "t.borrow_date = @date";
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblBorrow.Text = date.ToString();
                    lblDue.Text = reader.GetDateTime(1).ToString();
                    lblName.Text = reader.GetString(0);
                    lblStuNo.Text = id.ToString();
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
