﻿// Задача 2: Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.


int number = new Random().Next(100, 999);
System.Console.WriteLine(number);



