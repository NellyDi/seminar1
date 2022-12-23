// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел равна = {GetSum(num)}");

int GetSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        //Console.WriteLine($"{number}");
        sum += number;
        number--;
    }
    return sum;
}
