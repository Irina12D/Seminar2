﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/

/*
Console.Write("Введите трёхзначное число ");
int n = int.Parse(Console.ReadLine ());

//вариант 1 нажодения второй цифры трёхзначного числа
Console.WriteLine($"вторая цифра числа равна {n%100/10}");

//вариант 2 нажодения второй цифры трёхзначного числа
Console.WriteLine($"вторая цифра числа равна {n/10%10}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/

/*
Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine ());

if (n < 100)
    Console.WriteLine("третьей цифры нет");
else
    if (n < 1000)
        Console.WriteLine($"третья цифра числа равна {n % 10}");
    else if (n < 10000) 
            Console.WriteLine($"третья цифра числа {n} равна {n / 10 % 10}");
        else if (n < 100000) 
                Console.WriteLine($"третья цифра числа {n} равна {n / 100 % 10}");
            else if (n < 1000000) 
                    Console.WriteLine($"третья цифра числа {n} равна {n / 1000 % 10}"); 
                else if (n < 10000000) 
                        Console.WriteLine($"третья цифра числа {n} равна {n / 10000 % 10}");
                    else if (n < 100000000) 
                            Console.WriteLine($"третья цифра числа {n} равна {n / 100000 % 10}"); 
                         else if (n < 1000000000) 
                                Console.WriteLine($"третья цифра числа {n} равна {n / 1000000 % 10}");
                              else 
                                Console.WriteLine($"третья цифра числа {n} равна {n / 10000000 % 10}");                    
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/
Console.Write("Введите день недели ");
int n = int.Parse(Console.ReadLine ());
if (n > 7 || n < 1)
    Console.WriteLine("неверный день недели");
else
    if (n > 5) // или составным условием (n == 6 || n == 7)
        Console.WriteLine("выходной день");
    else
        Console.WriteLine("не выходной день");


    


