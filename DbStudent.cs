using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfoSystem
{
    internal class DbStudent
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;username=root;password=56785678;database=studentdb";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message,  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void AddStudent(Student std)
        {         
            string sql = "INSERT INTO student_info VALUES (NULL, @StudentFirstName, @StudentLastName,@StudentBirthDate,@StudentEmail,@StudentPhone,@StudentAddress,@StudentPostalCode)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentFirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@StudentLastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@StudentBirthDate", MySqlDbType.Date).Value = std.BirthDate;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@StudentPhone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StudentAddress", MySqlDbType.VarChar).Value = std.Address;
            cmd.Parameters.Add("@StudentPostalCode", MySqlDbType.VarChar).Value = std.PostalCode;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student was successfully added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to add the student.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

        }
        public static void UpdateStudent(Student std, string id)
        {
       
            string sql = "UPDATE student_info SET FirstName = @StudentFirstName, LastName = @StudentLastName, BirthDate = @StudentBirthDate, Email = @StudentEmail, Phone = @StudentPhone, Address = @StudentAddress, PostalCode = @StudentPostalCode WHERE ID = @StudentID";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentFirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@StudentLastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@StudentBirthDate", MySqlDbType.Date).Value = std.BirthDate;
            cmd.Parameters.Add("@StudentEmail", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@StudentPhone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StudentAddress", MySqlDbType.VarChar).Value = std.Address;
            cmd.Parameters.Add("@StudentPostalCode", MySqlDbType.VarChar).Value = std.PostalCode;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The data has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("The data was not updated.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM student_info WHERE ID = @StudentID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The student has been successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to delete the student.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();

        }
    }
}
