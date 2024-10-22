using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZhuriloNA.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int res = int.MinValue;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for(int j = 0; j < array.GetLength(1); j++) 
                {
                    if (array[0, j] > res) 
                    {
                        res = array[0, j];
                    }
                }
            }
            return res;
        }
    }
}
