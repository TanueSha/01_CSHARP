// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string message = "а роза упала на руку Азора";


bool IsPalindrome(string message)
{
    message = message.Replace(" ", "").ToLower();

    for (int i = 0; i < message.Length / 2; i++)
    {
        if (message[i] != message[message.Length - i - 1])
        {
            Console.WriteLine("Строка не является палиндромом");
            return false;
        }
       
    }
    System.Console.WriteLine("Строка является палиндромом");
    return true;
    
}


System.Console.WriteLine(IsPalindrome(message));

