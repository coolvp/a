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
    public partial class Form4 : Form
    {
        public Form4()
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
            label7.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox3.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double area = 0;
            if (radioButton1.Checked)
            {
                double l = Convert.ToDouble(textBox1.Text);
                area = l * l;
            }
            else if (radioButton2.Checked)
            {
                double l = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                area = l * b;
            }
            else if (radioButton3.Checked)
            {
                double r = Convert.ToDouble(textBox3.Text);
                area = Math.PI * r * r;
            }
            else if (radioButton4.Checked)
            {
                double b = Convert.ToDouble(textBox4.Text);
                double h = Convert.ToDouble(textBox5.Text);
                area = 0.5 * b * h;
            }
            label8.Text = "Area = " + area.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label8.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
