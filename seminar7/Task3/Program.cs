﻿// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

int Pow(int a, int b)
{
    if(a == 1) return 1;
    if(b == 0) return 1;
    return a * Pow(a, b - 1);
    
}

System.Console.WriteLine(Pow(2, 5));