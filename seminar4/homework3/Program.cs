// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = {1, 2, 3, 4, 5};
int temp;

System.Console.Write("Исходный массив: "); // Вывод исходного массива * не понимаю только зачем
foreach (int i in array) 
{
    System.Console.Write(i + " ");
}

for (int i = 0; i < array.Length / 2; i++) // Переворот массива
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
System.Console.Write($"перевернутый массив: "); // Вывод перевернутого массива

foreach (int i in array) 
{
    System.Console.Write(i + " ");
}   
