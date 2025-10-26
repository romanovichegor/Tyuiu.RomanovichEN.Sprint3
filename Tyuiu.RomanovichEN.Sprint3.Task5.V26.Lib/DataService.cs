using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RomanovichEN.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count1 = 0;
            for (int i =  startValue; i <stopValue;i++)
            {
                for (int j = 1; j <= startValue; j++)
                {
                    if (i % j == 0)
                    {
                        count1 += 1;
                    }
                }
            }
            return count1;
        }
    }
}
