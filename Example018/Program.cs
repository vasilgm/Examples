Main();

void Main() 
{
    bool Work = true;
    while (Work)
    {
        System.Console.WriteLine("Решаем задачу? Введите y/n.");
        string a = System.Console.ReadLine();
        switch (a) 
        {
            case "y":task1();break;
            case "n": Work = false; break;
        }

    }
}

void task1 ()
{
    Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(TwoNumber(number));
}

int TwoNumber (int number)
{
    int a = number / 100;
    int b = number % 10;
    return a*10 + b;
}