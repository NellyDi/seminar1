// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введте число: ");
int num = int.Parse(Console.ReadLine()!);
int Sum(int num)
{
    if(num == 0) 
    {
        return 0;
    }
    else 
        
        return num % 10 + Sum(num/10); 
        
}

Console.WriteLine(Sum(num));