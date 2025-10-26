using Tyuiu.RomanovichEN.Sprint3.Task5.V10.Lib;
    
namespace Tyuiu.RomanovichEN.Sprint3.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            double wait = 20685;
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Assert.AreEqual(wait, res);
        }
    }
}
