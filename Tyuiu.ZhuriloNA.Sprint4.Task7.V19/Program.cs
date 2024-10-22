using Tyuiu.ZhuriloNA.Sprint4.Task7.V19.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task7.V19
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
            Console.WriteLine("* Задание #8                                                                  *");
            Console.WriteLine("* Вариант #19                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"90817264\". Преобразуйте ее в матрицу   *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.                   *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string value = "90817264";
            int n = 4;
            int m = 2;
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.Calculate(n, m, value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
