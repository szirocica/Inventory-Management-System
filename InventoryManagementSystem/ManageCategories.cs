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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void button_add_category_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into CategoryTable values('" + CategoryIdTB.Text + "','" + CategoryNameTB.Text + "')", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Category added successfully!");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

        void populate()
        {
            try
            {
                connection.Open();
                string myQuery = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                categoriesGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (CategoryIdTB.Text == "")
            {
                MessageBox.Show("Enter The Category ID!");
            }
            else
            {
                connection.Open();
                string myQuery = "delete from CategoryTable where CategoryId = '" + CategoryIdTB.Text + "';";
                SqlCommand command = new SqlCommand(myQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully!");
                connection.Close();
                populate();
            }
        }

        private void categoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIdTB.Text = categoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryNameTB.Text = categoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update CategoryTable set CategoryName = '" + CategoryNameTB.Text + "', CategoryId = '" + CategoryIdTB.Text + "' where CategoryId = '" + CategoryIdTB.Text + "'", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

        private void category_home_button_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
