using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mcqForms
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            txtBoxID.Text = login.ID;
            txtBoxName.Text = login.name;
            txtBoxScore.Text = login.points.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\Karan\Desktop\mcqForms\userScores.txt"; 
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"Name: {login.name}, ID: {login.ID}, Score: {login.points}");
                }

                MessageBox.Show("User information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user information: {ex.Message}");
            }

            Application.Exit();
        }
    }
}
