// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое положительное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последнее положительное число: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int firstNum, int endNum)
{
    Console.Write($"{firstNum} ");
    if (firstNum > endNum)
        NaturalNumber(firstNum - 1, endNum);
    else if (firstNum < endNum)
        NaturalNumber(firstNum + 1, endNum);
}

void PrintNaturalNumber(int firstNum, int endNum)
{
    if (firstNum == endNum)
    {
        Console.Write($"{firstNum}");
        return;
    }
    Console.Write($"{firstNum}, ");

    if (firstNum > endNum)
        PrintNaturalNumber(firstNum - 1, endNum);
    else if (firstNum < endNum)
        PrintNaturalNumber(firstNum + 1, endNum);
}

PrintNaturalNumber(firstNumber, endNumber);
Console.WriteLine();