// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


int GetPower (int number, int p)
{
    if (p == 0)
        return 1;
    // if (p == 1)
    //     return number;
    
    return number * GetPower (number, p - 1);
}

int pow = GetPower(a, b);
Console.WriteLine($"{pow}");
