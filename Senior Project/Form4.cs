using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String word = textBox1.Text;
            String keys = textBox2.Text;

            String key = Key(word, keys);
            String text = cipher(word, key);

            //String Answ = orig(text, key);
          
            
            textBox3.Text = text;
          
        }
        static String Key(String str, String key)
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

      
        static String cipher(String str, String key)
        {
            String cipText = "";

            for (int i = 0; i < str.Length; i++)
            {
                
                int x = (str[i] + key[i]) % 26;

                // convert into alphabet
                x += 'A';

                cipText += (char)(x);
            }
            return cipText;
        }

      
        static String orig(String cipText, String key)
        {
            String ori = "";

            for (int i = 0; i < cipText.Length && i < key.Length; i++)
            {
                
                int x = (cipText[i] - key[i] + 26) % 26;

                // convert into alphabet
                x += 'A';
                ori += (char)(x);
            }
            return ori;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Senior_Project.Menu secondform = new Senior_Project.Menu();
            secondform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = label5.Text;
            textBox2.Text = label6.Text;
            textBox3.Text = label7.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
    }

    

