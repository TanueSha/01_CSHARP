// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int[] CompositionArray(int[] array) //хочу здесь функцию сделать, где будет все перемножаться
{
    int[] resultArray = new int[array.Length / 2];
    for(int i = 0; i < resultArray.Length; i++) 
    {
        resultArray[i] = array[i] * array[array.Length - i - 1];
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " " );
    }
    System.Console.WriteLine("");
}

System.Console.WriteLine("Input size of array");
int size = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input min of array");
int min = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input max of array");
int max = Convert.ToInt32(System.Console.ReadLine());

int[] myArray = CreateArray(size,min,max);
PrintArray(myArray);

PrintArray(CompositionArray(myArray));