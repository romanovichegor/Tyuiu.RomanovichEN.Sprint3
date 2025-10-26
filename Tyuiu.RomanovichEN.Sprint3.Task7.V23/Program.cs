using Tyuiu.RomanovichEN.Sprint3.Task7.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #3 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("Введите начальное значение:");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное значение:");
        int stop = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[stop - start];
        array = ds.GetMassFunction(start, stop);
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+--------+--------+");
        Console.WriteLine("|   x       f(x)  |");
        Console.WriteLine("+--------+--------+");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("|{0,5:d}   | {1,5:f2}  |", start, array[i]);
            start++;
        }
        Console.ReadKey();
            
    }
}