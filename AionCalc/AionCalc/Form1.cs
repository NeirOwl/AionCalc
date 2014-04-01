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

        private void Sqrtpowyx_Click(object sender, EventArgs e)
        {
            Calculator("sqrtpowyx");
        }

        private void Tenmultiplyxdivisiony_Click(object sender, EventArgs e)
        {
            Calculator("10*x/y");
        }

        private void Log_Click(object sender, EventArgs e)
        {
            Calculator("log");
        }

        private void Twomultiplyxdivisiony_Click(object sender, EventArgs e)
        {
            Calculator("2*x/y");
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
            MonoCalculator("e^x");
        }

        private void Twodivisionx_Click(object sender, EventArgs e)
        {
            MonoCalculator("2/x");
        }

        private void Sqrtpow3x_Click(object sender, EventArgs e)
        {
            MonoCalculator("sqrtpow3x");
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            MonoCalculator("x!");
        }

        private void Tendivisionx_Click(object sender, EventArgs e)
        {
            MonoCalculator("10/x");
        }

        private void Xpow3_Click(object sender, EventArgs e)
        {
            MonoCalculator("x^3");
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            MonoCalculator("sinh");
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            MonoCalculator("cosh");
        }

        private void Lg_Click(object sender, EventArgs e)
        {
            MonoCalculator("lg");
        }

        private void Ln_Click(object sender, EventArgs e)
        {
            MonoCalculator("ln");
        } 

    }
}
