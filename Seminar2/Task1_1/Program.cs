﻿// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num1 = num / 100;

int num3 = num % 10;

int result = num1 * 10 + num3;
Console.WriteLine(result); 

