﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
    
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(12, -9,9);
PrintArray(array);

int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array)
{
    if(el>0) positiveSum += el;
    else negativeSum += el;
}

Console.WriteLine($"Сумма положительных элементов = {positiveSum}, сумма отрицательных элементов = {negativeSum} ");