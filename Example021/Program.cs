Console.WriteLine("Введите число 1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 = int.Parse(Console.ReadLine());
if (QAZ (number1, number2))
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("НЕТ!");
}


bool QAZ (int number1, int number2)
{
    return number1*number1 == number2  || number2 * number2 == number1;
}





