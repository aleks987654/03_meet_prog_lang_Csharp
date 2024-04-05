// Семинар 6. Массивы и строки
// Домашнее задание 3
// Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:  "aBcD1ef!-" =>  Нет
//          "шалаш"     =>  Да
//          "55655"     =>  Да

// Функция
void IsPalindrome(string s)
{
    int len = s.Length;
    string first_half = "";
    string reverse_second_half = "";
    for (int i = 0; i < len / 2; i++)
    {
        first_half = first_half + s[i];
        reverse_second_half = reverse_second_half + s[len - 1 - i];
    }
    Console.WriteLine(first_half);
    Console.WriteLine(reverse_second_half);
    Console.Write($"Строка '{s}' - палиндром? Ответ: ");
    if (first_half == reverse_second_half) Console.Write("Да");
    else Console.Write("Нет");
}

string input_str = "aBcD1ef!-";
Console.WriteLine();
IsPalindrome(input_str);

input_str = "шалаш";
Console.WriteLine();
IsPalindrome(input_str);

input_str = "55655";
Console.WriteLine();
IsPalindrome(input_str);

Console.WriteLine();
Console.WriteLine("Введите строку: ");
input_str = Console.ReadLine()!;
IsPalindrome(input_str);