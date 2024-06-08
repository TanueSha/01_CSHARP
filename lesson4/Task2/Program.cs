﻿// ЗАДАЧА 2
// 1. Назовем число "интересным" если его сумма цифр четная
// 2. Создать двумерный массив, состоящий из целых чисел Вывести на экран "интересные" элементы массива

// ШАГИ
// 1. Создание массива и заполните его случайными числами
// 2. Проход по элементам массива
// 3. проверить его на : четность, делится ли на 3, положительный ли он и т.д.
// 4. Здесь: проверка на "интересность" - делится ли на 2
// * "интересность" 
// а. Вычисление суммы цифр числа
// б. Проверка суммы чисел на четность
// 5. Вывод элемента на экран, если он "интересный"

// ЧТО МОЖНО ОФОРМИТЬ КАК ФУНКЦИЯ
// 1. формирование массива CreateArray
// 2. проверка элемента на "интересность" IsInteresting *"любая функция-проверка Is...
// а. вычесление суммы цифр числа SumOfDigits
// б. проверка суммы чисел на четность IsEven

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

// Создаем двумерный массив и вызовем функции создания двумерного массива
int[,] matrix = CreateMatrix(3, 4); // точка входа в этот (весь), которая находится вне функции

// Создадим цикл, который будет осуществлять перебор элементов массива
foreach (int e in matrix)

// в цикле нам нужно проверить каждый элемент на интересность
{
    if (IsInteresting(e) == true)
   {
        System.Console.WriteLine(e);
    }
    // else не нужен, так как "неинтересные" нам не нужны
}

// напишем реализацию функции IsInretesting
// возвращать она будет значение типа bool
// на вход она будет принимать один параметр - целое число, которое подлежит проверки value

bool IsInteresting(int value)
// функция IsInteresting состоит из 2х подзадач:1) вычесление суммы цифр и проверка(вынесем в отдельную функцию) их на четность
// поместим сумму цифр в соответствующую переменную sumOfDigits, она будетиметь целый тип int, и назовем функцию для вычесления этой суммы GetSumOfDigits

{
    int sumOfDigits = GetSumOfDigits(value);
    // проверить четность функция IsEven. Она будет состоять из одной строки (деление числа на %2 ==0)
    // это деление можно выполнить прямо из функции IsInteresting и не создавать дополнительной функции IsEven
    if (sumOfDigits % 2 == 0)
    {
        // если это так, то сразу можно вернуть значение функции
        return true;
    }
    // если нет, можем вернуть значение false
   // else
    //{
    return false;
   // }
}

// пишем реализацию функцию по подсчету суммы цифр

int GetSumOfDigits (int value)
// алгоритм обращения к цифрам числа
{
    //заведем переменную для хранения суммы цифр
    int sum = 0; 
    // организуем цикл while, в которм будем получать цифры числа по одной, начиная с конца
    while (value > 0)
    {
        // в теле цикла прибавим к переменной sum очередную цифру числа
        sum = sum + value / 10;
        // чтобы перейти к следующей цифре поделим на 10
        value = value / 10;
    }
    // когда цикл закончится веренм значение функции
    return sum;
}
