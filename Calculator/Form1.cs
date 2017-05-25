using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int x = 0;
        string sum;
        bool state = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += "0";
        }

        double number1;

        private void plus_Click(object sender, EventArgs e)
        {
            x = 1;
            number1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                double number2 = Convert.ToInt32(richTextBox1.Text);
                if (x == 1)
                {
                    sum = Convert.ToString(number1 + number2);
                }
                else if (x == 2)
                {
                    sum = Convert.ToString(number1 - number2);
                }
                else if (x == 3)
                {
                    sum = Convert.ToString(number1 * number2);
                }
                else if (x == 4)
                {
                    sum = Convert.ToString(number1 / number2);
                }
                else
                {

                }
                richTextBox1.Text = sum;
                state = true;
            }
            catch
            {


            }
        }

        public void testFor()
        {
            if (state == true) {
                richTextBox1.Clear();
                state = false;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            x = 3;
            number1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            x = 2;
            number1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            x = 4;
            number1 = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            if (text.Length == 0) { }
            else {
                richTextBox1.Text = text.Remove(text.Length - 1, 1);
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            x = 5;
            number1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            double sro = Math.Sqrt(number1);
            sum = Convert.ToString(sro);
            richTextBox1.Text = sum;
            state = true;
        }

        private void squared_Click(object sender, EventArgs e)
        {
            x = 5;
            number1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            sum = Convert.ToString(number1 * number1);
            richTextBox1.Text = sum;
            state = true;
        }

        private void comma_Click(object sender, EventArgs e)
        {
            testFor();
            richTextBox1.Text += ",";
        }
    }
}
