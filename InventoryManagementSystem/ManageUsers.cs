using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate() {
            try
            {
                connection.Open();
                string myQuery = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                usersGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("ASD");
                throw;
            }
        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into UserTable values('"+unameTB.Text+"','"+fullnameTB.Text+"','"+passwordTB.Text+"','"+telephoneTB.Text+"')", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User added successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (telephoneTB.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else {
                connection.Open();
                string myQuery = "delete from UserTable where Uphone = '" + telephoneTB.Text +"';";
                SqlCommand command = new SqlCommand(myQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully!");
                connection.Close();
                populate();
            }
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTB.Text = usersGV.SelectedRows[0].Cells[0].Value.ToString();
            fullnameTB.Text = usersGV.SelectedRows[0].Cells[1].Value.ToString();
            passwordTB.Text = usersGV.SelectedRows[0].Cells[2].Value.ToString();
            telephoneTB.Text = usersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update UserTable set Uname = '" + unameTB.Text + "', Ufullname = '" + fullnameTB.Text + "', Upassword = '" + passwordTB.Text + "' where Uphone = '" + telephoneTB.Text + "'", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

        private void users_home_button_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
