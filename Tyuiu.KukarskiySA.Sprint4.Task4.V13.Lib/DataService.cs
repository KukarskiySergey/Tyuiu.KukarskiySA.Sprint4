using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task4.V13.Lib
{
    public class DataService : ISprint4Task4V13
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;

            // Проход по всем элементам массива
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) // Проверка на четность
                    {
                        sum += matrix[i, j]; // Добавляем четный элемент к сумме
                    }
                }
            }

            return sum;
        }
    }
}
