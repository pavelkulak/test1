Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number >=100 && number <=999)
{
    Console.WriteLine(number % 10);
}
else{
    Console.WriteLine("Число не трехзначное");
}