//Задача 2.
//Вывод на экран квадратов чисел от 1 до N

int n = 5;

int i = 1;
while (i <= n)
{
    System.Console.Write($"{i*i} ");
    i = i + 1;
}

n = 10;
i = 1;
while (i <= n)
{
    System.Console.Write($"{i*i} ");
    i = i + 1;
}

n = 15;
i = 1;
while (i <= n)
{
    System.Console.Write($"{i*i} ");
    i = i + 1;
}

// или через функцию

void PrintSquares  (int limit)
{
    int i = 1;
    while(i <= limit)
    {
        System.Console.Write($"{i*i} ");
        i++; //i = i + 1
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
