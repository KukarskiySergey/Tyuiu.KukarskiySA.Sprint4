using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task5.V23.Lib
{
    public class DataService : ISprint4Task5V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Проходим по каждому элементу массива
            for (int i = 0; i < matrix.GetLength(0); i++) // По строкам
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // По столбцам
                {
                    if (matrix[i, j] < 0) // Если элемент отрицательный
                    {
                        matrix[i, j] = 0; // Заменяем его на 0
                    }
                }
            }

            return matrix; // Возвращаем измененный массив
        }
    }
}
