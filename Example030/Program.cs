int number ()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = number();
Print (N);



//System.Console.WriteLine($"Произведение равно {inc (N)}");

int inc (int N)
{
    int inc = 1;
    for (int i = 1; i <=N; i++)
    {
        inc = inc * i;
    }
    return inc;
}

void Print (int X)
{
    System.Console.WriteLine($"Произведение равно {inc (X)}");
}
