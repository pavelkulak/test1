// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N
int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void GetSumNumber(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        sum = sum *i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}
int A = GetNumber("Введите первое число: ");
GetSumNumber(A);
