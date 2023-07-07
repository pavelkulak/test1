// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
nt GetRandomNumber()
{
    int number = new Random().Next(100, 1000);
    // Console.WriteLine(number);
    return number;
}

int GetFirstDigit(int number1)
{
    return number1 / 10; //number1 = number1 / 10;
}

int GetSecondDigit(int number1)
{
    return number1 % 100;
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


