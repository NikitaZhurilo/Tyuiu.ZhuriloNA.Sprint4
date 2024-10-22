using Tyuiu.ZhuriloNA.Sprint4.Task7.V19.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            string value = "90817264";
            int[,] array = new int[n, m];
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}