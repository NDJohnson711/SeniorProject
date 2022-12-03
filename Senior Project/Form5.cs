using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Senior_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int a;

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CaesarCipher send = new CaesarCipher();
            send.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String de = Dec(textBox1.Text, a);
            textBox2.Text = de;
        }
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Enci(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Dec(string input, int key)
        {
            return Enci(input, 26 - key);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a >= 9)
            {
                a = 9;
                label5.Text = "Cannot Go Higher";
            }
            else
            {
                label5.Text = "";
                a++;
                label4.Text = a.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a <= 0)
            {
                a = 0;
                label5.Text = "Cannot Go Lower";
            }
            else
            {
                label5.Text = "";
                a--;
                label4.Text = a.ToString();
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Project.Menu secondform = new Senior_Project.Menu();
            secondform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = label6.Text;
            textBox2.Text = label7.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
