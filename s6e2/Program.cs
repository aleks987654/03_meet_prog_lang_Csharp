// Семинар 6. Массивы и строки
// Задание 2
// На основе символов строки (тип string) 
// сформировать массив символов (тип char []). 
// Вывести массив на экран

// !!!  Указание: Метод строки ЕщСрфкФккфн() не использовать
// Пример: "Hello!" => ['H', 'e', 'l', 'l', 'o', '!]'

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[] ArrayCharsFromString(string str)
{
    // int l = str.Length;
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintArrayChars(char[] chars)
{
    foreach (var item in chars)
    {
        Console.Write($"{item}\t");
    }
}

string n = Console.ReadLine()!;
PrintArrayChars(ArrayCharsFromString(n));