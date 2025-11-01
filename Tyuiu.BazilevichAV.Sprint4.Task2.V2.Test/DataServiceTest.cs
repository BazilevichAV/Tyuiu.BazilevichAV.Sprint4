using Tyuiu.BazilevichAV.Sprint4.Task2.V2.Lib;
namespace Tyuiu.BazilevichAV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 105;
            Assert.AreEqual(wait, res);
        }
    }
}