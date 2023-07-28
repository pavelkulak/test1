// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int a = Promt("Введите число ");



int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
