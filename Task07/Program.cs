﻿// 6. Выяснить является ли число чётным

int a;
Console.WriteLine("Напишите ваше число:");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}