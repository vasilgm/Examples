int number ()
{
    System.Console.Write($"Введите число N: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = number();
sqare (N);


void sqare (int N)
{
    for (int i = 1; i <= N; i++)
{
    int x = i*i;
    System.Console.WriteLine($"Квадрат числа {i} равен {x}");
}
}