// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

string Answer(int n)
{
    int res = 0;
    string answ = "";
    while(num > 0)
    {
        res = num % 2;
        num = num / 2;
        answ = res + answ;
    }
    return answ;
}
Console.WriteLine(Answer(num));
