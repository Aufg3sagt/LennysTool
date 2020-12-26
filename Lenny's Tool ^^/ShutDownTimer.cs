using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lenny_s_Tool___
{
    public partial class ShutDownTimer : Form

    {
        TimeSpan timeLeft;
        public ShutDownTimer()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckTextBoxValues();
            bool isStartable = true;

            try
            {
                timeLeft = new TimeSpan(Convert.ToInt32(Hours.Text), Convert.ToInt32(Mins.Text), Convert.ToInt32(Secs.Text));
            }

            catch (FormatException)
            {
                isStartable = false;
                MessageBox.Show("False Format!");
            }

            if (isStartable == true)
            {
                ShutDownTm.Start();
                lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");

            }

        }
        private void CheckTextBoxValues()
        {
            if (Hours.Text.Count() == 0)
                Hours.Text = "0";

            if (Mins.Text.Count() == 0)
                Mins.Text = "0";

            if (Secs.Text.Count() == 0)
                Secs.Text = "0";
        }

        private void ShutDownTm_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            lblTimer.Text = timeLeft.ToString(@"hh\:mm\:ss");
            
            if (timeLeft.TotalSeconds <= 0)
            {
                ShutDownTm.Stop();
                PerformAction();
            }
        }

        private void PerformAction()
        {
            Process.Start("shutdown", "/s");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShutDownTm.Stop();
        }
    }
}
