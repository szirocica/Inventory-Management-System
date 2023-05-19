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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate_customer()
        {
            try
            {
                connection.Open();
                string myQuery = "select * from CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(myQuery, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void populate_product()
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
                //populate_product();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void fill_category()
        {
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
                //ProductCategoryCB.ValueMember = "CategoryName";
                //ProductCategoryCB.DataSource = dt;
                SearchCategoryCB.ValueMember = "CategoryName";
                SearchCategoryCB.DataSource = dt;
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void label_products_list_Click(object sender, EventArgs e)
        {

        }

        

        int num = 0;
        int uprice, total_price, qty, stock;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e) {
            populate_customer();
            populate_product();
            fill_category();
            
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("Total Price", typeof(int));

            OrdersGV.DataSource = table;
            
        }


        private void CustomerIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTB.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTB.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchCategoryCB_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchCategoryCB_SelectionChangeCommitted(object sender, EventArgs e)
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


        DataTable table = new DataTable();
        int sum = 0;

        private void button_add_order_Click(object sender, EventArgs e)
        {
        
            if (QuantityTB.Text == "") {
                MessageBox.Show("Enter The Quantity Of Products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product");
            }
            else if (Convert.ToInt32(QuantityTB.Text) < 1)
            {
                MessageBox.Show("Enter A Positive Quantity");
            }
            else if (Convert.ToInt32(QuantityTB.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Available");
            }
            else
            {
                num += 1;
                qty = Convert.ToInt32(QuantityTB.Text);
                total_price = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, total_price);
                OrdersGV.DataSource = table;
                flag = 0;

                update_product_quantity_in_stock();

                //Console.WriteLine(qty);
                //Console.WriteLine(total_price);
            }
            sum += total_price;
            TotalAmount.Text = sum.ToString(); 
        }

        //updating stock in case of purchase
       
        void update_product_quantity_in_stock() {
            
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQuantity = stock - Convert.ToInt32(QuantityTB.Text);
            if (newQuantity < 0) {
                MessageBox.Show("Operation Failed");
            }
            else{
                connection.Open();
                string query = "update ProductTable set ProductQuantity = '" + newQuantity + "' where ProductId = '" + id + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                populate_product();
            }
            
        }

        private void insert_order_button_Click(object sender, EventArgs e)
        {
            if (CustomerIdTB.Text == "" || CustomerNameTB.Text == "" || TotalAmount.Text == "0" || OrderIdTB.Text == "") {
                MessageBox.Show("Fill data correctly!");
            }
            else
            {
                SqlCommand command = new SqlCommand("insert into OrderTable values('" + OrderIdTB.Text + "','" + CustomerIdTB.Text + "','" + CustomerNameTB.Text + "','" + guna2DateTimePicker1.Text + "','" + TotalAmount.Text + "')", connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    connection.Close();
                    //populate();
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    throw;
                }
            }
        }

        private void view_orders_button_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();
        }

        private void orders_home_button_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        int flag = 0;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QuantityTB.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //total_price = qty * uprice;
            flag = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /*
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
            */
        }
    }
}
