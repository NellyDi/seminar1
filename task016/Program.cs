// Задача №16. 
// Напишите программу, которая принимает на вход два 
// числа и проверяет, является ли одно число квадратом 
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет 
Console.WriteLine("Введите 2 числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("Да");
}
else
Console.WriteLine("Нет");