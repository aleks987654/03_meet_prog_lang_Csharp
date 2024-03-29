// Задание 1 (программа препода)
// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.

// Простое число - натуральное число, отличное от 1 
// и делится без остатка только на 1 и на себя.

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1, 100);
    }
    return Number;
}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

bool prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}

int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if (prost(i)) count++;
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMass(n);
PrintMass(mas);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");

int[] mas1 = { 1, 3, 4, 19, 3 };
PrintMass(mas1);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas1)}");

int[] mas2 = { 4, 3, 4, 1, 9, 5, 21, 13 };
PrintMass(mas2);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas2)}");
