using Tyuiu.ZhuriloNA.Sprint4.Task3.V22.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task3.V22
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
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #22                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный            *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Найдите максимальный элемент *");
            Console.WriteLine("* в первой строке массива.                                                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int[,] array = {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 }
            };
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
