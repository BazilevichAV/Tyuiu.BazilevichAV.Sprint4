using System;
using Tyuiu.BazilevichAV.Sprint4.Task5.V12.Lib;

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

Random rnd = new Random();

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

Console.WriteLine("***********************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rnd.Next(-6, 4);
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
Console.WriteLine("Количество отрицательных элементов = " + res);
Console.ReadKey();