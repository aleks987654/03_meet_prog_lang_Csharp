// Домашнее задание 1 (из 1)
// Создать функции: 
// FillArray, 
// PrintArray, 
// GetSumOfElements, 
// GetProductOfElements.

// Функция заполнения массива
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

// Функция вычисления суммы элементов массива
int GetSumOfElements(int[] collection)
{
    int sum = 0;
    foreach (int item in collection)
    {
        sum = sum + item;
    }
    return sum;
}

// Функция вычисления произведения элементов массива
int GetProductOfElements(int[] collection)
{
    int product = 1;
    foreach (int item in collection)
    {
        product = product * item;
    }
    return product;
}

Console.Write("Введите размерность массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine($"сумма равна {sum}");
Console.WriteLine($"произведение равно {product}");