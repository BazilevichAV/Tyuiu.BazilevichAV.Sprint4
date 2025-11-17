using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BazilevichAV.Sprint4.Task4.V9.Lib
{
    public class DataService : ISprint4Task4V9
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int sumArray = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        sumArray += array[i, j];
                    }
                }
            }
            return sumArray;
        }
    }
}