using Tyuiu.KukarskiySA.Sprint4.Task7.V4.Lib;

DataService dataService = new DataService();

Console.Title = "Спринт #4 | Выполнил: Кукарский С.А. | ИИПб-24-1";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #4                                                           *");
Console.WriteLine("* Выполнил Кукарский Сергей Андреевич | ИИПб-24-1                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 3 на 4  *");
Console.WriteLine("* и подсчитайте сумму нечетных чисел.                                  *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
Console.WriteLine("* 382976421897                                                         *");
Console.WriteLine("*                                                                      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");

string value = "382976421897";
int n = 3;
int m = 4;

int sumOfOddNumbers = dataService.Calculate(n, m, value);

Console.WriteLine($"Сумма нечетных чисел: {sumOfOddNumbers}");
Console.WriteLine("************************************************************************");
Console.ReadLine();