// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// работает только для матрицы 4*4

int[,] CreateMatrixInt(int row, int col)
{
    int[,] matrix = new int[row, col];
    int i = 0; int j = 0;
    int num = 1;
    int size1 = matrix.GetLength(0);
    int size2 = matrix.GetLength(1);

    while (j < size1-1)
    {
        matrix[i,j++] = num++; 
    }

    while (i < size2-1)
    {
        matrix[i++,j] = num++;
    }

    while (j != 0)
    {
        matrix[i,j--] = num++; 
    }

    while (i != 1)
    {
        matrix[i--,j] = num++; 
    }

    while (matrix[i,j+1]==0)
    {
        matrix[i,j++] = num++;
    }

    while (matrix[i+1,j]==0)
    {
        matrix[i++,j] = num++;
    }
   
    while (matrix[i,j]==0)
    {
        matrix[i,j--] = num++;
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixInt(4, 4);
PrintMatrix(array2D);