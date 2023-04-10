int F (int n)
{
    if (n == 1 || n == 2) return n;
    else return F(n-1)+F(n-2);
}

for (int i = 1; i < 10; i++)
{
    System.Console.WriteLine(F(i));
}