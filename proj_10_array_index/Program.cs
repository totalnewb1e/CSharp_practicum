﻿int[] array = { 55, 74, 77, 15, 66, 77, 18, 3 };

int n = array.Length;
int find = 77;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
        index++;
}