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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        String query;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string role;

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            loginPaasword.Text = "";
            loginUser.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            var ResetPasswordForm = new ResetPasswordForm();
            ResetPasswordForm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login();
        }
        public void Login()
        {
            if (string.IsNullOrWhiteSpace(loginUser.Text)){
                MessageBox.Show("Input your username", "Username Required", 0, MessageBoxIcon.Warning);
                loginUser.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(loginPaasword.Text))
            {
                MessageBox.Show("Input your Password", "Password Required", 0, MessageBoxIcon.Warning);
                loginPaasword.Focus();
                return;

            }
            else
            {
                try
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    MySqlConnection conn = new MySqlConnection(connection);

                    //selecting from the table and comparing values in textboxes to values in table
                    conn.Open();
                    query = "SELECT * FROM users WHERE USERNAME = @uname  and  PASSWORD = @upass";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uname", loginUser.Text);
                    cmd.Parameters.AddWithValue("@upass", loginPaasword.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        if (dr.Read())
                        {

                            role = dr.GetValue(5).ToString();
                            if (dt.Rows.Count > 0 && role == "ADMIN")
                            {
                                MessageBox.Show("Login Successful!", "Success", 0, MessageBoxIcon.Information);
                                var main = new Dashboard();
                                main.Show();
                                //main.bunifuLabel2.Text = gunaLineTextBox1.Text;
                                //main.bunifuLabel3.Text = role;

                                //Byte[] data = new Byte[0];
                                //data = (Byte[])dr.GetValue(7);
                                //MemoryStream mem = new MemoryStream(data);
                                //main.bunifuPictureBox2.Image = Image.FromStream(mem);

                                this.Hide();
                            }
                            else if (dt.Rows.Count > 0 && role == "ATTENDANT")
                            {
                                MessageBox.Show("Login Successful!", "Success", 0, MessageBoxIcon.Information);
                                var main = new CategoryForm();
                                main.Show();
                                //main.bunifuLabel2.Text = gunaLineTextBox1.Text;
                                //main.bunifuLabel3.Text = role;
                                //main.bunifuButton5.Enabled = false;
                                //Byte[] data = new Byte[0];
                                //data = (Byte[])dr.GetValue(7);
                                //MemoryStream mem = new MemoryStream(data);
                                //main.bunifuPictureBox2.Image = Image.FromStream(mem);

                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Please enter Correct Username and Password", "Error", 0, MessageBoxIcon.Information);

     
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Error", 0, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("THE FOLLOWING ERROR OCCURED " + ex.Message);
                }
               
            }

        }

        private void loginUser_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
