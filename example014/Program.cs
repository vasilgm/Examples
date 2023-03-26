int[] array = {11, 22, 30, 4, 55, 61, 72, 83, 4};
int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}