using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Senior_Project
{
    public partial class Form9 : Form
    {
        
        int randValue;
        
        
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            Random random= new Random();
            
            int stringlen = rand.Next(10, 18);
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                randValue = rand.Next(0, 26);

             
                letter = Convert.ToChar(randValue + 65);

                str = str + letter;
            }
            int detr;
                detr = random.Next(0, 9);
            label5.Text = str;
            
            if(detr == 1)
            {
                label4.Text = 1 + "";
            }
            else if (detr == 2)
            {
                label4.Text = 2 + "";
            }
            else if (detr == 3)
            {
                label4.Text = 3 + "";
            }
            else if (detr == 4)
            {
                label4.Text = 4 + "";
            }
            else if (detr == 5)
            {
                label4.Text = 5 + "";
            }
            else if (detr == 6)
            {
                label4.Text = 6 + "";
            }
            else if (detr == 7)
            {
                label4.Text = 7 + "";
            }
            else if (detr == 8)
            {
                label4.Text = 8 + "";
            }
            else if (detr == 9)
            {
                label4.Text = 9 + "";
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int send;
            
          send =  Int16.Parse(label4.Text);
           
            String de = Dec(label5.Text, send);
            label7.Text = de;

        }
        public static char cipher(char s, int key)
        {
            if (!char.IsLetter(s))
            {
                return s;
            }
            char d = char.IsUpper(s) ? 'A' : 'a';
            return (char)((((s + key) - d) % 26) + d);
        }


        public static string Enc(string input, int key)
        {
            string output = string.Empty;

            foreach (char a in input)
                output += cipher(a, key);

            return output;
        }

        public static string Dec(string input, int key)
        {
            return Enc(input, 26 - key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu go = new Menu();
            go.Show();
        }
    }
    }

