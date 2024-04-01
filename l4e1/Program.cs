// Лекция 4. Двумерные массивы
// Задача 1
// Создать двумерный массив с размерами 3 х 5, состоящий из целых чисел
// Вывести его элементы на экран

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
            matrix[i, j] = rnd.Next(1, 11);
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

// **********   Тело программы   **********
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);