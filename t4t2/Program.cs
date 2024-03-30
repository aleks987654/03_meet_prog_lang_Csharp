// Урок 4. Функции. 
// Задача 2
// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// **********   Функции   *********
// Функция проверки корректности ввода числа с консоли
// критерии корректности:
// - содержит только цифры
// - введенное число больше ноля

bool InputNumberIsCorrect(string? check_string)
{
    int check_number = 0;
    try
    {
        check_number = Convert.ToInt32(check_string);
    }
    catch
    {
        Console.WriteLine($"{check_string} - ввод не корректен!");
        return false;
    }
    if (check_number > 0)
    {
        Console.WriteLine($"{check_string} - ввод корректен!");
        return true;
    }
    else 
    {
        Console.WriteLine($"{check_string} - ввод не корректен!");
        return false;
    }
}

// Функция заполнения массива случайными трёхзначными числами
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
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

// Функция вычисления количества чётных чисел в массиве
int GetNumberOfEvenNumbersInTheArray(int[] collection)
{
    int sum = 0;
    foreach (var item in collection)
    {
        if (item % 2 == 0) sum++;
    }
    return sum;
}


// **********   Тело программы   *********
string? input_string = "";

while (true)
{
    Console.Write("Введите размерность массива либо q для выхода: ");
    input_string = Convert.ToString(Console.ReadLine());
    if (input_string == "q" || input_string == "Q") return;
    if (InputNumberIsCorrect(input_string))
    {
        int len = Convert.ToInt32(input_string);
        int[] arr = new int[len];
        FillArray(arr);
        PrintArray(arr);
        Console.WriteLine($"{GetNumberOfEvenNumbersInTheArray(arr)} чётных чисел в массиве");
    }
}