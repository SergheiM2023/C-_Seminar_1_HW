﻿// Задача №1
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
//-7 -> 49
// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Console.WriteLine("Введите число");

// int number=Convert.ToInt32(Console.ReadLine());
// number = number*number;



// Задача № 2 

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

//Console.WriteLine("Введите число");
//int number=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число");
//int number2=Convert.ToInt32(Console.ReadLine());

//if(number==number2*number2)
//{
//Console.WriteLine("Введите 1 является квадратом числа 2 ");
//}
//else
//{
//Console.WriteLine("Введите 1 не является квадратом числа 2 ");
//}
//int sqr = number*number; // number*=number; сокращение

//Console.Write("Квадрат числа равен ");
//Console.WriteLine(sqr);



// Задача 3 
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number== 1)
//     Console.WriteLine("Понедельник");
// else if (number== 2)
//     Console.WriteLine("Вторник");
// else if (number== 3)
//     Console.WriteLine("Среда");
// else if (number== 4)
//     Console.WriteLine("Четверг");
// else if (number== 5)
//     Console.WriteLine("Пятница");
// else if (number== 6)
//     Console.WriteLine("Субботв");
// else if (number== 7)
//     Console.WriteLine("Воскресенье");                        
// else
//     Console.WriteLine("Такого дня недели нет ");


// Задача 4 
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int negNumber=-number;

// while(number>=negNumber)
// {
//     Console.WriteLine(negNumber);
//     negNumber=negNumber+1;   // negNumber++; -  Сокращение
// }


// Задача 5
// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Вывести число");
int n = Convert.ToInt32(Console.ReadLine());
int result = n%10;
Console.WriteLine(result);

