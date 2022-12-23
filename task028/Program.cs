// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел = {GetProduct(num)}");

int GetProduct(int number)
{
    int product = 1;
    while(number > 0)
    {
        product *= number;
        number--;
    }
    return product;
}