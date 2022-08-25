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

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
            MySqlDataAdapter data = new MySqlDataAdapter("SELECT DISTINCT NAME from category ", connection);
            DataTable da = new DataTable();
            data.Fill(da);
            comboBox1.DataSource = da;
            comboBox1.DisplayMember = "NAME";
            comboBox1.ValueMember = "NAME";
            comboBox1.SelectedIndex = -1;




           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
