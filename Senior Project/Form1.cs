using Senior_Project;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1

{
    public partial class CaesarCipher : Form
    {
        public int a;
        public CaesarCipher()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            String flip ="" + Enc(textBox1.Text, a); 
            textBox2.Text = flip;
        }

       
        public static string Enc(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
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
        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Project.Menu secondform = new Senior_Project.Menu();
            secondform.Show();
        }

        private void button2_Click(object sender, EventArgs e) //save
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "pdf| *.pdf| html|*.html|lua file|*.lua|text document | *.txt | video | *.mp4 | image | *.jpg";
            saveFileDialog1.Title = "save project";
            saveFileDialog1.ShowDialog();

            
            if (saveFileDialog1.FileName != "")  //Doenst work yet, saves a corrupt File
            {

                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();              

                fs.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e) //higher
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

        private void button2_Click_1(object sender, EventArgs e) //lower
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = label6.Text;
            textBox2.Text = label8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label8.Text = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}