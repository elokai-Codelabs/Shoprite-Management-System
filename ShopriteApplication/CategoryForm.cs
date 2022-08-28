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

        //ADD CATEGORY TO DATABASE
        {
                     
            try
            {
                if (idField.Text == "" || nameField.Text == ""|| descriptionField.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add category");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "INSERT INTO category(ID,NAME,DESCRIPTION) VALUES('" + this.idField.Text + "','" + this.nameField.Text + "','" + this.descriptionField.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully saved");
                    conn.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //UPDATE CATEGORY TO DATABASE
           
            try
            {
                if (idField.Text == "")
                {
                    MessageBox.Show("Select a category before you can Update ");

                }
                else if (idField.Text == "" || nameField.Text == "" || descriptionField.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can Update category");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "UPDATE category SET ID ='" + this.idField.Text + "', NAME ='" + this.nameField.Text + "', DESCRIPTION = '" + this.descriptionField.Text + "' WHERE ID ='" + this.idField.Text + "' ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Updated successfully ");
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void populate()
        {
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            String query = "select * FROM category";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            var ds =new DataSet();
            sda.Fill(ds);
            catGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                populate();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //DELETE CATEGORY FROM DATABASE
            try
            {
                if (idField.Text=="") { 
                    MessageBox.Show("Select a category before you can delete ");

                }
                else {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "DELETE FROM category WHERE ID ='" + this.idField.Text + "' ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Deleted successfully ");
                    conn.Close();
                }
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message);
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idField.Text = catGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameField.Text = catGridView.SelectedRows[0].Cells[1].Value.ToString();
            descriptionField.Text = catGridView.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            idField.Text = "";
            nameField.Text = "";
            descriptionField.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();
            ProductForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Users = new UsersForm();
            Users.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}