int [] array = {1, 2, 8, 4, 6, 4, 1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}


void Sort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]= temporary;
    }
}

PrintArray(array);
Sort(array);
PrintArray(array);
