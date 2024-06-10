// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("input number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Quad of" + x + "is" + x * x);

// Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.WriteLine("input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x == y * y)
{
System.Console.WriteLine($"x = {x}, y = {y} -> yes");
}
else
{
   System.Console.WriteLine($"x = {x}, y = {y} -> no"); 
}

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.WriteLine("input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = -n;
while(start <=n)
{
System.Console.Write(start + " ");
start++;// start = start +1;
}

// Задание 3*. Работа в сессионных залах
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >=100 && num <= 999)
{
int ed = num % 10;
int sot = num / 100;
System.Console.WriteLine("sum = " + (ed + sot));
}
else
{
    System.Console.WriteLine("You input not three-digit number");
}