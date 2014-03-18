using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AionCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Adder calc = new Adder();
            Answer.Text = calc.Calculate(first, second);
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Subtraction calc = new Subtraction();
            Answer.Text = calc.Calculate(first, second);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Multiplication calc = new Multiplication();
            Answer.Text = calc.Calculate(first, second);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            Division calc = new Division();
            Answer.Text = calc.Calculate(first, second);
        }
    }
}
