using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserControl_Library
{
    public partial class UC_Dashboard : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        public UC_Dashboard()
        {
            InitializeComponent();
            getBorrowed();
            getDue();
            getOverDue();
            LoadBooks();
        }
        private void getBorrowed()
        {
            connection = new MySqlConnection(conn);
            connection.Open();

            string query = "SELECT COUNT(DISTINCT s.student_id) " +
                "FROM students s " +
                "INNER JOIN transactions t ON s.student_id = t.student_id " +
                "WHERE t.status = 'On-Going'";
            cmd = new MySqlCommand(query, connection);
            
            long count = (long)cmd.ExecuteScalar();
            lbl_Borrowed.Text = count.ToString();
            connection.Close();
        }

        private void getDue()
        {
            connection = new MySqlConnection(conn);
            connection.Open();

            string query = "SELECT COUNT(DISTINCT s.student_id) " +
                "FROM students s " +
                "INNER JOIN transactions t ON s.student_id = t.student_id " +
                "WHERE t.due_date = NOW()";
            cmd = new MySqlCommand(query, connection);

            long count = (long)cmd.ExecuteScalar();
            lbl_Due.Text = count.ToString();
            connection.Close();
        }

        private void getOverDue()
        {
            connection = new MySqlConnection(conn);
            connection.Open();

            string query = "SELECT COUNT(DISTINCT s.student_id) " +
                "FROM students s " +
                "INNER JOIN transactions t ON s.student_id = t.student_id " +
                "WHERE t.due_date < NOW()";
            cmd = new MySqlCommand(query, connection);

            long count = (long)cmd.ExecuteScalar();
            lbl_Overdue.Text = count.ToString();
            connection.Close();
        }
        private void LoadBooks(string filter = "")
        {
            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Rows.Clear();
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                string query;
                if (string.IsNullOrEmpty(filter))
                {
                    query = "SELECT category, title, author FROM books";
                }
                else
                {
                    query = "SELECT category, title, author " +
                        "FROM books " +
                        "WHERE title LIKE @Filter OR author LIKE @Filter";
                }

                cmd = new MySqlCommand(query, connection);
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dgvAvailable.Rows.Add(
                            row["category"],
                            row["title"],
                            row["author"]
                        );
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchEvent()
        {
            AvailableBookSearch.TextChanged += AvailableBookSearch_TextChanged;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AvailableBookSearch_TextChanged(object sender, EventArgs e)
        {
            string filterTxt = AvailableBookSearch.Text.Trim();
            LoadBooks(filterTxt);
        }


    }
}
