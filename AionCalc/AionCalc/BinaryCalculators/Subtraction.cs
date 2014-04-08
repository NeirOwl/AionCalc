namespace AionCalc.BinaryCalculators
{
    public class Subtraction : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }
    }
}
