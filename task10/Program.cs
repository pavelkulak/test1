// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
string GetResult(int X, int Y)
{
    string res = "";
    if (X > 0 && Y > 0)
    {
        res = "I четверть";
    }
    else if (X < 0 && Y > 0)
    {
        res = "II четверть";
    }
    else if (X < 0 && Y < 0)
    {
        res = "III четверть";
    }
    else if (X > 0 && Y < 0)
    {
        res = "IV четверть";
    }
    return res;
}