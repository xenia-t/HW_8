// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = RandomArray(3, 4);
Console.WriteLine();
PrintArray(array);

int[] sumElem = FindSum(array);
PrintSum(sumElem);
Console.WriteLine($"\n\nСтрока с наименьшей суммой элементов: {FindMinIndex(FindSum(array)) + 1}\n");



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
        Console.WriteLine();
    }
}

int[] FindSum(int[,] array)
{
    int[] sumElem = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElem[i] += array[i, j];
        }
    }
    return sumElem;
}

void PrintSum(int[] sumElem)
{
    for (int i = 0; i < sumElem.Length; i++)
    {
        Console.Write($"\nСумма строки {i + 1}: {sumElem[i]} ");
    }
}

int FindMinIndex(int[] sumElem)
{
    int min = sumElem[0];
    int min_index = 0;
    for (int i = 0; i < sumElem.Length; i++)
    {
        if (min > sumElem[i])
        {
            min = sumElem[i];
            min_index = i;
        }
    }
    return min_index;
}