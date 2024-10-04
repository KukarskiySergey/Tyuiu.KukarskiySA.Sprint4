using Tyuiu.KukarskiySA.Sprint4.Task5.V23.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы(генератор случайных чисел)                   *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #13                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *");
Console.WriteLine("* случайными значениями в диапазоне от -4 до 8.                        *");
Console.WriteLine("* Заменить отрицательные элементы на 0.                                *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* Двумерный целочисленный массив 5 на 5 из случайных чисел             *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[,] matrix = {
    { 5, -3, 6, 1, 0 },
    { -4, 2, -1, 8, 4 },
    { 7, -2, 3, 0, -1 },
    { 2, 4, -4, 5, -3 },
    { 6, 3, -2, -1, 8 }
};

int[,] updatedMatrix = dataService.Calculate(matrix);

// Вывод измененного массива для проверки
for (int i = 0; i < updatedMatrix.GetLength(0); i++)
{
    for (int j = 0; j < updatedMatrix.GetLength(1); j++)
    {
        Console.Write(updatedMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("************************************************************************");
Console.ReadLine();