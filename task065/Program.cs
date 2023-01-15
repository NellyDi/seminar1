// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

Console.Write("Введте число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введте число N: ");
int N = int.Parse(Console.ReadLine()!);

int Natural(int num1, int num2)
{
    if(num1 == num2) 
    {
        return num1;
    }
    else
        return Natural(num1 + 1, num2); 
        
}

Console.WriteLine(Natural(M, N));