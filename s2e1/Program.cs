// Напишите программу, которая принимает на вход трёхзначное число и
// удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int number1 = num / 100;
int number3 = num % 10;

Console.WriteLine(number1);
Console.WriteLine(number3);

Console.WriteLine(number1 + "" + number3);
Console.WriteLine(number1 * 10 + number3);

int result = number1 * 10 + number3;
Console.WriteLine($"{num} -> {result}");