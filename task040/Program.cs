// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите 3 числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

Check(num1, num2, num3);
void Check(int a, int b, int c)
{
    if(a+b>c && a+c>b && b+c>a)
    Console.WriteLine("yes");
    else 
    Console.WriteLine("no");
}