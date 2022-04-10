// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = RandomMatrix(4, 2);
int[,] matrix2 = RandomMatrix(2, 3);
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    Console.Write("\nПроизведение заданных матриц равно\n");
    PrintMatrix(ProductMatrix(matrix1, matrix2));
}
else Console.WriteLine("Умножать матрицы можно, если число столбцов первой равно числу строк второй");


int[,] RandomMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
}