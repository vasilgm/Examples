Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
if (N >=100)
{
N = threenumber(N);
Console.WriteLine($"Третья цифра числа равна {remainder (N)}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}

int threenumber (int number)
{
while (number > 999)
{
number = number / 10;
}
return number;
}

int remainder (int number)
{
    number = number % 10;
    return number;
}