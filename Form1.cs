using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        float n1 = 0;
        float n2 = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox2.Text = "+";
            op = "soma";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox2.Text = "-";
            op = "sub";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n2 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox2.Text = "";
            if (op == "soma")
            {
                textBox1.Text = Convert.ToString(n1 + n2);
            }
            else if (op == "sub")
            {
                textBox1.Text = Convert.ToString(n1 - n2);
            }
            else if (op == "div")
            {
                textBox1.Text = Convert.ToString(n1 / n2);
            }
            else
            {
                textBox1.Text = Convert.ToString(n1 * n2); 
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox2.Text = "x";
            op = "mult";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox2.Text = "÷";
            op = "div";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            float n1 = 0;
            float n2 = 0;
            string op = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
