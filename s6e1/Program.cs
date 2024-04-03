// Семинар 6. Массивы и строки
// Задание 1
// Задайте массив символов (тип char []). 
// Создать строку из символов этого массива.
// !!!  Указание: Конструктор строки вида string(char[]) не использовать
// Пример: ['a', 'b', 'c', 'd'] => "abcd"

// Функция создания строки из элементов массива символов
string CharsOfString(char[] arr)
{
    string st = "";
    foreach (var i in arr)
    {
        st += i; // st=st+i
    }
    return st;
}

char[] chars = new char[] { 'a', 'b', 'c', 'd' };
Console.WriteLine(CharsOfString(chars));
