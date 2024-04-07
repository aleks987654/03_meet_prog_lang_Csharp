// Семинар 7. Рекурсия
// Пример 3
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// !!! Указание: Использовать рекурсию. Не использовать цикл

using System;

const string consonants =  "bcdfghjklmnpqrstvwxyz";

// char[] consonants =  {'b','c','d','f','g','h','j','k','l','m',
//                       'n','p','q','r','s','t','v','w','x','y','z'};

// Функция вывода всех согласных букв в строке САМОСТОЯТЕЛЬНО
void PrintConsonantsOfString(string str, int n)
{
    if (n < 0 ) return;
    PrintConsonantsOfString(str, n - 1);
    //string str2 = str.ToLower();
    if (consonants.Contains(Convert.ToString(str[n]).ToLower()))
    Console.Write($"{str[n]} ");
}

// Функция вывода всех согласных букв в строке ПОСЛЕ ПРЕПОДА
void pPrintConsonantsOfString(string str)
{
    if (str.Length == 0) return;
    if (consonants.Contains(Convert.ToString(str[0]).ToLower()))
    Console.Write($"{str[0]} ");
    pPrintConsonantsOfString(str[1..]);    
}

// **********     Тело программы     **********
Console.Write("Введите строку на латинице: ");
string input = Console.ReadLine()!;
if (input != "")
{
    PrintConsonantsOfString(input, input.Length - 1);
    Console.WriteLine();    
    pPrintConsonantsOfString(input);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
