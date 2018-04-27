using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists("username.txt"))
            {
                using (StreamReader streamReader = new StreamReader("username.txt"))
                {
                    UsernameTextBox.Text = streamReader.ReadLine();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((UsernameTextBox.Text == "admin") && (PasswordTextBox.Text == "password"))
            {
                using (StreamWriter streamwriter = new StreamWriter("username.txt"))
                {
                    streamwriter.WriteLine(UsernameTextBox.Text);
                }   
                ;
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login details are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UsernameTextBox.Clear();
                PasswordTextBox.Clear();

                UsernameTextBox.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
