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
            label1.Text = "Первый аргумент";
            label2.Text = "Второй аргумент";
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

        private void Calculator(string name)
        {
            double first = Convert.ToDouble(FirstArgument.Text);
            double second = Convert.ToDouble(SecondArgument.Text);
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator(name);
            Answer.Text = calc.Calculate(first, second);
        }
    }
}
