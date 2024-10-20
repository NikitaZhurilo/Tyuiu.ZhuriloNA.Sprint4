using System.Diagnostics.CodeAnalysis;
using Tyuiu.ZhuriloNA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #7                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный случайными  *");
            Console.WriteLine("* в диапазоне от 4 до 9 подсчитать сумму четных элементов массива             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int simple = 12;
            int[] array = new int[simple];
            Console.WriteLine("Заполните массив значениями от 4 до 9: ");
            for (int i = 0; i < simple; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] < 4 || array[i] > 9)
                {
                    Console.WriteLine("Значение некорректно, введите другое, больше 4, но меньше 9 (включительно)");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    
                }

            }
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
