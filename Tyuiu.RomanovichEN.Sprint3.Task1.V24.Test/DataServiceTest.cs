using Tyuiu.RomanovichEN.Sprint3.Task1.V24.Lib;
namespace Tyuiu.RomanovichEN.Sprint3.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int start = 1;
            int stop = 12;
            double wait = 0.186;
            double res = ds.GetSumSeries(value, start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
