﻿// Напишите программу, которая принимает на вход трёхзначное число и
// возводит вторую цифру этого числа в степень, равную третьей цифре

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int number2 = (num % 100) / 10;
int number3 = num % 10;

// int number2 = 5;
// int number3 = 5;

Console.WriteLine(number2);
Console.WriteLine(number3);
// мой
// int i = 1;
// int result = 1;
// while (i <= number3)
// {
//     result = result * number2;
//     i = i + 1;
// }

// иван
// double result = Math.Pow(number2, number3);

//препод
int i = 1;
int result = number2;
while (i < number3)
{
    result *= number2;
    i++;
}

Console.WriteLine($"{number2} в степени {number3} равно {result}");