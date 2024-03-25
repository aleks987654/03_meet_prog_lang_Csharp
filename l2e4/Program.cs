// Задача 3: 
// Дано: N гирь с разным весом в случайном порядке.
// Найти: вес самой тяжёлой гири

int n = 5;
int[] array = { 4, 2, 7, 6, 9 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++) // счётный цикл (обычно i, j, k)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array) // цикл foreach
{
    // Console.Write($"{e} ");
    // e = 0; ERROR
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);
    
