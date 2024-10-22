using Tyuiu.ZhuriloNA.Sprint4.Task6.V29.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task6.V29
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
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #24                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными *");
            Console.WriteLine("* значениями в диапазоне от -7 до 6. Найти количество положительных элементов *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Заполните массив значениями : ");
            string[] array = { "Весна", "Лето", "Осень", "Зима" };
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
