using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DECODER2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    label1.Text += "!";
                    break;
                case 'b':
                    label1.Text += "@";
                    break;
                case 'c':
                    label1.Text += "#";
                    break;
                case 'd':
                    label1.Text += "$";
                    break;
                case 'e':
                    label1.Text += "%";
                    break;
                case 'f':
                    label1.Text += "^";
                    break;
                case 'g':
                    label1.Text += "&";
                    break;
                case 'h':
                    label1.Text += "*";
                    break;
                case 'i':
                    label1.Text += "(";
                    break;
                case 'j':
                    label1.Text += ")";
                    break;
                case 'k':
                    label1.Text += "~";
                    break;
                case 'l':
                    label1.Text += "-";
                    break;
                case 'm':
                    label1.Text += "_";
                    break;
                case 'n':
                    label1.Text += "+";
                    break;
                case 'o':
                    label1.Text += "=";
                    break;
                case 'p':
                    label1.Text += "{";
                    break;
                case 'q':
                    label1.Text += "}";
                    break;
                case 'r':
                    label1.Text += "?";
                    break;
                case 's':
                    label1.Text += "|";
                    break;
                case 't':
                    label1.Text += "<";
                    break;
                case 'u':
                    label1.Text += ">";
                    break;
                case 'v':
                    label1.Text += ":";
                    break;
                case 'w':
                    label1.Text += ";";
                    break;
                case 'x':
                    label1.Text += "'";
                    break;
                case 'y':
                    label1.Text += "[";
                    break;
                case 'z':
                    label1.Text += "]";
                    break;




                    /*if (e.KeyChar == 'a')
                        label1.Text += "1";
                    else
                        label1.Text += e.KeyChar.ToString();*/
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '!':
                    label2.Text += "a";
                    break;
                case '@':
                    label2.Text += "b";
                    break;
                case '#':
                    label2.Text += "c";
                    break;
                case '$':
                    label2.Text += "d";
                    break;
                case '%':
                    label2.Text += "e";
                    break;
                case '^':
                    label2.Text += "f";
                    break;
                case '&':
                    label2.Text += "g";
                    break;
                case '*':
                    label2.Text += "h";
                    break;
                case '(':
                    label2.Text += "i";
                    break;
                case ')':
                    label2.Text += "j";
                    break;
                case '~':
                    label2.Text += "k";
                    break;
                case '-':
                    label2.Text += "l";
                    break;
                case '_':
                    label2.Text += "m";
                    break;
                case '+':
                    label2.Text += "n";
                    break;
                case '=':
                    label2.Text += "o";
                    break;
                case '{':
                    label2.Text += "p";
                    break;
                case '}':
                    label2.Text += "q";
                    break;
                case '?':
                    label2.Text += "r";
                    break;
                case '|':
                    label2.Text += "s";
                    break;
                case '<':
                    label2.Text += "t";
                    break;
                case '>':
                    label2.Text += "u";
                    break;
                case ':':
                    label2.Text += "v";
                    break;
                case ';':
                    label2.Text += "w";
                    break;
                case '.':
                    label2.Text += "x";
                    break;
                case '[':
                    label2.Text += "y";
                    break;
                case ']':
                    label2.Text += "z";
                    break;
            }
        }
    }
}
