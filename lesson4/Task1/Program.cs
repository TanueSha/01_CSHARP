﻿// Задача 1
// 1. Создать двумерный массив с размерами 3*5, 
//состоящий из целых чисел
//2. вывести его элементы на экран

// ШАГИ (Этапы создание массива)
// 1.Указание типа данных для двумерного массива
// int[,] запятая указывает, что индексов (измерений) у массива будет 2: один для обращения к строке, второй для обращения к элементы в этой строке или столбцу
// 2. Указание имени массива
// int[,] table
// 3. Выделение памяти под элементы массива 
// int[,] table = new int[3,5]; - поскольку массив имеет два измерения, то нужно указать из скольких одномерных массивов он будет состоять, а также размер этих массивов
// new int[3,5] - первым числом указываем количество строк в этом двумерном массиве, вторым числом количество элементов в каждой из строк

using System.Globalization;

int[,] matrix = new int[3, 5];
Random rnd = new Random();

// нужно заполнить двумерный массив, т.е. обратиться к каждому его элементу и поместить туда значение
// если был бы одномерный массив, то циклом for прошли бы кадый элемент и поместили значение
// в двумерном массиве необходимо сначала пройти по его одномерным массивам (т.е. по строкам двумерного массива), затем пройти по каждой из этих строк, 
// т.е должно получилтся 2 цикла: первый отвечает за проход по строкам, а второй по  элементам кадой сроки

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // Random rnd = new Random(); перенесем его за пределы циклом, чтобы тяжело программе не было
        matrix[i, j] = rnd.Next(1, 11);
    }
}
// выведем заполненный массив на экран. как для заполнения так и для вывода нужно перебрать все его элементы, поэтому копируем циклы for
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // нужно изменить только тело цикла
        System.Console.Write($"{matrix[i, j]} ");
        // $"{matrix[i, j]} " - называется этот способ вывода данных - интерполяция срок
    }
    // для вывода массива как таблицы (а не одномерного массива)
    System.Console.WriteLine(); // делаем перенос на новую строчку
}

// теперь оформим заполнение и вывод на экран в виде функции
// начнем с функции, которая сгенерирует двумерный массив из случайных целых чисел
// Функция CreateMatrix
//1. Что делает функция?  
//   функция будет выделять память под массив некоторого размера и заоплнять его случайными целыми числами
//2. Какие данные для этого ей нужны?
//   для выделения участка памяти нужно обязательно знать его (массива) размер, т.е размер матрицы в виде числа строк и столбцов можем передать в качестве параметров
//3. Что будет результатом ее работы (что данная функция будет возвращать)
//   функция имеет определенный результат работы - это двумерный массив, его можно вернуть в качестве возвращаемого значения

// Итак, укажем тип возвращаемого значения двумерный целочисленный массив
// int[,]
// далее укажем имя функции CreateMatrix и ее параметры (их будет два: rowCount - число строк, columsCount - количество столбцов)
int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
// код для вывода массива на экран оформляем в виде функции
// ФУНКЦИИ, КОТОРЫЕ ВЫВОДЯТ ЧТО-ТО НА ЭКРАН как правило ВОЗВРАЩАЕМОГО ЗНАЧЕНИЯ НЕ ИМЕЮТ
// поэтому указываем тип данных void, даем имя и в качестве парметров передаем двумерный массив
void ShowMatrix(int[,] matrix)
//код для вывода этого двумерного массива есть выше, копируем
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine(); 
    }
}

// проверим работоспособность функции: создадим переменную matrix для хранения массива и вызовем функцию CreatMatrix, и передадим в нее в качестве параметров некоторые размеры
int[,] _ = CreateMatrix(4, 5); //вместо _ должно быть matrix - программа не принимает
// выведем содержимое на экран - воспользуемся нашей функцией ShowMatrix  и передадим ей соответсвующую переменную
ShowMatrix(matrix);







