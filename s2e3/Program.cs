// Напишите программу, которая принимает на вход два числа и
// выводит, является ли первое число кратным второму.
// Если первое число некратно второму, 
// то программа выводит остаток от деления

// мой
// int num1 = 8;
// Console.WriteLine($"первое число: {num1}");

// int num2 = 16;
// Console.WriteLine($"второе число: {num2}");

// if ((num1 % num2) == 0)
// {
//     Console.WriteLine($"первое число кратно второму");
// }
// else
// {
//     Console.WriteLine($"остаток от деления первого числа на второе равен {num1 % num2}");
// }

// препод
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0) { Console.WriteLine("Деление на 0!"); }
else
{
    int res = num1 % num2;
    if (res == 0) { Console.WriteLine("Да"); }
    else { Console.WriteLine($"Нет, остаток {res}"); }
}