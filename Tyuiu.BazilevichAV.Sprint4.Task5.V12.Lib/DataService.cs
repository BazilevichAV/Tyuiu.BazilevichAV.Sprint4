using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BazilevichAV.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] < 0)
                    {
                        count ++;
                    }
                }
            }
            return count;
        }
    }
}