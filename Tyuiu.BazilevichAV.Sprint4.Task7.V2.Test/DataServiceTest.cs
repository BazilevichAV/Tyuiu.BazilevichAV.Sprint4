using Newtonsoft.Json.Linq;
using Tyuiu.BazilevichAV.Sprint4.Task7.V2.Lib;
namespace Tyuiu.BazilevichAV.Sprint4.Task7.V2.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "597643158942";
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            int res = ds.Calculate(n, m, value);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}