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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                connection.Open();
                string myQuery = "select * from CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customersGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("ASD");
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_users_list_Click(object sender, EventArgs e)
        {

        }

        private void button_add_customer_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into CustomerTable values('" + customerIdTB.Text + "','" + CustomerNameTB.Text + "','" + CustomerTelephoneTB.Text + "')", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (customerIdTB.Text == "")
            {
                MessageBox.Show("Enter Customer Id!");
            }
            else
            {
                connection.Open();
                string myQuery = "delete from CustomerTable where CustomerId = '" + customerIdTB.Text + "';";
                SqlCommand command = new SqlCommand(myQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully!");
                connection.Close();
                populate();
            }
        }

        private void customersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIdTB.Text = customersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTB.Text = customersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerTelephoneTB.Text = customersGV.SelectedRows[0].Cells[2].Value.ToString();

            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTable where CustomerId = " + customerIdTB.Text + "", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            order_count_label.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmount) from OrderTable where CustomerId = " + customerIdTB.Text + "", connection);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            order_amount_label.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTable where CustomerId = " + customerIdTB.Text + "", connection);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            order_date_label.Text = dt2.Rows[0][0].ToString();
            connection.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update CustomerTable set CustomerId = '" + customerIdTB.Text + "', CustomerName = '" + CustomerNameTB.Text + "', CustomerPhone = '" + CustomerTelephoneTB.Text + "' where CustomerId = '" + customerIdTB.Text + "'", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully");
                connection.Close();
                populate();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void customers_home_button_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
            
        }
    }
}
