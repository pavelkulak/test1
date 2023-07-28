// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int row = GetNum("Введите количество строк: ");
int column = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(row, column);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] GetArray(int rows, int columns)
{
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = array[i,j] + sum;
        }
    } 
}    
Console.WriteLine();
Console.WriteLine($"{sum}");