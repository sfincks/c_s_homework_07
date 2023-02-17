//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] getMatrix(int row, int column)
{
    Random rng = new Random();
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rng.Next(1, 6);
        }
    }
    return array;
}

void printMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(" " + array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void columnMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count += array[j, i];
        }
        System.Console.Write("[" + count/array.GetLength(0) + "]" + "\t");
    }
}

int[,] matrix = getMatrix(4, 5);
printMatrix(matrix);
System.Console.WriteLine();
columnMean(matrix);