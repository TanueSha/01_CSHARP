// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

int[] InputArray(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Input {i+1} number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int ArrayCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 10 == 1 && arr[i] % 7 == 0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = InputArray(size);
System.Console.WriteLine(ArrayCounter(arr));