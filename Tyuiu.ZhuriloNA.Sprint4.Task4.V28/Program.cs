using Tyuiu.ZhuriloNA.Sprint4.Task4.V28.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #28                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями *");
            Console.WriteLine("* с клавиатуры в диапазоне от 1 до 5. Заменить четные элементы массива на 1.  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int simple = 5;
            int donk = 5;
            int[,] array = new int[simple, donk];
            Console.WriteLine("Заполните массив значениями : ");
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            array = ds.Calculate(array);
            for (int i = 0;i < array.GetLength(0); i++)
            { 
                for(int j = 0;j < array.GetLength(1); j++) 
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
