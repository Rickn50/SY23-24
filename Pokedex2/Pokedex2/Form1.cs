using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2
{

    public partial class Form1 : Form
    {
        private int current;
        private int Count;
        private Pokemon[] pokemons;



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
                    Pokemon p = JsonSerializer.Deserialize<Pokemon>(S);
                    pokemons[Count] = p;
                    Count++;
                }
                inFIle.Close();
                ShowPokemon(pokemons[0]);
            }
            else
            {
                Pokemon p = new Pokemon();
                p.Name = "Pikachu";
                p.type = "Lighting";
                p.level = 50;
                p.HP = 100;
                p.EXP = 10;
                p.Generation = 2;
                p.attacktype = attack.Attack;
                p.Legendary = false;
                p.Shiny = true;
                Count = 1;
                pokemons[0] = p;
            }
        }

        public void Save()
        {
            UpdatePokemon();
            StreamWriter outfile = new System.IO.StreamWriter("Pokemon.txt");
            for (int i = 0; i < Count; i++)
            {
                string JsonString = JsonSerializer.Serialize(pokemons[i]);
                outfile.WriteLine(JsonString);
                Pokemon p = ReadPokemon(JsonString);
            }
            outfile.Close();
        }

        public void UpdatePokemon()
        {
            Pokemon p = pokemons[current];
            if (p != null)
            {
                p.Name = NameTextBox.Text;
                p.type = TypeTextBox.Text;
                p.level = int.Parse(LevelUpDown.Value.ToString());
                p.attacktype = (attack)Enum.Parse(typeof(attack), AttackCombo.Text);
                p.HP = int.Parse(HPUpDown.Value.ToString());
                p.EXP = int.Parse(EXPUpDown.Value.ToString());
                if (Legendarycheck.Checked)
                    p.Legendary = true;
                else
                    p.Legendary = false;
                if (Shinycheck.Checked)
                    p.Shiny = true;
                else
                    p.Shiny = false;
                p.Generation = int.Parse(GenerationUpDown.Value.ToString());
            }

        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = JsonSerializer.Deserialize<Pokemon>(s);
            return p;

        }

        /*private void Save()
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
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Save();

        }
        private void ShowPokemon(Pokemon p)
        {
            if (p != null)
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
            current = Count - 1;
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
            if (current < Count - 1)
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
            pokemons[current] = new Pokemon();
            Count++;
            clear();
        }

        private void DebugBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePokemon();
            Save();
        }
    }
    public enum attack
    {
        Special_Attack, Special_Defense, Attack, Defense
    }
    class Pokemon
    {
        public string Name { get; set; }
        public string type { get; set; }
        public int level { get; set; }
        public int HP { get; set; }
        public int EXP { get; set; }
        public int Generation { get; set; }
        public attack attacktype { get; set; }
        public bool Legendary { get; set; }
        public bool Shiny { get; set; }
    }
}
