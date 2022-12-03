using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Senior_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //caesar Cipher
        {
            CaesarCipher fro = new CaesarCipher();
            this.Hide();
            fro.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Block Cipher
        {
            this.Hide();
            MorseCode mcc = new MorseCode();
            mcc.Show(); 

        }

        private void button3_Click(object sender, EventArgs e) //Long poly cipher
        {
            this.Hide();
            Senior_Project.Form4 secondform = new Senior_Project.Form4();
            secondform.Show();
        }

        private void button4_Click(object sender, EventArgs e) // daily challenege
        {
            Form9 DC = new Form9();
            this.Hide();
            DC.Show();
        }

        private void button5_Click(object sender, EventArgs e) // saved
        {
            Form8 Save = new Form8();
            this.Hide();
            Save.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            this.Hide();
            logout.Show();
        }
    }
}
