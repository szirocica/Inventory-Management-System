using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void fill_category() {
            string query = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                ProductCategoryCB.ValueMember = "CategoryName";
                ProductCategoryCB.DataSource = dt;
                SearchCategoryCB.ValueMember = "CategoryName";
                SearchCategoryCB.DataSource = dt;
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void fill_search_cb()
        {
            string query = "select * from CategoryTable where CategoryName = '" + SearchCategoryCB.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                ProductCategoryCB.ValueMember = "CategoryName";
                ProductCategoryCB.DataSource = dt;
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

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            fill_category();
            populate();
        }

        void populate()
        {
            try
            {
                connection.Open();
                string myQuery = "select * from ProductTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void filter_by_category()
        {
            try
            {
                connection.Open();
                string myQuery = "select * from ProductTable where ProductCategory = '" + SearchCategoryCB.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button_add_product_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into ProductTable values('" + ProductIdTB.Text + "','" + ProductNameTB.Text + "','" + ProductQuantityTB.Text + "','" + ProductPriceTB.Text + "','" + ProductDescriptionTB.Text + "','" + ProductCategoryCB.SelectedValue.ToString() + "')", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

        private void button_delete_product_Click(object sender, EventArgs e)
        {
            if (ProductIdTB.Text == "")
            {
                MessageBox.Show("Enter The Products ID!");
            }
            else
            {
                connection.Open();
                string myQuery = "delete from ProductTable where ProductId = '" + ProductIdTB.Text + "';";
                SqlCommand command = new SqlCommand(myQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully!");
                connection.Close();
                populate();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIdTB.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTB.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantityTB.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPriceTB.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductDescriptionTB.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            ProductCategoryCB.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button_edit_product_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update ProductTable set ProductId = '" + ProductIdTB.Text + "', ProductName = '" + ProductNameTB.Text + "', ProductQuantity = '" + ProductQuantityTB.Text + "', ProductPrice = '" + ProductPriceTB.Text + "', ProductDescription = '" + ProductDescriptionTB.Text + "', ProductCategory = '" + ProductCategoryCB.SelectedValue.ToString() + "' where ProductId = '" + ProductIdTB.Text + "'", connection);
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

        private void search_product_category_Click(object sender, EventArgs e)
        {
            filter_by_category();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void product_home_button_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
