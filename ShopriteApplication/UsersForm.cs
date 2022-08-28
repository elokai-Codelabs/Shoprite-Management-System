using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopriteApplication
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();
            ProductForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CategoryForm = new CategoryForm();
            CategoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var SellingForm = new ShoppingForm();
            SellingForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ADD User
            try
            {
                if (userId.Text == "" || userName.Text == "" || userAge.Text == "" || userPhone.Text == "" || userPassword.Text == "" || userRole.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add a user");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "INSERT INTO users(ID,USERNAME,AGE,PHONE,PASSWORD,ROLE) VALUES('" + this.userId.Text + "','" + this.userName.Text + "','" + this.userAge.Text + "','" + this.userPhone.Text + "','" + this.userPassword.Text + "','" + this.userRole.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("User successfully added");
                    conn.Close();
                    // populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //Update User
            try
            {
                if (userId.Text == "" || userName.Text == "" || userAge.Text == "" || userPhone.Text == "" || userPassword.Text == "" || userRole.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add a user");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "UPDATE users SET ID ='" + this.userId.Text + "', USERNAME ='" + this.userName.Text + "', AGE = '" + this.userAge.Text + "',PHONE ='" + this.userPhone.Text + "',PASSWORD ='" + this.userPassword.Text + "',ROLE ='" + this.userRole.Text + "' WHERE ID ='" + this.userId.Text + "' ";

                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("User successfully added");
                    conn.Close();
                    // populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //DELETE PRODUCT FROM DATABASE
            try
            {
                if (userId.Text == "")
                {
                    MessageBox.Show("Select a user before you can delete ");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "DELETE FROM users WHERE ID ='" + this.userId.Text + "' ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Deleted successfully ");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            userId.Text = "";
            userName.Text = "";
            userAge.Text = "";
            userPhone.Text = "";
            userPassword.Text = "";
            userRole.Text = "";
        }
    }
}
