// Задание 1
// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.

// Простое число - натуральное число, отличное от 1 
// и делится без остатка только на 1 и на себя.

// Функция заполнения массива
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 1000);        
    }
}

// Функция вывода элементов массива на консоль
void PrintArray(int[] collection)
{
    foreach (int item in collection)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

// Функция определения является ли число простым 
// (через массив простых чисел от 2 до 97)
int AmountPrimeNumbersArray(int[] collection)
{
    int[] prime_numbers = {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};
    int result = 0;
    Console.WriteLine();
    foreach (var item in collection)
    {
        foreach (var item_prime in prime_numbers)
        {
            if (item == item_prime) 
            {
                result++;
                Console.Write($"{item} ");
            }
        }
    }
    return result;
}

// Функция определения является ли число простым 
// (через остаток от деления)
int AmountPrimeNumbersRemDiv(int[] collection)
{
    int result = 0;
    bool is_prime_number = true;
    Console.WriteLine();
    foreach (var item in collection)
    {
        is_prime_number = true;
        for (int i = 2; i < item; i++)
        {
            if (item % i == 0) is_prime_number = false;
        }
        if (is_prime_number && (item > 1)) 
        {
            Console.Write($"{item} ");
            result++;
        }
    }
    return result;
}

// Тело 
Console.Write("Введите размерность массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
FillArray(arr);
PrintArray(arr);

// int amount1 = AmountPrimeNumbersArray(arr);
// Console.WriteLine();
// Console.WriteLine($"{amount1} простых чисел в массиве");
int amount2 = AmountPrimeNumbersRemDiv(arr);
Console.WriteLine();
Console.WriteLine($"{amount2} простых чисел в массиве");
