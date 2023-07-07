// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int GetRandomNumber()
{
    int number = new Random().Next(10, 100);
    // Console.WriteLine(number);
    return number;
}

int GetFirstDigit(int number1)
{
    return number1 / 10; //number1 = number1 / 10;
}

int GetSecondDigit(int number1)
{
    return number1 % 10;
}

void PrintNumber(int num1)
{
    Console.Write(num1 + " ");
}
void ShowLargestDigit(int digit1, int digit2)
{
    if (digit1 > digit2)
    {
        Console.WriteLine("-> " + digit1);
    }
    else
    Console.WriteLine("-> " + digit2);
}

int num = GetRandomNumber();
PrintNumber(num);
int firstDigit = GetFirstDigit(num);
// PrintNumber(firstDigit);
int secondDigit = GetSecondDigit(num);
// PrintNumber(secondDigit);
ShowLargestDigit(firstDigit, secondDigit);


