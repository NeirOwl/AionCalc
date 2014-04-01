using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AionCalc.BinaryCalculators;
using AionCalc.MonoCalculators;

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

        private void Calculator(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator(name);
            Answer.Text = calc.Calculate(first, second);
        }

        private void Addition_Click(object sender, EventArgs e)
        {
           Calculator("+");
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Calculator("-");
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Calculator("*");
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Calculator("/");
        }

        private void Xpowy_Click(object sender, EventArgs e)
        {
            Calculator("x^y");
        }

        private void Division_y_x__Click(object sender, EventArgs e)
        {
            Calculator("y/x");
        }

        private void MonoCalculator(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator(name);
            Answer.Text = calc.Calculate(first);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            MonoCalculator("cos");
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            MonoCalculator("sin");
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            MonoCalculator("tanh");
        }

        private void Pow_10_x__Click(object sender, EventArgs e)
        {
            MonoCalculator("10^x");
        }

        private void Multiplication_10_x__Click(object sender, EventArgs e)
        {
            MonoCalculator("10*x");
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            MonoCalculator("sqrtx");
        }

        private void Gradtorad_Click(object sender, EventArgs e)
        {
            MonoCalculator("gradtorad");
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            MonoCalculator("tan");
        }

        private void Exppowx_Click(object sender, EventArgs e)
        {
            MonoCalculator("exppowx");
        }

    }
}
