// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

double[] SrAr(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(0)];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        result[i] = (double)sum / matrix.GetLength(1);
    }
    return result;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " " );
    }
    System.Console.WriteLine("");
}






int[,] matrix = CreateRandomMatrix(rows, columns, min, max);
PrintMatrix(matrix);
PrintArray(SrAr(matrix));