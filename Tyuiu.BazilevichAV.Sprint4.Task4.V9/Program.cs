using System;
using Tyuiu.BazilevichAV.Sprint4.Task4.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)            *");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #9                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,    *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до *");
Console.WriteLine("* 8. Найдите сумму четных элементов массива.              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[,] array = new int[5, 5] { { 3, 7, 3, 1, 5 },
                             { 6, 3, 2, 1, 2 },
                             { 1, 3, 2, 8, 1 },
                             { 5, 8, 1, 5, 1 },
                             { 3, 3, 4, 4, 6 } };

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] strx = new int[rows, columns];

Console.WriteLine("***********************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите {i}, {j} элемент массива: ");
        array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(array);
Console.WriteLine("Сумма четных элементов массива = " + res);
Console.ReadKey();