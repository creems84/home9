// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumbers(int n)
// {
//     if (n>0)
//     {
//         System.Console.Write(n + " "); 
//         ShowNumbers(n-1);
//     }
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumFromMToN(int m, int n)
// {
//     if (m > n)
//     {
//         int temp = m;
//         m = n;
//         n = temp;
//     }
//     return SumMN(m, n);
// }

// int SumMN(int m, int n)
// {
//     if (m > n) return 0;
//     return m + SumMN(m + 1, n);
// }

// Console.WriteLine("Input number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = SumFromMToN(m, n);
// Console.WriteLine($"Sum of numbers from {m} to {n}: {sum}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Функция Аккермана
int CalculateAkkerman(int m, int n)
{
    if (m == 0)
    {
        // При m = 0 функция Аккермана равна n + 1
        return n + 1;
    }
    else if (n == 0)
    {
        // При n = 0 и m > 0 вызываем функцию Аккермана с аргументами (m - 1, 1)
        return CalculateAkkerman(m - 1, 1);
    }
    else
    {
        // При m > 0 и n > 0 вызываем функцию Аккермана с аргументами (m - 1, A(m, n - 1))
        int temp = CalculateAkkerman(m, n - 1);
        return CalculateAkkerman(m - 1, temp);
    }
}


Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The result of the Ackerman function for m = {m} and n = {n}: ");
Console.Write(CalculateAkkerman(m, n));
