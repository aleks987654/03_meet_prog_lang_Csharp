// Семинар 6. Массивы и строки
// Домашнее задание 4*
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
// Пример:  "Hello my world"    =>  "world my Hello"

// Функция получения строки со словами из заданной строки 
// расположенными в обратном порядке 

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string ReverseOrderOfWords(string s)
{
    string[] array = s.Split(" ");
    string reverse_s = "";
    for (int i = array.Length; i > 0; i--)
    {
        reverse_s = reverse_s + array[i - 1] + " ";
    }

    return reverse_s.Trim();
}

// **********     Тело программы     **********
Console.WriteLine("Hello my world");
Console.WriteLine(ReverseOrderOfWords("Hello my world"));

Console.WriteLine();
Console.WriteLine("Введите строку: ");
string input_str = Console.ReadLine()!;
Console.WriteLine(ReverseOrderOfWords(input_str));