using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            do
            { 
                res +=(Math.Pow(value, startValue) + 2 / (startValue + 1)) * Math.Sin(value);
                 startValue++;
            } while ( startValue <  stopValue );
            return Math.Round(res,3);
        }
    }
}
