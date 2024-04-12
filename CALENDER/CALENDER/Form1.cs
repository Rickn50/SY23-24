using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CALENDER
{
    public enum Plans
    {
        Personal, Work, School, Vacation
    }
    public partial class Form1 : Form
    {
    NameValueCollection MyColl = new NameValueCollection();
    DateTime current;
        
        private int Current;
        private int Count;
        private Calender[] calenders;

        public Form1()
        {
            InitializeComponent();
            Current = 0;
            Count = 0;
            calenders = new Calender[50];
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            InformationtextBox.Text = MyColl[e.Start.ToShortDateString()];
            current = e.Start;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            {
                if (File.Exists("Calender.Txt"))
                {
                    StreamReader inFIle = new StreamReader("Calender.Txt");
                    while (!inFIle.EndOfStream)
                    {
                        string S = inFIle.ReadLine();
                        Calender c = JsonSerializer.Deserialize<Calender>(S);
                        calenders[Count] = c;
                        Count++;
                    }
                    inFIle.Close();
                    ShowCalender(calenders[0]);
                }
                else
                {
                    Calender c = new Calender();
                    c.Information = "";
                    c.planType = (Plans)Enum.Parse(typeof(Plans), "Personal");
                    c.Important = true;
                    Count = 1;
                    calenders[0] = c;
                }
               
            }
            */

        }

        public void Save()
        {
            UpdateCalender();
            StreamWriter outfile = new System.IO.StreamWriter("Calender.txt");
            for (int i = 0; i < Count; i++)
            {
                string JsonString = JsonSerializer.Serialize(calenders[i]);
                outfile.WriteLine(JsonString);
                Calender c = ReadCalender(JsonString);
            }
            outfile.Close();
        }

        public void UpdateCalender()
        {
            Calender c = calenders[Current];
            if (c != null)
            {
                c.Information = InformationtextBox.Text;
                c.planType = (Plans)Enum.Parse(typeof(Plans), DayOptionscomboBox.Text);
                if (ImportantcheckBox.Checked)
                    c.Important = true;
                else
                    c.Important = false;
                MyColl[current.ToShortDateString()] = JsonSerializer.Serialize<Calender>(c);
            }

        }
        private Calender ReadCalender(string s)
        {
            Calender c = JsonSerializer.Deserialize<Calender>(s);
            return c;

        }

        private void ShowCalender(Calender c)
        {
            if (c != null)
            {
                InformationtextBox.Text = c.Information;
                DayOptionscomboBox.Text = c.planType.ToString();
                ImportantcheckBox.Checked = c.Important;
            }
        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            Save();
            MyColl.Add(current.ToShortDateString(), InformationtextBox.Text);
            InformationtextBox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Calender c = new Calender();
            c.Information = "";
            c.planType = (Plans)Enum.Parse(typeof(Plans), "Personal");
            c.Important = true;
            Count = 1;
            calenders[0] = c;
        }

        private void AddToListbutton_Click(object sender, EventArgs e)
        {
            foreach (var item in MyColl)
            {
                listBox1.Items.Add(item);
            }
        }
    }
    class Calender
    {
        public string Information { get; set; }
        public Plans planType { get; set; }
        public bool Important { get; set; }

        public int day { get; set; }
    }
}
