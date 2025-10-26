using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            double sum = 0;
            do
            {
                sum += Math.Pow(value, startValue) + (2.0 / (startValue + 1));
                startValue++;
            } while ( startValue <=  stopValue );
            res = sum * Math.Sin(value);
            return Math.Round(res,3);
        }
    }
}
