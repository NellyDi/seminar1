// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

Console.Write("Введте число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введте число B: ");
int B = int.Parse(Console.ReadLine()!);

int Degree(int numA, int numB)
{
    if (numB == 0)
        return 1;
    else
        return numA * Degree(numA, numB - 1);
} 

Console.WriteLine(Degree(A,B));