Console.WriteLine("Введите число 1:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int number2 = int.Parse(Console.ReadLine());

if ( number2 * number2 == number1)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("НЕТ!");
}