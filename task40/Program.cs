// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int a = Promt("Введите сторону а ");
int b = Promt("Введите сторону b ");
int c = Promt("Введите сторону c ");

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void Verification(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Существует");
    }
    else
    {
        Console.WriteLine("Не существует");
    }
}
Verification(a, b, c);