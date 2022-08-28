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
    public partial class ShoppingForm : Form
    {
        public ShoppingForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }
    }
}
