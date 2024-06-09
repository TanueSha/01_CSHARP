﻿// ЗАДАЧА 3
// 1. СЧИТАТЬ С КОНСОЛИ СТРОКУ, СОСТОЯЩУЮЮ ИЗ ЦИФР И ЛАТИНСКИХ БУКВ.
// 2. СФОРМИРОВАТЬ НОВУЮ СТРОКУ, СОСТОЯЩУЮ ИЗ БУКВ ИСХОДНОЙ СТРОКИ.

// ЭТАПЫ
// 1. Ввод строки с консоли Console.ReadLine()
// 2. проход по элементам строки, чтобы определить, какой из них является буквой , а какой нет. цикл for или foreach
// 3. проверка элемента: является ли он буквой. Цифровые символы не интересуют, будем пропускать. 
// Можно воспользоваться методом is letter - который принимает на вход символ и сообщает, действительно ли буквенный или нет
// 4. Если символ буквенный, то можно Дописывать его к результату. 
// Здесь поможет оператор КОНКАТИНАЦИЯ СТРОК - создадим некоторую строку. которая содержит результат и по одному символу будем дописывать в конец этой строки
// оператор КОНКАТИНАЦИЯ СТРОК - обычно это оператор сложения, но  при работе со строками он именно как конкатинация - к концу одной строки он приписывает начало другой

string GetLettersFromString(string s)
{
    string letters = ""; // переменная letters будет хранить буквы, извлеченные из строки. Пока она пустая.
    foreach(char e in s) // цикл запускаем для перебора элементов строки. foreach - т.к. элементы строки менять не собираемся
    {
       if (char.IsAsciiLetter(e) == true) //надо проверить, является ли символ "е" буквенным. используем наборы методов у типа данных char.
       {
            letters = letters + e;
       }
       return letters;
    }
}
// создадим строковую переменную и поместим в нее значение считанное с console
string str = Console.ReadLine();
//запустим созданную функцию с параметром str и сохраним ее в строковую переменную result
string result = GetLettersFromString(str);
// для проверки работы результат выводим на экран
System.Console.WriteLine(result);