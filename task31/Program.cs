//  Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
// int[] array = new int[12];
// int summinus = 0;
// int sumplus = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 9);
//     Console.Write($"{array[i]},");

//     if (array[i] < 0)
//     {
//         summinus = summinus + array[i];
//     }
//     else
//     {
//         sumplus = sumplus + array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных чисел равна - {summinus}, Сумма положительных чисел равна- {sumplus}");

int sizeArray = GetNum("Введите длинну массива: ");
int min = GetNum("Введите минимальное значение дипазона массива: ");
int max = GetNum("Введите максимальное значение дипазона массива: ");

int[] array = GetArray(sizeArray, min, max);
PrtintArray(array);
int [] resSum = GetSum(array);
int posSum;
int negSum;
Console.WriteLine($"\nСумма + = {resSum[0]}, сумма - = {resSum[1]}");
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
void PrtintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int [] GetSum(int[] arr)
{
int positiveSum = 0;
int negativSum = 0;
int [] res = new int[2];
foreach (int el in array)
{
    if (el > 0)
    {
        positiveSum += el;
    }
    if (el < 0)
    {
        negativSum += el;
    }
}
res[0] = positiveSum;
res[1] = negativSum;
return res;
}

