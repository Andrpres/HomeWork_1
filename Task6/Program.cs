﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number % 2 == 1){
    Console.WriteLine("Число нечетное");
}else{
    Console.WriteLine("Число четное");
}