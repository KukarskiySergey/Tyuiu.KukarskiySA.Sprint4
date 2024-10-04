using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            // Проходим по всем элементам массива
            foreach (string str in array)
            {
                if (str.Length > 5) // Проверка на длину строки
                {
                    count++;
                }
            }

            return count;
        }
    }
}
