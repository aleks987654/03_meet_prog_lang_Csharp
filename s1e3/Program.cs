// Напишите программу, которая принимает на вход трёхзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа

// Console.WriteLine("Введите целое трёхзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// // мой
// int number1 = n / 100;
// int number2 = (n - number1 * 100) / 10;
// int number3 = n - number1 * 100 - number2 * 10;

// Console.WriteLine($"{number1}\t{number2}\t{number3}");
// Console.WriteLine(number1 + number3);

// // Иван
// int first = n % 10;
// int second = n / 10 % 10;
// int third = n / 100;

// Console.WriteLine($"{third}\t{second}\t{first}");
// Console.WriteLine(first + third);

// Марина условие
// '||' = ИЛИ
// '&&' = И
// if (n < 100 || n > 999) {}

// Препод
string n = Console.ReadLine()!;

if (n.Length != 3)
{   
    Console.WriteLine("это не трёхзначное число");
}
else
{
    // Console.WriteLine(n[0]);
    // Console.WriteLine(n[1]);
    // Console.WriteLine(n[2]);

    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) 
                        + Convert.ToInt32(Convert.ToString(n[2])));
}

