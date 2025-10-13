using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int t, int startValue, int stopValue)
        {
            double product = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow(t, k) + 1.0 / (k + 1);
                product *= term;
            }

            return product;
        }
    }
}
