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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);
            int sum = 0;

            Odd.Items.Clear();
            Even.Items.Clear();
            Prime.Items.Clear();

            for (int i = start; i <= end; i++)
            {
                sum += i;
                if (i % 2 == 0)
                {
                    Even.Items.Add(i);
                }
                else
                {
                    Odd.Items.Add(i);
                }

                if (IsPrime(i))
                    Prime.Items.Add(i);
            }
            label3.Text = "Sum + " + sum;
        }

        private void Odd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Even_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Odd.Items.Clear();
            Even.Items.Clear();
            Prime.Items.Clear();
            label3.Text = "";

        }
    }
}
