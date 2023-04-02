int Number ()
{
    System.Console.WriteLine($"Введите номер квадранта:");
    int number = int.Parse(Console.ReadLine());
    return number;
}


int number = Number();
if (number > 4 || number <1) System.Console.WriteLine("Нет такого квадранта!");
else range (number);

void range(int number)
{
if (number == 1) Console.WriteLine($"Когда четверть равна {number}: х принимает значение от 0 до плюс безконечности, y от нуля до плюс безконечности");
else if (number == 2) Console.WriteLine($"Когда четверть равна {number}: х принимает значение от 0 до минус безконечности, y от нуля до плюс безконечности");
else if (number == 3) Console.WriteLine($"Когда четверть равна {number}: х принимает значение от 0 до минус безконечности, y от нуля до минус безконечности");
else System.Console.WriteLine($"Когда четверть равна {number}: х принимает значение от 0 до плюс безконечности, y от нуля до минус безконечности");
}


