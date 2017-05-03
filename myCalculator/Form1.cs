using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text = input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input += "1";
            this.textBox1.Text = input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
            this.textBox1.Text = input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
            this.textBox1.Text = input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input += "4";
            this.textBox1.Text = input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text = input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text = input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text = input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text = input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text = input;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            input += ".";
            this.textBox1.Text = input;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1, num2;

            operand2 = input;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                this.textBox1.Text = result.ToString();
            }
            if (operation == '-')
            {
                result = num1 - num2;
                this.textBox1.Text = result.ToString();

            }
            if (operation == '*')
            {
                result = num1 * num2;
                this.textBox1.Text = result.ToString();

            }
            if (operation == '/')
            {
                if (num2 == 0)
                    this.textBox1.Text = "Div/0!";
                else
                {
                    result = num1 / num2;
                    this.textBox1.Text = result.ToString();

                }
            }

            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
    }
}
