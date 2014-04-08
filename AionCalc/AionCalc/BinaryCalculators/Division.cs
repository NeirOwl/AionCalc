namespace AionCalc.BinaryCalculators
{
    public class Division : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}
