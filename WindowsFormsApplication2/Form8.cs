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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);

            Result.Items.Clear();

            for (int i = end; i >= start; i--)
            {
                Result.Items.Add(i);
            }
        }
    }
}
