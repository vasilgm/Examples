int[] Array = new int [num ("длинну массива")];
int[] NewArray = new int[LeghtNewArray(Array.Length)];
RandomArray(Array);
ckr(Array, NewArray);

void ckr (int[] Array, int[] NewArray)
{
if (Array.Length % 2 > 0)
{
for (int i = 0; i < NewArray.Length-1; i++)
{
    NewArray[i] = Array[i]* Array[Array.Length-1-i];
    System.Console.WriteLine(NewArray[i]);
}
    System.Console.WriteLine(Array[Array.Length/2]);
}
else
{
for (int i = 0; i <= NewArray.Length-1; i++)
{
    NewArray[i] = Array[i]* Array[Array.Length-1-i];
    System.Console.WriteLine(NewArray[i]);
}
}
}

int LeghtNewArray (int arrayLength)
{
if ( arrayLength%2 != 0)
{
    arrayLength = arrayLength+1;
}
return arrayLength/2;
}
int num (string i)
{
    System.Console.Write($"Введите {i} : ");
    int x = int.Parse(Console.ReadLine());
    return x;
}
int[] RandomArray (int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 11);
        System.Console.Write($"{Array[i]} ");
    }
    System.Console.WriteLine("");
    return Array;
}