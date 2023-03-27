Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());


bool ISfor7and23 (int number)
{
    return number%7 == 0 && number%23 == 0;
}



if (ISfor7and23(a))
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

