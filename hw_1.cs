// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(hw1());
        Console.WriteLine(hw2());
        Console.WriteLine(hw3(5, 3));
    }

    static int hw1()
    {
        int m = int.Parse(Console.ReadLine("Enter the number\n"));
        int n = int.Parse(Console.ReadLine("Enter the number\n"));
        int result = 0;
        for (int i = m; i <= n; i++)
        {
            result += i;
        }
        return result;
    }

    static void hw2()
    {
        int m = int.Parse(Console.ReadLine("Enter the number\n"));
        int n = int.Parse(Console.ReadLine("Enter the number\n"));
        for (int i = m; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    static int hw3(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m > 0 && n == 0)
        {
            return hw3(m - 1, 1);
        }
        if (m > 0 && n > 0)
        {
            return hw3(m - 1, hw3(m, n - 1));
        }
        return 0;
    }
}
