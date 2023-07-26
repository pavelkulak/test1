// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Amount(int number)
{
int count;
for (count = 0; number > 0; count++)
{
    number = number / 10;
}
Console.WriteLine("Количество цифр - " + count);
}
int number = GetNumber("Введите число: ");
Amount(number);