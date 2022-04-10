// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = RandomArray(3, 4);
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Отсортированный массив по убыванию элементов в строках:\n");
int row = array.GetLength(0);
int column = array.GetLength(1);
PrintSortArray(SortArray(array, row, column));



int[,] RandomArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("\n");
    }
}

int[,] SortArray(int[,] array, int row, int column)
{
    for (int i_sort = 0; i_sort < array.GetLength(0); i_sort++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
            {
                if (array[i_sort, j] < array[i_sort, j - 1])
                {
                    int temp = array[i_sort, j];
                    array[i_sort, j] = array[i_sort, j - 1];
                    array[i_sort, j - 1] = temp;
                }
            }
        }
    }
    return array;
}

void PrintSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, array.GetLength(1) - 1 - j]} ");
        }
        Console.WriteLine("\n");
    }

}


