// Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка)
Console.Clear();


int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


