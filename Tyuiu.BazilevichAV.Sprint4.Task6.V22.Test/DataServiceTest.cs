using Tyuiu.BazilevichAV.Sprint4.Task6.V22.Lib;
namespace Tyuiu.BazilevichAV.Sprint4.Task6.V22.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] weather = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] res = ds.Calculate(weather);
            string[] wait = { "Снег", "Град", "Туча" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}