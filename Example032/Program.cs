
int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]}");
}

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
 if (array[i] > 0)
{
    sum = sum + array[i];
}   
}

System.Console.WriteLine(sum);