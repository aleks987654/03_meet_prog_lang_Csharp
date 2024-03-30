// Урок 4. Функции. 
// Задача 3
// Напишите программу, которая перевернет одномерный массив 
// (первый элемент станет последним, второй - предпоследним и т.д.)
// Пример: [1 3 5 6 7 8] => [8 7 6 5 3 1]

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

// Функция заполнения массива случайными однозначными числами
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 10);
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

// Функция перестановки элементов в массиве в обратном порядке
void ArrayChangeInReverseOrder(int[] collection)
{
    int temp = 0;
    for (int i = 0; i < collection.Length / 2; i++)
    {
        temp = collection[collection.Length - 1 - i];
        collection[collection.Length - 1 - i] = collection[i];
        collection[i] = temp;
    }
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
        ArrayChangeInReverseOrder(arr);
        Console.WriteLine("Массив перевернут");
        PrintArray(arr);
    }
}