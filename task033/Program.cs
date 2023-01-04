// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

void Comparison(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (n == arr[i]) sum =+1;
    }
    if (sum > 0) Console.WriteLine("yes");
    else Console.WriteLine("no");
    
}

int[] array = GetArray(5, -9, 9);
Console.WriteLine();
Comparison(array);