// методы-функции

// int Pow (int n)
// {
//   return n * n;
// }

// void Pow2(int n)
// {
//     System.Console.WriteLine($"Quad of {n} -> {n *n}");
// }


// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Pow(a);
// System.Console.WriteLine(Pow(a));

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// bool IsThreeDigit(int num) // метод проверяет нарехзначность да/нет
// {
// if(num > 99 && num < 1000)
// {
//     return true;
// }
// return false;
// }

//int DeleteSecondDigit(int num)
// void DeleteSecondDigit(int num)
// {
//     if(IsThreeDigit(num))
//     {
//     int ed = num % 10;
//     int sot = num / 100;
//     return ed + sot * 10;
//     }
//     else
//     {
        // System.Console.WriteLine("You input not three-digit number");
       // return 0; оcпользовали метод void
    // }
// }
// System.Console.WriteLine("Input number: ");
// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// DeleteSecondDigit(a);

// скопированный код
// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void DeleteSecondDigit(int num)
// {
//     if(IsThreeDigit(num))//456
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(ed + sot * 10);
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//     }
// }



// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// DeleteSecondDigit(a);

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondToThirdPower(int num)
// {
//     if(IsThreeDigit(num))//456
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         System.Console.WriteLine(Math.Pow(dec, ed));
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//     }
// }

// System.Console.WriteLine("Input number: " );
// int a = Convert.ToInt32(Console.ReadLine());
// SecondToThirdPower(a);



// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

using System.Security.Cryptography.X509Certificates;



bool multiplicity (int x,int y)
{
    if (x % y == 0)
    {
        return true;
    }
    return false;
}


void Result (int x, int y)
{
    if (multiplicity (x,y))
    {
        Console.WriteLine ("да");
    }
    else
    {
        Console.WriteLine ($"нет, {x % y}");
    }

}

Console.WriteLine("Input first number:   ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input secondn umber:  ");
int y = Convert.ToInt32(Console.ReadLine());
Result (x,y);

// Урок 2. Простые Алгоритмы
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
