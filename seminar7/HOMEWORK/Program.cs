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

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());


int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");


// Рекурсивная функция Аккермана
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int [] array = {1,2,3,4,5};


void PrintArrayReverse(int [] array, int i)
{
    if (i < 0)
    {
        return;
    }
    Console.Write(array[i]+ " ");
    PrintArrayReverse(array, i - 1);
    
}
PrintArrayReverse(array, array.Length - 1);