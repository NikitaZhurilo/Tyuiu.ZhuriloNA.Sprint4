using Tyuiu.ZhuriloNA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res;
            int[] array = { 4, 7, 6, 5, 5, 5, 8, 7, 6, 5, 4, 6 };
            res = ds.Calculate(array);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}