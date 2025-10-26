using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task5.V10.Lib
{
    public class DataService : ISprint3Task5V10
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2;j++)
                {
                    sum += (Math.Pow(x, 3) * j) + 2;
                }
            }
            return Math.Round(sum);
        }
    }
}
