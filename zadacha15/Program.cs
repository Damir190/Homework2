// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число от 1 до 7 : ");
int num = int.Parse(Console.ReadLine()!);

while(num <= 7 && num > 0)
{
    if(num == 6 || num == 7)
    {
        Console.WriteLine("Выходной!=) ");
        break;
    }
    else
    {
        Console.WriteLine("Будни=( ");
        break;
    }
}
if(num > 7 || num < 1)
{
    Console.WriteLine("Нет такого дня недели! ");
}


