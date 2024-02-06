using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_R_O_G_R_A_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Movie
        {
            public string Name;
            public string Creator;
            public string Rating;
            public string Revenue;
            public string CharacterActor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowMovie(Movie m)
        {
            NametextBox.Text = m.Name;
            CreatortextBox.Text = m.Creator;
            RatingtextBox.Text = m.Rating;
            RevenuetextBox.Text = m.Revenue;
            CharactertextBox.Text = m.CharacterActor;
        }
    }
}
