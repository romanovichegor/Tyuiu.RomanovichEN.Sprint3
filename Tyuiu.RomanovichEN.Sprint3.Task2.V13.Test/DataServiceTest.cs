using Tyuiu.RomanovichEN.Sprint3.Task2.V13.Lib;
namespace Tyuiu.RomanovichEN.Sprint3.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 2.087;
            double res = ds.GetSumSeries(0.7, 1, 10);
            Assert.AreEqual(wait, res);
        }
    }
}
