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

void Point21()
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

//Point19();
//Point19_1();
//Point21();
//Point23();