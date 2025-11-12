using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BazilevichAV.Sprint4.Task6.V22.Lib
{
    public class DataService : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, weather => weather.Length == 4);
            return mas;
        }
    }
}