void FillArray(int[] collection)
{
    int lenth = collection.Length;
    int index = 0;
    while (index < lenth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int pos = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int position = IndexOf(array, 55);
Console.WriteLine(position);
