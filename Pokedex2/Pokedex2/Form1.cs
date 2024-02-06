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
        private int current;
        private int Count;
        private Pokemon[] pokemons;

        enum attack
        {
            Special_Attack, Special_Defense, Attack, Defense
        }
        struct Pokemon
        {
            public string Name;
            public string type;
            public int level;
            public int HP;
            public int EXP;
            public int Generation;
            public attack attacktype;
            public bool Legendary;
            public bool Shiny;
        }

        public Form1()
        {
            InitializeComponent();
            current = 0;
            Count = 0;
            Currentlabel.Text = current.ToString();
            pokemons = new Pokemon[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.Txt"))
            {
                StreamReader inFIle = new StreamReader("Pokemon.Txt");
                while (!inFIle.EndOfStream)
                {
                    string S = inFIle.ReadLine();
                    Pokemon p = ReadPokemon(S);
                    pokemons[Count] = p;
                    Count++;
                }
                inFIle.Close();
                ShowPokemon(pokemons[0]);
            }
        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.type = fields[1];
            p.level = int.Parse(fields[2]);
            p.HP = int.Parse(fields[3]);
            p.EXP = int.Parse(fields[4]);
            p.Generation = int.Parse(fields[5]);
            p.attacktype = (attack)Enum.Parse(typeof(attack), fields[6]);
            if (fields[7] == "True")
                p.Legendary = true;
            else
                p.Legendary = false;

            if (fields[8] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;

            return p;

        }
        private void Save()
        {
            string tmp = "";
            DebugBox.Clear();
            tmp += NameTextBox.Text;
            tmp += "|";
            tmp += TypeTextBox.Text;
            tmp += "|";
            tmp += LevelUpDown.Value;
            tmp += "|";
            tmp += HPUpDown.Value;
            tmp += "|";
            tmp += EXPUpDown.Value;
            tmp += "|";
            tmp += GenerationUpDown.Value;
            tmp += "|";
            tmp += AttackCombo.Text;
            tmp += "|";
            tmp += Legendarycheck.Checked;
            tmp += "|";
            tmp += Shinycheck.Checked;
            tmp += "|";
            pokemons[current] = ReadPokemon(tmp);

            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            for (int i= 0; i < Count; i++)
            {
                outfile.WriteLine(PokemonToString(pokemons[i]));
            }
            outfile.Close();
        }

        private string PokemonToString(Pokemon p)
        {
            string retVal = "";
            retVal += p.Name.ToString();
            retVal +=
            retVal += p.type.ToString();
            retVal +=
            retVal += p.level.ToString();
            retVal +=
            retVal += p.HP.ToString();
            retVal +=
            retVal += p.EXP.ToString();
            retVal +=
            retVal += p.Generation.ToString();
            retVal +=
            retVal += p.attacktype.ToString();
            retVal +=
            retVal += p.Legendary.ToString();
            retVal +=
            retVal += p.Shiny.ToString();
            return retVal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save();

        }
        private void ShowPokemon(Pokemon p)
        {
            NameTextBox.Text = p.Name;
            TypeTextBox.Text = p.type;
            LevelUpDown.Value = p.level;
            HPUpDown.Value = p.HP;
            EXPUpDown.Value = p.EXP;
            GenerationUpDown.Value = p.Generation;
            AttackCombo.Text = p.attacktype.ToString();
            Legendarycheck.Checked = p.Legendary;
            Shinycheck.Checked = p.Shiny;
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            Save();
            current = 0;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            Save();
            current = Count-1;
            Currentlabel.Text = current.ToString();
            ShowPokemon(pokemons[current]);

        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
            Save();
            current--;
            Currentlabel.Text = current.ToString();
            }
            ShowPokemon(pokemons[current]);

        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if (current < Count -1)
            {
            Save();
                current++;
                Currentlabel.Text = current.ToString();
            }
            ShowPokemon(pokemons[current]);

        }
        private void clear()
        {
            NameTextBox.Text = "";
            TypeTextBox.Text = "";
            LevelUpDown.Value = 0;
            HPUpDown.Value = 0;
            EXPUpDown.Value = 0;
            GenerationUpDown.Value = 0;
            AttackCombo.Text = "";
            Legendarycheck.Checked = false;
            Shinycheck.Checked = false;
        }
        private void Newbutton_Click(object sender, EventArgs e)
        {
            current = Count;
            Count++;
            clear();
        }

        private void DebugBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
