using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;
            double y, cosx, den;
            for (; startValue<=stopValue; startValue+=1)
            {
                if (startValue == 0)
                {
                    continue;
                }
                cosx = Math.Cos(startValue);
                den = cosx - startValue;
                if (den != 0)
                {
                    y = (startValue / den) + 2.5;
                    res *= y;
                }
            }
            return Math.Round(res,3);
        }
    }
}
