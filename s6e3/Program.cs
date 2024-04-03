// Семинар 6. Массивы и строки
// Задание 3
// Считать строку с консоли, состоящую из (латинских букв в нижнем регистре).
// Выяснить, сколько среди введённых букв гласных

// Пример: "hello" => 2
//         "world" => 1

using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int FindVowels(string str)
{
    string vowels = "АУОИЭЫЯЮЕЁауоиэыяюеёAEIOUYaeiouy";
    int amount = 0;
    foreach (var item_str in str)
    {
        foreach (var item_vowels in vowels)
        {
            if (item_str == item_vowels) 
            {
                amount++;
                break;
            }

        }
    }
    return amount;
}

Console.WriteLine("Введите строку: ");
// string n = Console.ReadLine()!;
Console.WriteLine(FindVowels(Console.ReadLine()!));

