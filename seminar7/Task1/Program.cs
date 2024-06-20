// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigits(int num)//456
{
    if(num > 0)
    {
        return num % 10 + SumOfDigits(num / 10);// 456 % 10 + 45 % 10 + 4 % 10 = 15
    }
    return 0;
}
System.Console.WriteLine(SumOfDigits(456));