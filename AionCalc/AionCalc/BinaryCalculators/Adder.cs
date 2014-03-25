namespace AionCalc.BinaryCalculators
{
    public class Adder : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            return result.ToString();
        }
    }
}
