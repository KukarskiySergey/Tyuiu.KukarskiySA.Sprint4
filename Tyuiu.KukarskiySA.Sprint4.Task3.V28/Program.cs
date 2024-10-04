using Tyuiu.KukarskiySA.Sprint4.Task3.V28.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы(статический ввод)                            *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #28                                                          *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *");
Console.WriteLine("* статическими значениями в диапазоне от 4 до 9.                       *");
Console.WriteLine("* Найдите минимальный элемент в четвертом столбце массива.             *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 5, 4, 9, 8, 5,                                                       *");
Console.WriteLine("* 4, 6, 6, 9, 9,                                                       *");
Console.WriteLine("* 9, 8, 4, 8, 8,                                                       *");
Console.WriteLine("* 6, 8, 6, 8, 9,                                                       *");
Console.WriteLine("* 9, 4, 6, 6, 7,                                                       *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

int[,] array = {
    {5, 4, 9, 8, 5},
    {4, 6, 6, 9, 9},
    {9, 8, 4, 8, 8},
    {6, 8, 6, 8, 9},
    {9, 4, 6, 6, 7}
};

int minInFourthColumn = dataService.Calculate(array);

Console.WriteLine($"Минимальный элемент в четвертом столбце: {minInFourthColumn}");
Console.WriteLine("************************************************************************");
Console.ReadLine();