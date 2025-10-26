using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task4.V20.Lib
{
    public class DataService : ISprint3Task4V20
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (startValue=-5; startValue<=stopValue; startValue++)
            {
                if (startValue == 0)
                {
                    continue;
                }
                res *= (startValue/(Math.Cos(startValue)-startValue))+ 2.5;
                startValue++;
            }
            return Math.Round(res,3);
        }
    }
}
