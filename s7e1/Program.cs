// Семинар 7. Рекурсия
// Пример 1
// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.

// Указание: Использовать рекурсию

// Функция вычисления суммы цифр числа рекурсивным способом
int SumOfNumeric(int n)
{
    if (n < 10)
    {
        Console.WriteLine($"Stop recursion: n = {n}");
        return n;
    }
    Console.WriteLine(n);
    int res = n % 10 + (SumOfNumeric(n / 10));
    Console.WriteLine($"Возврат: n = {n}, res = {res}");
    return res;
}

// **********     Тело программы     **********
Console.Write("Введите число: ");
string input = Console.ReadLine()!;
int number;
if (int.TryParse(input, out number))
{
    Console.WriteLine($"sum of numerics {number} = {SumOfNumeric(number)}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}

