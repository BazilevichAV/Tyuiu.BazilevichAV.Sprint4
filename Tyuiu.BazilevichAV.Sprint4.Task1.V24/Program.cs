using System;
using Tyuiu.BazilevichAV.Sprint4.Task1.V24.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)            *");
Console.WriteLine("* Задание #1                                              *");
Console.WriteLine("* Вариант #24                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов     *");
Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до *");
Console.WriteLine("* 5 подсчитать произведение нечетных элементов массива.   *");
Console.WriteLine("* С клавиатуры:2,2,2,5,5,3,4,2,5,2,5,3,4,3,5,2            *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0;i <= len - 1; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("Результирующий массив: ");

int res = ds.Calculate(numsArray);
Console.WriteLine(res);
Console.ReadKey();