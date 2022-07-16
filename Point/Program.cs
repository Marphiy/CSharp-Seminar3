void Point17()
{
    Console.Clear();
    Console.Write("Введите координату точки a (0 - 10): ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите координату точки b (0 - 10): ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (a > 0 && b > 0) Console.WriteLine($"Точка с координатами ({a}, {b}) относится к плокости 1");
    if (a < 0 && b > 0) Console.WriteLine($"Точка с координатами ({a}, {b}) относится к плокости 2");
    if (a < 0 && b < 0) Console.WriteLine($"Точка с координатами ({a}, {b}) относится к плокости 3");
    if (a > 0 && b < 0) Console.WriteLine($"Точка с координатами ({a}, {b}) относится к плокости 4");
    if (a == 0 || b == 0) Console.WriteLine($"Точка с координатами ({a}, {b}) Лежит на оси координат");
}

void Point18()
{
    Console.Clear();
    int a = new Random().Next(1, 5);
    if (a == 1) Console.WriteLine($"Точка, лежащая в координатной плоскости {a} имеет координаты (0 < x <11, 0 < y <11");
    if (a == 2) Console.WriteLine($"Точка, лежащая в координатной плоскости {a} имеет координаты (-10 < x < 0, 0 < y <11");
    if (a == 3) Console.WriteLine($"Точка, лежащая в координатной плоскости {a} имеет координаты (-10 < x < 0, -10 < y < 0");
    if (a == 4) Console.WriteLine($"Точка, лежащая в координатной плоскости {a} имеет координаты (0 < x <11, -10 < y <0");
    if (a < 1 && a > 4) Console.WriteLine($"Такой координатной плоскости не суцществует!");
}

void Point19()
{
    Console.Clear();
    Console.WriteLine("Введите любое число от 10 до 1001: ");
    string num = Console.ReadLine();
    char[] revnum = num.ToCharArray();
    Array.Reverse(revnum);
    string newstring = new string(revnum);
    if (num == newstring) Console.WriteLine($"Число {num} - палиндром!");
    else Console.WriteLine($"Число {num} - НEпалиндром!");
}

void Point19_1()
{
    Console.Clear();
    Console.WriteLine("Введите любое число от 10 до 1001: ");
    string num = Console.ReadLine();
    bool pal = true;
    for (int i = 0; i < num.Length - 1; i++)
    {
        if (num[i] != num[num.Length - 1 - i])
        {
            pal = false;
            break;
        }
    }
    if (pal == true) Console.WriteLine($"Число {num} - палиндром!");
    else Console.WriteLine($"Число {num} - НЕпалиндром!");
}

void Point20()
{
    
    Console.Clear();
    int ax = new Random().Next(0, 11);
    int ay = new Random().Next(0, 11);
    int az = new Random().Next(0, 11);
    int bx = new Random().Next(0, 11);
    int by = new Random().Next(0, 11);
    int bz = new Random().Next(0, 11);
    int xdist = 0;
    int ydist = 0;
    int zdist = 0;
    if (ax >= bx) xdist = ax - bx;
    else if (ax <= bx) xdist = bx - ax;
    if (ay >= by) ydist = ay - by;
    else if (ay <= by) ydist = by - ay;
    if (az >= bz) ydist = az - bz;
    else if (az <= bz) zdist = bz - az;
    double dist = Math.Sqrt(Math.Pow(xdist, 2) + Math.Pow(ydist, 2) + Math.Pow(zdist, 2));
    Console.WriteLine($"Расстояние между точками ({ax}, {ay}, {az}) и ({bx}, {by}, {bz}) = {Math.Round(dist, 2)}");
}


void Point21()
{
    Console.Clear();
    int ax = new Random().Next(0, 11);
    int ay = new Random().Next(0, 11);
    int bx = new Random().Next(0, 11);
    int by = new Random().Next(0, 11);
    int xdist = 0;
    int ydist = 0;
    if (ax >= bx) xdist = ax - bx;
    else if (ax <= bx) xdist = bx - ax;
    if (ay >= by) ydist = ay - by;
    else if (ay <= by) ydist = by - ay;
    double dist = Math.Sqrt(Math.Pow(xdist, 2) + Math.Pow(ydist, 2));
    Console.WriteLine($"Расстояние между точками ({ax}, {ay}) и ({bx}, {by}) = {Math.Round(dist, 2)}");
}

void Point22()
{
    Console.Clear();
    int num = new Random().Next(1, 10);
    double i = 1;
    Console.Write($"Квадраты чисел от 1 до {num}: ");
    while (i <= num)
    {
        Console.Write($"{Math.Round(Math.Pow(i, 2))}, ");
        i ++;
    }
    Console.WriteLine("");
}

void Point23()
{
    Console.Clear();
    int num = new Random().Next(1, 10);
    double i = 1;
    Console.Write($"Кубы чисел от 1 до {num}: ");
    while (i <= num)
    {
        Console.Write($"{Math.Round(Math.Pow(i, 3))}, ");
        i ++;
    }
    Console.WriteLine("");
}

//Point17();
//Point18();
//Point19();
//Point19_1();
//Point20();
//Point21();
//Point22();
//Point23();