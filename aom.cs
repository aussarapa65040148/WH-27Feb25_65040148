using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string readtext = input1_TextBox.Text;
            string[] twonumbers = readtext.Split('x');
            double a, b, c;
            a = Convert.ToDouble(twonumbers[0]);
            b = Convert.ToDouble(twonumbers[1]);
            c = a * b;
            solution_label.Text = c.ToString();
            solution_textbox.Text = c.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
