﻿// int[] array = { 11, 25, 23, 4, 18, 55, 46, 72, 18 };

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index<n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index=index+1;
// }
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index + 1;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
