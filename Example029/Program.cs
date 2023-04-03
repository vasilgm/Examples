int number ()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int N = number();

if (N > 0)
{
    System.Console.WriteLine($"{N} содержит {countMore0(N)} чисел");  
}
else
{
    System.Console.WriteLine($"{N} содержит {countMore1(N)} чисел");
}

int countMore0 (int N)
{
    int i = 0;
    while (N>0)
    {
        N = N/10;
        i++;
    }
    return i;
}

int countMore1 (int N)
{
    
    N = N * -1;
    int i = 0;
    while (N>0)
    {
        N = N/10;
        i++;
    }
    return i;
}
