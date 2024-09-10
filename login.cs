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
    public partial class login : Form
    {
        public static int points { get; set; } = 0;
        public static string name { get; set; }
        public static string ID { get; set; }

        int counter = 0;
        public login()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string password = "4seneca";
            string passwd = txtBoxPass.Text;

            if (txtBoxName.Text == "" && txtBoxID.Text == "")
            {
                MessageBox.Show("Personal Information is missing, Exiting application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            else if (passwd == password)
            {
                name = txtBoxName.Text;
                ID = txtBoxID.Text;
                ques1 form2 = new ques1();
                form2.ShowDialog();
                this.Hide();
            }

            else
            {
                counter++;

                if (counter >= 3)
                {
                    MessageBox.Show("Incorrect password limit reached. Exiting application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxPass.Clear();
                    txtBoxPass.Focus();
                }
            }
        }
    }
}
