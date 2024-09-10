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
    public partial class ques3 : Form
    {
        private Timer timer;
        private int remainingTime = 10;
        private List<string> wrongAnswers = new List<string>();
        public ques3()
        {
            InitializeComponent();

            UpdateTimerLabel();
        }

        private void ques3_Load(object sender, EventArgs e)
        {
            prgBar.Minimum = 0;
            prgBar.Maximum = 100;
            prgBar.Value = 60;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radBtnA3.Checked)
            {
                login.points += 20;
            }
            else
            {
                wrongAnswers.Add("Question 3");
            }
            btnSubmit.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ques4 form5 = new ques4();

            form5.ShowDialog();
            this.Hide();

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
