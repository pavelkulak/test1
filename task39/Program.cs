// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] array = GetArray(11, 0, 15);
Console.Write(String.Join(" ", array));
// ReverseArray(array);
// Console.WriteLine();
// Console.Write(string.Join(" ", array));
Console.WriteLine();
int[] reverseArray = ReverseArray2(array);
Console.Write(string.Join(" ", reverseArray));
int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    } 
}
int[] ReverseArray2(int[] arr)
{
    int[] reverse = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        reverse[i] = arr[arr.Length - 1 - i];
    }
    return reverse;
}