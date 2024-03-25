// Задача 3: Напишите программу, которая принимает на вход
// целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа

Console.Write("Введите любое число от 10 до 99: ");
int n = Convert.ToInt32 (Console.ReadLine());

if ((n < 10) || (n > 99)) 
    Console.WriteLine($"число {n} не удовлетворяет условию!");

else if ((n / 10) == (n % 10)) Console.WriteLine("Цифры одинаковы");

else 
{
    if ((n / 10) > (n % 10)) 
            Console.WriteLine($"Наибольшая цифра: {n / 10}");
    else Console.WriteLine($"Наибольшая цифра: {n % 10}");    
}
