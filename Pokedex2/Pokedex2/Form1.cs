using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2
{
    public partial class Form1 : Form
    {
        enum attack
        {
            Special_Attack,Special_Defense,Attack,Defense
        }
        struct Struct
        {
            string type;
            int level;
            attack attacktype;
            int HP;
            int EXP;
            bool Legendary;
            bool Shiny;
            int Generation;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.Txt"))
            {
                StreamReader inFIle = new StreamReader("Pokemon.Txt");
                string S = inFIle.ReadToEnd();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebugBox.Clear();
            DebugBox.Text += NameTextBox.Text;
            DebugBox.Text += " | ";
            DebugBox.Text += TypeTextBox.Text;
            DebugBox.Text += " | ";
            DebugBox.Text += LevelUpDown.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += HPUpDown.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += EXPUpDown.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += GenerationUpDown.Value;
            DebugBox.Text += " | ";
            DebugBox.Text += AttackCombo.Text;
            DebugBox.Text += " | ";
            if (Legendarycheck.Checked == true)
            {
                DebugBox.Text += Legendarycheck.Text;
            }
            if (Shinycheck.Checked == true)
            {
                DebugBox.Text += Shinycheck.Text;
            }

        }
    }
}
