//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// (Цифры считать справа налево).

Console.Clear();

Console.Write("Введите трехзначное число : ");
int num = int.Parse(Console.ReadLine()!);
int result = num / 100;

if(num < 100 || num > 1000 ) 
{
    Console.WriteLine($"Число {num} не является трехзначным! ");
}
else Console.WriteLine($"{num} -> {result}");

