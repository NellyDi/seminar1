// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);


int[] GetArray(int size)
{
    int[] res = new int[size];
    res[0] = 0;
    res[1] = 1;

    for(int i = 2; i < size; i++)
    {
        res[i] = res[i-1] + res[i-2];
    }
    return res;
}

Console.WriteLine(string.Join(" ", GetArray(num)));
