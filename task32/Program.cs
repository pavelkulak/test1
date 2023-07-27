// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int sizeArray = GetNum("Введите длинну массива: ");
int min = GetNum("Введите минимальное значение дипазона массива: ");
int max = GetNum("Введите максимальное значение дипазона массива: ");
int[] array = GetArray(sizeArray, min, max);
PrintArray(array);
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
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
Console.WriteLine("");
PrintArray(array);