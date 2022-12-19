//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) 
{
    Console.WriteLine("x = (0; оо), y = (0; оо)");
}
if (num == 2) 
{
    Console.WriteLine("x = (-оо; 0), y = (0; оо)");
}
if (num == 3) 
{
    Console.WriteLine("x = (-оо; 0), y = (-оо; 0)");
}
if (num == 4) 
{
    Console.WriteLine("x = (0; оо), y = (-оо; 0)");
}