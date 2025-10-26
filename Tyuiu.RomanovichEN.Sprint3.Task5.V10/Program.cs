using Tyuiu.RomanovichEN.Sprint3.Task5.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #3 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("Введите x:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значения start1,start2,stop1,stop2:");
        int start1 = Convert.ToInt32(Console.ReadLine());
        int start2 = Convert.ToInt32(Console.ReadLine());
        int stop1 = Convert.ToInt32(Console.ReadLine());
        int stop2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumSumSeries(x,start1,start2,stop1,stop2));
    }
}