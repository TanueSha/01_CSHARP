// // как работает смена местами первого и последнего элемента массива

// // int[] array = {1, 2, 3, 4, 5}; 
// // {
// //     int temp = array[0];
// //     array[0] = array[array.Length - 1];
// //     array[array.Length - 1] = temp;
   
// // }

// // foreach (int item in array)
// // {
// //     Console.Write(item + " ");
// // }

// // смена строк в двумерном массиве
//  using System;

// public class Program
// {
//     public static void Main()
//     {
//         int[,] numbers = new int[,] {
//             {1, 2, 3, 4},
//             {5, 6, 7, 8},
//             {9, 10, 11, 12}
//         };

//         int rows = numbers.GetLength(0); // количество строк
//         int cols = numbers.GetLength(1); // количество колонок

//         // Обмен первой и последней строки
//         for (int j = 0; j < cols; j++) // Проходим по всем колонкам
//         {
//             int temp = numbers[0, j]; // Сохраняем элемент первой строки
//             numbers[0, j] = numbers[rows - 1, j]; // Заменяем элемент первой строки элементом последней строки
//             numbers[rows - 1, j] = temp; // Заменяем элемент последней строки сохраненным элементом первой строки
//         }

//         // Выводим измененный массив на консоль
//         for (int i = 0; i < rows; i++) // Проходим по всем строкам
//         {
//             for (int j = 0; j < cols; j++) // Проходим по всем колонкам
//             {
//                 Console.Write(numbers[i, j] + " ");
//             }
//             Console.WriteLine(); // Переход на новую строку после каждой строки массива
//         }
//     }
// }

