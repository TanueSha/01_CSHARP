// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string arrayToStr(char[,] array)
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str += array[i, j];
        }
    }
    return str;
}

char[,] array = new char[,] { 
{ 'a', 'b', 'c' }, 
{ 'd', 'e', 'f' }, 
{'g', 'h', 'i' } };

System.Console.WriteLine(arrayToStr(array));