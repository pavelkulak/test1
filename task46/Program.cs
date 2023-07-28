﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int [,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = new Random().Next(10, 100);
        }

    }
    return res;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)   // GetLength(0) строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) столбцы
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
