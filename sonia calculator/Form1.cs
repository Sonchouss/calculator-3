using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonia_calculator
{
    public partial class Form1 : Form
    {
        private int num;
        private char x;
        private bool f;
        private double p;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }


        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";


        }

        private void button10_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            x = '+';
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            x = '*';
            textBox1.Text = "";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            x = '/';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox1.Text);
            x = '-';
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (x == '+')
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + p);
            }
            else if (x == '*')
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * p);
            }

            else if (x == '-')
            {
                textBox1.Text = Convert.ToString(p - Convert.ToDouble(textBox1.Text));

            }
            else if (x == '/')
            {
                if (Convert.ToInt32(textBox1.Text) == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно");
                }
                else
                { textBox1.Text = Convert.ToString(p / Convert.ToDouble(textBox1.Text)); }
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


    }
}
