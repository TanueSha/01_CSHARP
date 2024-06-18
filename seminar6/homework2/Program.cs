// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string message = string.Empty;

string LowercaseLetters(string message)
{
      
    
    return message.ToLower();
    
}

Console.WriteLine("Введите строку из латинских букв в нижнем и верхнем регистре:");
string str = Console.ReadLine();
Console.WriteLine(LowercaseLetters(str));
