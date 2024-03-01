using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string day = comboBox2.GetItemText(comboBox2.SelectedItem);
            string year = comboBox3.GetItemText(comboBox3.SelectedItem);
            string gender = radioButton4.Checked == true ? "Male" : "Female";

            string Lastname = textBox1.Text;
            string Firstname = textBox2.Text;
            string Middlename = textBox3.Text;

            MessageBox.Show("Student name: " + Firstname + " " + Middlename + " " + Lastname + "\nGender: " + gender + "\nDate of Birth: " + day + "/" + month + "/" + year);
        }
    }
}
