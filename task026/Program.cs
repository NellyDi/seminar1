// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе = {GetCount(num)}");

int GetCount(int number)
{
    int count = 0;
    while(number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}