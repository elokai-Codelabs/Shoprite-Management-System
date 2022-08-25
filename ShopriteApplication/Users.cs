using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopriteApplication
{
    public partial class Users : Form
    {
        public Users()
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
            var SellingForm = new SellingForm();
            SellingForm.Show();
            this.Hide();
        }
    }
}
