// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int sizeArray = GetNum("Введите длинну массива: ");
int min = GetNum("Введите минимальное значение дипазона массива: ");
int max = GetNum("Введите максимальное значение дипазона массива: ");
int[] array = GetArray(sizeArray, min, max);
PrintArray(array);
Console.WriteLine("");
int value = GetNum("Введите искомое число: ");
bool found = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == value)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine($"Да, число {value} присутствует в массиве.");
}
else
{
    Console.WriteLine($"Нет, число {value} отсутствует в массиве.");
}

int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}