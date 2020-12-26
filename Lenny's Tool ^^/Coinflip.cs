using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenny_s_Tool___
{
    public partial class Coinflip : Form
    {
        public Coinflip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int newNumber = generator.Next(0, 2);

            Randomizer.Text = newNumber.ToString();


            if (Randomizer.Text == "0")
            {
                Tails.Show();
                Head.Hide();
                TailsLose.Hide();
                HeadLose.Show();
            }

            else if (Randomizer.Text == "1")
            {
                Tails.Hide();
                Head.Show();
                TailsLose.Show();
                HeadLose.Hide();
            }
        }
    }
}
