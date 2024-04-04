// Семинар 6. Массивы и строки
// Домашнее задание 1
// Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива.

// Пример: a b c    => "abcdef"
//         d e f

// Функция создания строки из элементов массива символов
string StringFromCharsArray(char[,] array)
{
    string sfca = "";
    foreach (var item in array)
    {
        sfca += item; // st=st+i
    }
    return sfca;
}

// **********     Тело программы     **********

// Массив из примера
char[,] chars = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
Console.WriteLine(StringFromCharsArray(chars));

// Массив свой
chars = new char[,] { { 'H', 'e', 'l', 'l','o',',',' ' },
                      { 'W', 'o', 'r','l','d','!',' ' },
                      { ' ','H', 'o', 'w',' ','a', 'r'},
                      { 'e',' ','y', 'o','u','?',' '}};
Console.WriteLine(StringFromCharsArray(chars));