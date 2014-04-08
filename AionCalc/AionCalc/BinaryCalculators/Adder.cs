namespace AionCalc.BinaryCalculators
{
    public class Adder : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            return result;
        }
    }
}
