// Задание 3: Найдите произведения пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новый массив.

// функция
void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }

    return col;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMas(new int[n]);
int[] new_mas = new int[n];
PrintMas(mas);

for (int i = 0; i < mas.Length; i++)
{
    new_mas[i] = mas[mas.Length - 1 - i];
}
PrintMas(new_mas);

