using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collection_practice
{
    public partial class Form1 : Form
    {
        NameValueCollection MyColl = new NameValueCollection();
        DateTime current;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = MyColl[e.Start.ToShortDateString()];
            current = e.Start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyColl.Add(current.ToShortDateString(), textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in MyColl)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
