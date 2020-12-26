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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.Width = 224;
            this.Height = 447;
            this.StartPosition = FormStartPosition.CenterScreen;
            TrackableOn.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childForm);
            childpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 943;
                this.Height = 485;
                openChildForm(new Spambot());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 927;
                this.Height = 446;
                openChildForm(new Spambot());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Width = 943;
            this.Height = 447;
            this.StartPosition = FormStartPosition.CenterScreen;

            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 943;
                this.Height = 485;
                openChildForm(new Coinflip());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 927;
                this.Height = 446;
                openChildForm(new Coinflip());
            }
        }


        private void TrackableOn_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            TrackableOff.Show();
            TrackableOn.Hide();


        }

        private void TrackableOff_Click(object sender, EventArgs e)
        {
            TrackableOff.Hide();
            TrackableOn.Show();
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 235;
                this.Height = 485;
                openChildForm(new Coinflip());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 224;
                this.Height = 446;
                openChildForm(new Coinflip());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 235;
                this.Height = 485;
                openChildForm(new Coinflip());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 224;
                this.Height = 446;
                openChildForm(new Coinflip());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 943;
                this.Height = 485;
                openChildForm(new ShutDownTimer());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 927;
                this.Height = 446;
                openChildForm(new ShutDownTimer());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
            {
                this.Width = 943;
                this.Height = 485;
                openChildForm(new CreateErrorBox());
            }

            else if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Width = 927;
                this.Height = 446;
                openChildForm(new CreateErrorBox());
            }
        }
    }
}
