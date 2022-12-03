using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class Form7 : Form
    {
        private void Form7_Load(object sender, EventArgs e)
        {
        }

        public Form7()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please don't leave any textbox is empty");
                
                
            }
            else if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Passwords do not match!");
            }
            else
            {
                Class1.name = textBox1.Text;
                Class1.pass = textBox2.Text;
                this.Hide();
                Login ob = new Login();
                ob.Show();
            }
          

        }        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fer = new Login();
            fer.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void loginBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
    }

