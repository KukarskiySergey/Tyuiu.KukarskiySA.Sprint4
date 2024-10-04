using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KukarskiySA.Sprint4.Task0.V18.Lib
{
    public class DataService : ISprint4Task0V18
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 2 != 0) // Проверяем, является ли элемент нечетным
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}