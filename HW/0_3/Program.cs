// Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое значение");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе значение");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье значение");
int c = int.Parse(Console.ReadLine()!);
int max = 0;
if (a == b || a == c) {
    Console.WriteLine("Все числа равны!");
}
if (a > b)
{
    max = a;
}
else max = b;
if (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное значение: " + max);
