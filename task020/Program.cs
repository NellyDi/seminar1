//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки (х и у) через enter ");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки (х и у) через enter ");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);

double distance = Math.Round(Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))), 2);
Console.WriteLine(distance);