using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class MorseCode : Form
    {
        public MorseCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            morseCode(textBox1.Text);

             string morseEncode(char x)
            {            
                switch (x)
                {
                    case 'A':
                        return ".-";
                    case 'B':
                        return "-...";
                    case 'C':
                        return "-.-.";
                    case 'D':
                        return "-..";
                    case 'E':
                        return ".";
                    case 'F':
                        return "..-.";
                    case 'G':
                        return "--.";
                    case 'H':
                        return "....";
                    case 'I':
                        return "..";
                    case 'J':
                        return ".---";
                    case 'K':
                        return "-.-";
                    case 'L':
                        return ".-..";
                    case 'M':
                        return "--";
                    case 'N':
                        return "-.";
                    case 'O':
                        return "---";
                    case 'P':
                        return ".--.";
                    case 'Q':
                        return "--.-";
                    case 'R':
                        return ".-.";
                    case 'S':
                        return "...";
                    case 'T':
                        return "-";
                    case 'U':
                        return "..-";
                    case 'V':
                        return "...-";
                    case 'W':
                        return ".--";
                    case 'X':
                        return "-..-";
                    case 'Y':
                        return "-.--";
                    case 'Z':
                        return "--..";
                    case 'a':
                        return ".-";
                    case 'b':
                        return "-...";
                    case 'c':
                        return "-.-.";
                    case 'd':
                        return "-..";
                    case 'e':
                        return ".";
                    case 'f':
                        return "..-.";
                    case 'g':
                        return "--.";
                    case 'h':
                        return "....";
                    case 'i':
                        return "..";
                    case 'j':
                        return ".---";
                    case 'k':
                        return "-.-";
                    case 'l':
                        return ".-..";
                    case 'm':
                        return "--";
                    case 'n':
                        return "-.";
                    case 'o':
                        return "---";
                    case 'p':
                        return ".--.";
                    case 'q':
                        return "--.-";
                    case 'r':
                        return ".-.";
                    case 's':
                        return "...";
                    case 't':
                        return "-";
                    case 'u':
                        return "..-";
                    case 'v':
                        return "...-";
                    case 'w':
                        return ".--";
                    case 'x':
                        return "-..-";
                    case 'y':
                        return "-.--";
                    case 'z':
                        return "--..";
                    case ' ':
                        return "/";
                    case '1':
                        return ".----";
                    case '2':
                        return "..---";
                    case '3':
                        return "...--";
                    case '4':
                        return "....-";
                    case '5':
                        return ".....";
                    case '6':
                        return "-....";
                    case '7':
                        return "--...";
                    case '8':
                        return "---..";
                    case '9':
                        return "----.";
                    case '0':
                        return "-----";
                }
                return "";
            }

             void morseCode(string s)
            {
                String a;
                for (int i = 0; i < s.Length; i++)
                {
                    a = (morseEncode(s[i]));
                    textBox2.AppendText(a);
                }
            }

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu sen = new Menu();
            sen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = label4.Text;
            textBox2.Text = label5.Text;
        }
    }
}
