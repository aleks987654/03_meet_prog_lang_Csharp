// Семинар 6. Массивы и строки
// Домашнее задание 2
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// Функция форматирования символов строки в верхнем регистре к нижнему
string StringToLower(string str_up_low)
{
    char[,] up_low = new char[,]
    { {'A','B','C','D','E','F','G','H','I','J','K','L','M',
       'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'},
      {'a','b','c','d','e','f','g','h','i','j','k','l','m',
       'n','o','p','q','r','s','t','u','v','w','x','y','z'},};
    string str_low = "";
    char char_lower = ' ';
    foreach (char item in str_up_low)
    {
        char_lower = item;
        for (int j = 0; j < 21; j++)
        {
            if (item == up_low[0, j])
            {
                char_lower = up_low[1, j];
                break;
            }
        }
        str_low = str_low + char_lower;
    }
    return str_low;
}

Console.WriteLine("Введите строку: ");
string input_str = Console.ReadLine()!;

// Способ согласно указанию преподавателя

Console.WriteLine(input_str.ToLower());

// Способ более соответствующий, на мой взгляд, материалу урока

Console.WriteLine(StringToLower(input_str));