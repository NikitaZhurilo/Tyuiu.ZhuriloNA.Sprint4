using Tyuiu.ZhuriloNA.Sprint4.Task6.V29.Lib;
namespace Tyuiu.ZhuriloNA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "�����", "����", "�����", "����" };
            int res = ds.Calculate(array);
            int wait = 2;
            Assert.AreSame(wait, res);
        }
    }
}