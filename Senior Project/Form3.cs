using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Senior_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
      

        public void ChackUserPass_Click(object sender, EventArgs e)
        {                 
            if (textBox1.Text == Class1.name && textBox2.Text == Class1.pass)
            {            
                    this.Hide();
                    Menu sen = new Menu();
                    sen.Show();
            }
            
            else 
            {
                label4.Text = "Incorrect Username/Password";
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 create = new Form7();
            create.Show();
        }
    }
}
