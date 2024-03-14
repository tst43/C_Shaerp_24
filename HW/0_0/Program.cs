// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число");
int b = int.Parse(Console.ReadLine()!); // преобразование строки из консоли в число 
int max;
if (a > b)
{
    max = a;
}
else if (a == b)
{
    Console.WriteLine("числа равны");
}
else
{
    max = b;
}
Console.WriteLine("максимальное число: " + max);

