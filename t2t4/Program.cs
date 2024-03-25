// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32 (Console.ReadLine());

if (n < 1) Console.WriteLine($"число {n} не является натуральным");
else
{
    string s = "";
    
    while ((n > 9))
    {
        s = ", " + Convert.ToString(n % 10) + s;
        // Console.WriteLine(s);    
        n /= 10;
    }

    s = Convert.ToString(n) + s;

    Console.WriteLine(s);    
}
