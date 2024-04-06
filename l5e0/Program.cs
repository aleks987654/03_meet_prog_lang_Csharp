// Лекция 5. Рекурсия
// Пример 0

void OpenMatryoshka(int size)
{
    // Базовый случай: самая маленькая матрёшка
    if (size == 1)
    {
        // Console.WriteLine("Reaches the smallest matryoshka!");
        return;
    }
    Console.WriteLine($"Opening matryoshka of size {size}...");
    OpenMatryoshka(size - 1);
}

void rOpenMatryoshka(int size)
{
    // Базовый случай: самая маленькая матрёшка
    if (size == 1)
    {
        // Console.WriteLine("Reaches the smallest matryoshka!");
        return;
    }
    rOpenMatryoshka(size - 1);    
    Console.WriteLine($"Opening matryoshka of size {size}...");
}

// **********     Тело программы     **********
OpenMatryoshka(5);
Console.WriteLine();
rOpenMatryoshka(5);