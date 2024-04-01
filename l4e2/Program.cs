// Лекция 4. Двумерные массивы
// Задача 2
// Назовём число "интересным", если сумма его цифр чётное число.
// Создать двумерный массив, состоящий из целых чисел.
// Вывести на экран "интересные" элементы массива

// Функция создания двумерного массива целых чисел 
// и заполнения его случайными числами
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

// Функция вывода элементов двумерного массива целых чисел на консоль
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Функция вычисления суммы цифр числа
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

// Функция определения "интересности" числа
bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0) return true;
    return false;
}

// **********   Тело программы   **********
int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
Console.WriteLine();
foreach (var e in matrix)
{
    if (IsInteresting(e))
    {
        Console.Write($"{e}\t");
    }
}