using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            // Преобразуем строку в двумерный массив
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Заполняем матрицу цифрами из строки
                    matrix[i, j] = value[index] - '0'; // Преобразуем символ в число
                    index++;
                }
            }

            int sum = 0;

            // Проходим по матрице и считаем сумму нечетных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0) // Проверка на нечетность
                    {
                        sum += matrix[i, j]; // Суммируем нечетные числа
                    }
                }
            }

            return sum;
        }
    }
}
