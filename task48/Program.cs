// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
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
            res[i, j] = i+j;
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