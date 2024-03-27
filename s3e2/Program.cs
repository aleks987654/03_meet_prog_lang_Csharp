// Задание 2: Задайте массив из 10 элементов, 
// заполненный числами из промежутка [-10,10].
// Замените отрицательные элементы на положительные,
// а положительные на отрицательные

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
        col[i] = new Random().Next(-10, 11);
    }

    return col;
}

//int[] arr = new int[10];

//int[] mas = RandomMas(arr);
int[] mas = RandomMas(new int[10]);
PrintMas(mas);

for (int i = 0; i < mas.Length; i++)
{
    // mas[i] = - mas[i];
    mas[i] *= -1;
}
PrintMas(mas);