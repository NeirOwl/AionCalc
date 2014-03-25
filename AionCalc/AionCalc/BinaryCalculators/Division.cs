namespace AionCalc.BinaryCalculators
{
    public class Division : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result.ToString();
        }
    }
}
