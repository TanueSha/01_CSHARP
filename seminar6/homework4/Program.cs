// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string message = "Вова Таня Саша Катя";
string[] words = message.Split(' ');
for (int i = 0; i < words.Length / 2; i++)
{
    string temp = words[i];
    words[i] = words[words.Length - i -1];
    words[words.Length - i -1] = temp;

    
}
for (int i = 0; i < words.Length; i++)
{
    Console.Write(words[i] + " ");
}