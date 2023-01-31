// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число : ");
int num = int.Parse(Console.ReadLine()!);

int a1 = num / 1000;
int a2 = num % 100;
int a3 = num % 10;
int result = (a2 - a1 - a3) / 10;

if(num < 100 || num > 1000 ) 
{
    Console.WriteLine($"Число {num} не является трехзначным! ");
}
else Console.WriteLine($"{num} -> {result}");

