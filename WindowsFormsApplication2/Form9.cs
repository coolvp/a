using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int per = Convert.ToInt32(textBox2.Text);
            string grade = "";

            switch (per / 10)
            {
                case 10:
                case 9:
                case 8:
                    grade = "Distinction";
                    break;
                case 7:
                case 6:
                    grade = "First Class";
                    break;
                case 5:
                    grade = "Second Class";
                    break;
                case 4:
                    grade = "Pass";
                    break;
                default:
                    grade = "Fail";
                    break;
            }
            label3.Text = "Name: " + name + "\nGrade: " + grade;
        }
    }
}
