// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharsToString(char[] chars)
{
string result = string.Empty; // пустая строка. можно также написать string result = "";
for (int i = 0; i < chars.Length; i++) //проходимся по элементам массива
{
result += chars[i]; // склеиваем элементы массива в строку
}
return result;
}

char[] chars = {'a', 'b', 'c', 'd', 'e', '@'};

Console.WriteLine(CharsToString(chars));