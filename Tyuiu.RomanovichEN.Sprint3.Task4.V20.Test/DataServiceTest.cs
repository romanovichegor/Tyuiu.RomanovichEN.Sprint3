using Tyuiu.RomanovichEN.Sprint3.Task4.V20.Lib;
namespace Tyuiu.RomanovichEN.Sprint3.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            double wait = 10.483;
            DataService ds = new DataService();
            int start, stop;
            start = -5; stop = 5;
            double res = ds.Calculate(start, stop);
            Assert.AreEqual(res, wait);
        }
    }
}
