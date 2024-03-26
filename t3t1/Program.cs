// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10, 90].

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    numbers[i] = new Random().Next(1, 101);
    Console.Write($"{numbers[i]} ");
}

int minRange = 10;
int maxRange = 90;
int amount = 0;

foreach (int e in numbers)
{
    if ((e >= minRange) && (e <= maxRange))
    {
        amount++;
    }
}

Console.WriteLine();
Console.WriteLine(amount);