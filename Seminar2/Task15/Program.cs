﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//8,9  ->  нет
Console.WriteLine("Введите первое число: "); 
int num1 = Convert.ToInt32(Console.ReadLine()); //СПАСИБО ЗА СОТРУДНИЧЕСТВО!!!
Console.WriteLine("Введите второе число: "); 
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2 || num2 == num1*num1) Console.WriteLine("Одно из чисел является квадратом другого"); 
else Console.WriteLine("Ни одно из чисел не является квадратом другого"); 