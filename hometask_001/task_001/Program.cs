﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10
Console.Clear();
int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine());
if ( A >  B)
{
    Console.WriteLine("min = a");
}
else
{
    Console.WriteLine("max = b");
}    

