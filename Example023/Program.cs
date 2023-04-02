int Read (string coordinate)
{
    Console.WriteLine($"Введите чило {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x = Read("x");
int y = Read("y");

int Qnomber(int x, int y)
{
    if (x>0 && y>0) return 1;
    else if (x<0 && y>0) return 2;
    else if (x<0 && y<0) return 3;
    else return 4;
}
System.Console.WriteLine($"Если точка имеет координаты {x} и {y} то квадрант равет {Qnomber(x, y)}");
