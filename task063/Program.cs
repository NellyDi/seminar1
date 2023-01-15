// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введте число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
int Natural(int num, int a)
{
    if(a == num) 
    {
        return a;
    }
    else 
        Console.Write($"{a} ");
        return Natural(num, a + 1); 
        
}

Console.WriteLine(Natural(N, i));