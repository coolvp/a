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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sub;
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            sub = a - b;
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mul ;
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            mul = a * b;
            textBox3.Text = mul.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            int a , b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            sum = a + b;
            textBox3.Text = sum.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int div;
            int a, b;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            div = a/b;
            textBox3.Text = div.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x = 0;
            textBox1.Text = x.ToString();
            textBox2.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      }
}
