using System.Net.Http.Headers;
using Tyuiu.RomanovichEN.Sprint3.Task3.V20.Lib;

namespace Tyuiu.RomanovichEN.Sprint3.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            int wait = 5;
            char f = 'f';
            int res = ds.GetCharCount(str, f);
            Assert.AreEqual(wait, res);

        }
    }
}
