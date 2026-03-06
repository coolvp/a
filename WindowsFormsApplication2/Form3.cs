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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Si, p, r, n;
            p = Convert.ToDouble(textBox1.Text);
            r = Convert.ToDouble(textBox2.Text);
            n = Convert.ToDouble(textBox3.Text);
            Si = p * r * n / 100;
            textBox4.Text = Si.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
