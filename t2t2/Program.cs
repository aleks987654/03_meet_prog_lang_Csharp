// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причем Х не равен нулю и Y не равен нулю
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка

Console.Write("Введите координату X точки: ");
int x = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите координату Y точки: ");
int y = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine($"точка с координатами ({x}, {y}) лежит");

if ((x == 0) && (y == 0)) Console.WriteLine("в начале координат");

else if (x == 0) Console.WriteLine("на оси абсцисс");

else if (y == 0) Console.WriteLine("на оси ординат");

else 
{
    if  ((x > 0) && (y > 0)) 
            Console.WriteLine("в координатной четверти I плоскости");
    else if  ((x < 0) && (y > 0)) 
            Console.WriteLine("в координатной четверти II плоскости");            
    else if  ((x < 0) && (y < 0)) 
            Console.WriteLine("в координатной четверти III плоскости");
    else if  ((x > 0) && (y < 0)) 
            Console.WriteLine("в координатной четверти IV плоскости");                        
}

