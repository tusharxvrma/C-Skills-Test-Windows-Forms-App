using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcqForms
{
    public partial class ques1 : Form
    {
        private Timer timer;
        private int remainingTime = 10;
        private List<string> wrongAnswers = new List<string>();
        public ques1()
        {
            InitializeComponent();

            UpdateTimerLabel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ques2 form3 = new ques2();


            form3.ShowDialog();
            this.Hide();
        }

        private void prgBar_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radBtnA3.Checked)
            {
                login.points += 20;
            }
            else
            {
                wrongAnswers.Add("Question 1"); 
            }
            btnSubmit.Enabled = false;
        }

        private void ques1_Load(object sender, EventArgs e)
        {
            prgBar.Minimum = 0;
            prgBar.Maximum = 100;
            prgBar.Value = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            UpdateTimerLabel();

            if (remainingTime <= 0)
            {
                btnSubmit.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void UpdateTimerLabel()
        {
            timerLabel.Text = $"Time remaining: {remainingTime} seconds";
        }
    }
}
