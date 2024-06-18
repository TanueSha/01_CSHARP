// метод для заполнения двумерного массива рандомными чсилами

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
} 
// 0 8 9 6
// 1 2 7 4
// 9 4 1 6
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ", ConsoleColor.Green);
        }
        System.Console.WriteLine();
    }
}

PrintMatrix(CreateRandomMatrix(4,6,0,9));

// getLength - это встроенный метод(функция) которая принадлежит классу массива, 
//и внутри этого метода стоит условие принимающее значение0,1,2 
//которое отвечает за длину массивов(в зависимости от уровня глубины). 
//к слову, массивы могут быть и трехмерные и четырех мерные
