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

namespace MOVIEPROGRAM_THING
{
    public partial class Form1 : Form
    {
        private int current;
        private int Count;
        private Movie[] movies;
        struct Movie
        {
            public string Name;
            public string Creator;
            public int Rating;
            public string Revenue;
            public string Character;
            public string PictureBox;
        }

        public Form1()
        {
            InitializeComponent();
            current = 0;
            Count = 0;
            Currentlabel.Text = current.ToString();
            movies = new Movie[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Movies.txt"))
            {
                StreamReader inFIle = new StreamReader("Movies.txt");
                while (!inFIle.EndOfStream)
                {
                    string S = inFIle.ReadLine();
                    Movie p = Readmovie(S);
                    movies[Count] = p;
                    Count++;
                }
                inFIle.Close();
                ShowMovie(movies[0]);
            }
        }
        private Movie Readmovie(string s)
        {
            Movie p = new Movie();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Creator = fields[1];
            p.Rating = int.Parse(fields[2]);
            p.Revenue = fields[3];
            p.Character = fields[4];
            p.PictureBox = fields[5];

            return p;

        }
        private void Save()
        {
            string tmp = "";
            tmp += NametextBox.Text;
            tmp += "|";
            tmp += CreatortextBox.Text;
            tmp += "|";
            tmp += RatingUpDown.Value;
            tmp += "|";
            tmp += RevenuetextBox.Text;
            tmp += "|";
            tmp += CharactertextBox.Text;
            tmp += "|";
            tmp += pictureBox1.Image;
            movies[current] = Readmovie(tmp);

            StreamWriter outfile = new StreamWriter("Movies.txt");
            for (int i = 0; i < Count; i++)
            {
                outfile.WriteLine(MovieToString(movies[i]));
            }
            outfile.Close();
        }

        private string MovieToString(Movie p)
        {
            string retVal = "";
            DebugtextBox.Clear();
            retVal += p.Name;
            retVal += "|";
            retVal += p.Creator;
            retVal += "|";
            retVal += p.Rating;
            retVal += "|";
            retVal += p.Revenue;
            retVal += "|";
            retVal += p.Character;
            retVal += "|";
            retVal += pictureBox1;
            return retVal;
        }
        private void ShowMovie(Movie p)
        {
            NametextBox.Text = p.Name;
            CreatortextBox.Text = p.Creator;
            RatingUpDown.Value = p.Rating;
            RevenuetextBox.Text = p.Revenue;
            CharactertextBox.Text = p.Character;
            if(System.IO.File.Exists(p.PictureBox))
            {

            pictureBox1.Load(p.PictureBox);
            }
        }
        private void clear()
        {
            NametextBox.Text = "";
            CreatortextBox.Text = "";
            RatingUpDown.Value = 0;
            RevenuetextBox.Text = "";
            CharactertextBox.Text = "";
            pictureBox1.Image = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }

        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void Newbutton_Click_1(object sender, EventArgs e)
        {
            current = Count;
            Count++;
            clear();
        }

        private void Previousbutton_Click_1(object sender, EventArgs e)
        {
            if (current > 0)
            {
                Save();
                current--;
                Currentlabel.Text = current.ToString();
            }
            ShowMovie(movies[current]);
        }

        private void Lastbutton_Click_1(object sender, EventArgs e)
        {
            Save();
            current = Count - 1;
            Currentlabel.Text = current.ToString();
            ShowMovie(movies[current]);
        }

        private void Firstbutton_Click_1(object sender, EventArgs e)
        {
            Save();
            current = 0;
            Currentlabel.Text = current.ToString();
            ShowMovie(movies[current]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nextbutton_Click_1(object sender, EventArgs e)
        {
            if (current < Count - 1)
            {
                Save();
                current++;
                Currentlabel.Text = current.ToString();
            }
            ShowMovie(movies[current]);
        }
    }
}
