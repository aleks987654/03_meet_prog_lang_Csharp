// Задание 4: Дано натуральное трёхзначное число.
// Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен распологаться 
// на 0-м индексе массива, старший - на 2-м.

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int max_range = Convert.ToInt32(Math.Pow(10, len));

int n = new Random().Next(100, max_range);
Console.WriteLine(n);

int[] mas1 = new int[len];
int[] mas2 = new int[len];

int n1 = n;
int n2 = n;

for (int i = 0; i < (mas1.Length - 1); i++)
{
    mas1[i] = n1 % 10;
    n1 /= 10;
}
mas1[mas1.Length - 1] = n1;

PrintMas(mas1);

int diff = 0;
for (int j = 0; j < (mas2.Length - 1); j++)
{
    diff = n2 / Convert.ToInt32(Math.Pow(10, mas2.Length - 1 - j));
    // Console.WriteLine(diff);
    mas2[j] = diff;
    n2 = n2 - diff * Convert.ToInt32(Math.Pow(10, mas2.Length - 1 - j));
    // Console.WriteLine(n2);
}
mas2[mas2.Length - 1] = n2;

PrintMas(mas2);