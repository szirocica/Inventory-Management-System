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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sziro\OneDrive\Dokumentumok\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            UserNameTB.Text = "";
            PasswordTB.Text = "";
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTable where Uname = '" + UserNameTB.Text + "' and Upassword = '" + PasswordTB.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Wrong UserName Or PassWord");
            }

            connection.Close();
        }

        private void label_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
