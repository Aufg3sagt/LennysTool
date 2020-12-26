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
    public partial class Spambot : Form
    {
        public Spambot()
        {
            InitializeComponent();
        }

        private void SpamBotTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{Enter}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpamBotTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpamBotTimer.Stop();
        }
    }
}
