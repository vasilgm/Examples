int valuepoint (string point)
{
    System.Console.WriteLine($"Введите значение точки {point}");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = valuepoint("x1");
int y1 = valuepoint("y1");
int x2 = valuepoint("x2");
int y2 = valuepoint("y2");
System.Console.WriteLine($"Длинна линии равна {Long(x1, y1, x2, y2)}");

double Long (int x1, int y1, int x2, int y2)
{
    double longe = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)), 3);
    return longe;
}
