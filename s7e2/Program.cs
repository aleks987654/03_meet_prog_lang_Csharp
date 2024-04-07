// Семинар 7. Рекурсия
// Пример 2
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

// Указание: Использовать рекурсию. Не использовать цикл

// Функция заполнения строки натуральными числами от 1 до N
// раскручивание рекурсии от 1 до N
string rStringOfNumbers(int stop, int start = 1)
{
    if (start == stop)
    {
        Console.WriteLine($"Stop recursion: n = {stop}");
        return Convert.ToString(stop);
    }
    Console.WriteLine(stop);
    string res = Convert.ToString(rStringOfNumbers(stop - 1))
                + " " + Convert.ToString(stop);
    Console.WriteLine($"Возврат: n = {stop}, res = {res}");
    return res;
}

// Функция заполнения строки натуральными числами от 1 до N
// раскручивание рекурсии от N до 1
string StringOfNumbers(int stop, int start = 1)
{
    if (start == stop)
    {
        Console.WriteLine($"Stop recursion: start = {start}");
        return Convert.ToString(start);
    }
    Console.WriteLine(Convert.ToString(start));
    string res = start + " " + StringOfNumbers(stop, start + 1);
    Console.WriteLine($"Возврат: start = {start}, res = {res}");
    return res;
}

// Функция вывода всех натуральных чисел от 1 до N
void SequenceOfNumbers(int stop, int start = 1)
{
    if (stop < start) return;
    SequenceOfNumbers(stop - 1, start);
    Console.Write($"{stop} ");
}

// Функция вывода всех натуральных чисел от N до 1
void rSequenceOfNumbers(int stop, int start = 1)
{
    if (stop < start) return;
    Console.Write($"{stop} ");
    rSequenceOfNumbers(stop - 1, start);
}

// **********     Тело программы     **********
Console.Write("Введите число: ");
string input = Console.ReadLine()!;
int number;
if (int.TryParse(input, out number) && (number > 0))
{
    Console.WriteLine(rStringOfNumbers(number));
    Console.WriteLine();
    Console.WriteLine(StringOfNumbers(number));
    Console.WriteLine();
    SequenceOfNumbers(number);
    Console.WriteLine();
    rSequenceOfNumbers(number);
}
else
{
    Console.WriteLine("Некорректный ввод");
}

