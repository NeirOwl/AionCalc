namespace AionCalc.BinaryCalculators
{
    public class Multiplication : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result.ToString();
        }
    }
}
