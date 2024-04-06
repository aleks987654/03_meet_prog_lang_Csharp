// Лекция 5. Рекурсия
// Пример 1
// Вычислить факториал от натурального числа N

// Функция вычисления факториала числа рекурсивным способом
int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop recursion: n = {n}");
        return 1;
    }
    Console.WriteLine(n);
    int f = Fact(n - 1);
    Console.WriteLine($"Возврат: n = {n}, fact = {f}");    
    return n * f;
}

Console.Write(Fact(5));