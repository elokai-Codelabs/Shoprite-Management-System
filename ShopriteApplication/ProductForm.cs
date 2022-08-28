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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //ADD GOODS
            try
            {
                if (prodId.Text == "" || prodName.Text == "" || prodQty.Text == ""|| prodDate.Text == ""|| expDate.Text == "" || prodCb.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add category");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "INSERT INTO product(ID,NAME,QUANTITY,PRICE,PROD_DATE,EXP_DATE,CATEGORY) VALUES('" + this.prodId.Text + "','" + this.prodName.Text + "','" + this.prodQty.Text + "','" + this.prodPrice.Text + "','" + this.prodDate.Text + "','" + this.expDate.Text + "','" + this.prodCb.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Product successfully added");
                    conn.Close();
                   // populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        //DISPLAY CAREGORIES IN PRODUCT FORM
        public void fillcombo()
        {
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT NAME from category",conn);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name",typeof(string));
            dt.Load(dr);
            //FOR CATEGORY SELECTION
            prodCb.ValueMember = "Name";
            prodCb.DataSource = dt;

            conn.Close();
        }
                
        private void ProductForm_Load(object sender, EventArgs e)
        {
            //PUSH DB DATA TO GRIDVIEW START
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            String query = "select * FROM product";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            var ds = new DataSet();
            sda.Fill(ds);
            prodGridView.DataSource = ds.Tables[0];

            //PUSH DB DATA TO GRIDVIEW END

            conn.Close();
            fillcombo();
            

            //change date format
            prodDate.CustomFormat = "yyyy-MM-dd";
            expDate.CustomFormat = "yyyy-MM-dd";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UsersForm = new UsersForm();
            UsersForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CategoryForm = new CategoryForm();
            CategoryForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //UPDATE GOODS
            try
            {
                if (prodId.Text == "")
                {
                    MessageBox.Show("Select a product before you can Update ");

                }
                else if (prodId.Text == "" || prodName.Text == "" || prodQty.Text == "" || prodDate.Text == "" || expDate.Text == "" || prodCb.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add category");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "UPDATE product SET ID ='" + this.prodId.Text + "', NAME ='" + this.prodName.Text + "', QUANTITY = '" + this.prodQty.Text + "', PRICE = '" + this.prodPrice.Text + "', PROD_DATE = '" + this.prodDate.Text + "', EXP_DATE = '" + this.expDate.Text + "', CATEGORY = '" + this.prodCb.Text + "' WHERE ID ='" + this.prodId.Text + "' ";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn); 
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Product successfully Updated");
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
                if (String.IsNullOrEmpty(prodId.Text))
                {
                    MessageBox.Show("Please specify The ID you want to delete", "?", 0, MessageBoxIcon.Error);
                    prodId.Focus();
                    return;
                }
                
                if (MessageBox.Show("Are you sure you want to delete ?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //MessageBox.Show("Select a category before you can delete ");



                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "DELETE FROM product WHERE ID ='" + this.prodId.Text + "' ";
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
            prodId.Text = "";
            prodName.Text = "";
            prodQty.Text = "";
            prodDate.Text = "";
            expDate.Text = "";
            prodCb.Text = "";


        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId.Text = prodGridView.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = prodGridView.SelectedRows[0].Cells[0].Value.ToString();
            prodName.Text = prodGridView.SelectedRows[0].Cells[1].Value.ToString();
            prodQty.Text = prodGridView.SelectedRows[0].Cells[2].Value.ToString();
            prodDate.Text = prodGridView.SelectedRows[0].Cells[3].Value.ToString();
            expDate.Text = prodGridView.SelectedRows[0].Cells[4].Value.ToString();
            prodCb.Text = prodGridView.SelectedRows[0].Cells[5].Value.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                MySqlConnection mySqlConn = new MySqlConnection(connection);

                string search = textBox1.Text;
                MySqlCommand cmd = new MySqlCommand("select * from product where CONCAT(NAME,ID) like '%" + textBox1.Text + "%' ", mySqlConn);
                mySqlConn.Open();
                MySqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    prodId.Text = rd.GetValue(0).ToString();
                    prodName.Text = rd.GetValue(1).ToString();
                    prodQty.Text = rd.GetValue(2).ToString();
                    prodPrice.Text = rd.GetValue(3).ToString();
                    prodDate.Text = rd.GetValue(4).ToString();

                    expDate.Text = rd.GetValue(5).ToString();
                    prodCb.Text = rd.GetValue(6).ToString();
                    //rd.Close();
                    if (String.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        prodId.Text = "";
                        prodName.Text = "";
                        prodQty.Text = "";
                        prodDate.Text = "";
                        expDate.Text = "";
                        prodCb.Text = "";
                    }

                }
                else
                {
                    rd.Close();
                    textBox1.Clear();
                }
                //rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    
    }
}
