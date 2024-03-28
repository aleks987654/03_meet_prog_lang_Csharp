// Задача 1: Вычислить значение формулы
//          a x b
//          -----   ,
//          c + d
// где a, b, c, d - некоторые целые числа.
// Решение оформить в виде функции.


// функция
double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

Console.WriteLine(CalculateFormula(1, 2, 3, 4));

 