/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberThird  = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond && numberFirst > numberThird){
    Console.WriteLine("Первое число самое большое");
}else if(numberSecond > numberFirst && numberSecond > numberThird){
    Console.WriteLine("Второе число самое большое");
}else if(numberThird > numberFirst && numberThird > numberSecond){
    Console.WriteLine("Третье число самое большое");
}else
    Console.WriteLine("Есть равные числа");