using System;
using System.Reflection;
using Tyuiu.BazilevichAV.Sprint4.Task7.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #2                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр 597643158942.         *");
Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4 и подсчитайте сумму    *");
Console.WriteLine("* нечетных чисел.                                         *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int n = 3;
int m = 4;
int[,] matrix = new int[n, m];
string value = "597643158942";

Console.WriteLine("Массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(value[i * m + j].ToString());
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(n, m, value);

Console.WriteLine("Сумма нечетных чисел = " + res);
Console.ReadKey();