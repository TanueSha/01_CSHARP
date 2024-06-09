// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

System.Console.WriteLine("Input size of array: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: " );
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);
myArray = ChangeArray(myArray);
PrintArray(myArray);