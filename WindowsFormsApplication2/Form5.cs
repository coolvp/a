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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label6.Visible = false;
            textBox4.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double volume = 0;
            if (radioButton1.Checked)
            {
                double l = Convert.ToDouble(textBox1.Text);
                volume = l * l * l;
            }
            else if (radioButton2.Checked)
            {
                double h = Convert.ToDouble(textBox3.Text);
                double r = Convert.ToDouble(textBox4.Text);
                volume = Math.PI * r * r * h;
            }
            else if (radioButton3.Checked)
            {
                double l = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);
                volume = l * b * h;
            }
            label8.Text = "Volume = " + volume.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label8.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
