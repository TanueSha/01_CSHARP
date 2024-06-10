// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// создаю массив со случайными числами
int[] array = new int[10];
Random random = new Random();
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        System.Console.Write(array[i] + " ");
    }
    
}

// считаю количество чётных чисел в массиве

int evenCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        evenCount++;
    }
}

System.Console.WriteLine($"Количество чётных чисел в массиве: " + evenCount);