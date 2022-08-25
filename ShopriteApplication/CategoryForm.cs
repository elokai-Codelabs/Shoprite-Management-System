using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShopriteApplication
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
           
            //ADD TO DATABASE
        {
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            string query = "INSERT INTO category(ID,NAME,DESCRIPTION) VALUES('" + this.idField.Text + "','" + this.nameField.Text + "','" + this.descriptionField.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Refresh();
            MessageBox.Show("Successfully saved");
            dataGridView1.Refresh();
            conn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //UPDATE DATABASE
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            string query = "UPDATE category SET ID ='" + this.idField.Text + "', USERNAME ='" + this.nameField.Text + "', DESCRIPTION = '" + this.descriptionField.Text + "' WHERE ID ='" + this.idField.Text + "' ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Updated successfully ");
            conn.Close();

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from category ORDER BY id DESC", connection);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                da.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}