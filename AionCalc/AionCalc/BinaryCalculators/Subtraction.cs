namespace AionCalc.BinaryCalculators
{
    public class Subtraction : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result.ToString();
        }
    }
}
