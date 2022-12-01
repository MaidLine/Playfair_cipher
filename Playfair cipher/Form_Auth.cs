using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_cipher
{
    public partial class Form_Auth : Form
    {
        string Login = "Admin";
        string Password = "Admin";
        public Form_Auth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Inter_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == Login | textBox_Password.Text == Password)
            {
                Form_main form_Main = new Form_main();
                form_Main.Show();
                this.Hide();

            }
        }

        private void Form_Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
