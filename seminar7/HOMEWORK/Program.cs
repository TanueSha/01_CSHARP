// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// M = 1; N = 5 -> 1 2 3 4 5

int MToN(int m, int n)
{
    if(m < n && m  > 0) 
    {
        System.Console.Write(m + " ");
        MToN(m + 1, n);
    }
    return n;
}

System.Console.WriteLine(MToN(1, 5));

