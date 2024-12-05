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
    public partial class UC_Archive_Student : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        public UC_Archive_Student()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid(string filter = "")
        {
            TransacGrid.AutoGenerateColumns = false;
            TransacGrid.Rows.Clear();

            connection = new MySqlConnection(conn);
            connection.Open();
            try
            {
                string query = "SELECT t.student_id, CONCAT(s.last_name, ', ', s.first_name) AS fullname, " +
                    "t.borrow_date, t.status " +
                    "FROM transactions t " +
                    "JOIN students s ON t.student_id = s.student_id";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE " + filter;
                }

                cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    TransacGrid.Rows.Add(
                            row["student_id"],
                            row["fullname"],
                            row["borrow_date"],
                            row["status"]
                        );
                }
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getResults(string filter = "")
        {
            TransacGrid.AutoGenerateColumns = false;
            TransacGrid.Rows.Clear();

            connection = new MySqlConnection(conn);
            connection.Open();
            try
            {
                string query = "SELECT t.student_id, CONCAT(s.last_name, ', ', s.first_name) AS fullname, " +
                    "t.borrow_date, t.status " +
                    "FROM transactions t " + 
                    "JOIN students s ON t.student_id = s.student_id ";
                if (!string.IsNullOrEmpty(filter))
                {
                    query += "WHERE t.student_id LIKE @filter OR last_name LIKE @filter OR first_name LIKE @filter";
                }

                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    TransacGrid.Rows.Add(
                            row["student_id"],
                            row["fullname"],
                            row["borrow_date"],
                            row["status"]
                        );
                }
                connection.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBtxt_Enter(object sender, EventArgs e)
        {
            if (searchBtxt.Text.Equals("Enter Student Number or Name"))
            {
                searchBtxt.Text = "";
                searchBtxt.ForeColor = Color.Black;
            }
        }

        private void searchBtxt_Leave(object sender, EventArgs e)
        {
            if (searchBtxt.Text.Equals(""))
            {
                searchBtxt.Text = "Enter Student Number or Name";
                searchBtxt.ForeColor = Color.LightGray;
            }
        }

        private void Filterbtn_Click(object sender, EventArgs e)
        {
            F_FilterBy filter = new F_FilterBy();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                string filterQuery = filter.getFilter();
                LoadGrid(filterQuery);
            }
        }


        private void searchEvent()
        {
            searchBtxt.TextChanged += searchBtxt_TextChanged;
        }
        private void searchBtxt_TextChanged(object sender, EventArgs e)
        {
            string filter = searchBtxt.Text.Trim();
            getResults(filter);
        }
    }
}
