// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToChars(string str)
{
char[] result = new char[str.Length];
for (int i = 0; i < str.Length; i++)
{
result[i] = str[i];
}
return result;
}

void PrintArray(char[] array)
{
for(int i = 0; i < array.Length; i++)
{
System.Console.Write("'" + array[i] + "' " );
}
System.Console.WriteLine("");
}

PrintArray(StringToChars("abcdef"));