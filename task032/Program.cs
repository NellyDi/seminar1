﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void ChangeArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = -arr[i];
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(5, -9, 9);
Console.WriteLine();
ChangeArray(array);
