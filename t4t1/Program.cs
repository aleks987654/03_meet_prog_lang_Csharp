// Урок 4. Функции. 
// Задача 1
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// Функция проверки корректности ввода целого числа с консоли
bool InputNumberIsCorrect(string? s)
{
    try
    {
        Convert.ToInt32(s);
        Console.WriteLine($"Корректный ввод числа.");
        return true;
    }
    catch
    {
        Console.WriteLine($"{s} - ввод числа не корректен!");
        return false;
    }
}

// Функция вычисления суммы цифр целого числа
int GetSumOfDigitsOfNumber(int number)
{
    int sum = 0;
    number = Math.Abs(number);
    while ((number > 0))
    {
        sum = sum + number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр числа равна {sum}");
    return sum;
}

// Тело программы
string? input_string = "";

while (true)
{
    Console.Write("Введите целое число либо q для выхода: ");
    input_string = Convert.ToString(Console.ReadLine());
    if (input_string == "q" || input_string == "Q") return;
    if (InputNumberIsCorrect(input_string))
    {
        int n = Convert.ToInt32(input_string);
        if (GetSumOfDigitsOfNumber(n) % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр числа {n} чётная");
            return;
        }
        else Console.WriteLine($"Сумма цифр числа {n} нечётная");
    }
}