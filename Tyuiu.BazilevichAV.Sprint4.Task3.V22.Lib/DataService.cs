using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BazilevichAV.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int count = array[0, 0];
            for (int j = 0; j < columns; j++)
            {
                if (array[0, j] > count)
                {
                    count = array[0, j];
                }
            }
            return count;
        }
    }
}

