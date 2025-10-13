using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sums = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sums = sums * (Math.Pow(value, i) + 1 / (i + 1));
            }
            return sums;
        }
    }
}
