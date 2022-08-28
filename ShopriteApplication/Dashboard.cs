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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            //Read categories
            string sumCategory = "SELECT count(ID) FROM category";
            MySqlCommand cmd = new MySqlCommand(sumCategory, conn);
            //Read Users
            string sumUsers = "SELECT count(ID) FROM users";
            MySqlCommand cmd1 = new MySqlCommand(sumUsers, conn);
            //Read Product
            string sumProduct = "SELECT count(ID) FROM product";
            MySqlCommand cmd2 = new MySqlCommand(sumProduct, conn);
            
            var sum = cmd.ExecuteScalar();
            label2.Text = sum.ToString();
            var sum1 = cmd1.ExecuteScalar();
            label3.Text = sum1.ToString();
            var sum2 = cmd2.ExecuteScalar();
            label5.Text = sum2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var CategoryForm = new CategoryForm();
            CategoryForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();
            ProductForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();
            ProductForm.Show();
            this.Hide();
        }
    }
}
