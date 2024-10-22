using Tyuiu.ZhuriloNA.Sprint4.Task4.V28.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] wait = { 
                { 3, 3, 1, 1, 1 }, 
                { 1, 1, 1, 1, 5 }, 
                { 1, 1, 1, 1, 1 }, 
                { 1, 5, 1, 5, 1 }, 
                { 1, 1, 3, 1, 1 } 
            };
            int[,] matrix = new int[5, 5];
            matrix = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, matrix);
        }
    }
}