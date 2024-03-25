// Напишите программу, которая выводит третью слева цифру
// заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32 (Console.ReadLine());
int num = Math.Abs(number);

if (num < 100) {Console.WriteLine("Третьей цифры нет");}
else 
{
    // мой математический способ
    int i = 1;
    while (i * 100 <= num) { i = i * 10; }
    int result = (num % i) / (i / 10);
    Console.WriteLine(result);

    // мой способ через строковую переменную 
    string s = Convert.ToString(num);
    int result2 = Convert.ToInt32(Convert.ToString(s[2]));
    Console.WriteLine(result2);

    // преподский математический способ
    while (num >= 100)
    {
        int result3 = num % 10;
        num /= 10; // num = num / 10;
        Console.WriteLine($"num:{num}");
        Console.WriteLine($"ответ:{result3}");
        Console.WriteLine();
    }

    // Console.WriteLine(i);
    // Console.WriteLine(num % i);
    // Console.WriteLine(((num % i)) / (i / 10));

    // int result = num % 100;
    // Console.WriteLine(result);
}
