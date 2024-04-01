// Лекция 4. Двумерные массивы
// Задача 3
// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

// Функция извлечения букв из строки
string GetLettersFromStr(string s)
{
    string letters = "";
    foreach (var e in s)
    {
        if (char.IsAsciiLetter(e))
        {
            letters = letters + e;
        }
    }
    return letters;
}


// **********   Тело программы   **********
string? str = Console.ReadLine();
string? letters = GetLettersFromStr(str);
Console.WriteLine(letters);