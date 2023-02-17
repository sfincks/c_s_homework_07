// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int insertNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] getMatrix(int row, int column)
{
    Random rng = new Random();
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rng.Next(0, 10);
        }
    }
    return array;
}

// void printMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

void highlightNumInMatrix(int[,] array, int m, int n)
{
    // System.Console.WriteLine($"[{array[m,n]}]");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                System.Console.Write("[" + array[i, j] + "]" + "\t");
            }
            else if (array.GetLength(0) - 1 < m || array.GetLength(1) - 1 < n)
            {
                System.Console.WriteLine("Такого числа в массиве нет");
                return;
            }
            else
            {
                System.Console.Write(array[i, j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

int m = insertNumber("Введите координату m");
int n = insertNumber("Введите координату n");
System.Console.WriteLine();
int[,] matrix = getMatrix(5, 5);
// printMatrix(matrix);
// System.Console.WriteLine();
highlightNumInMatrix(matrix, m, n);
