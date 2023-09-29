/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void SpiralMatrix(int[,] matrix) 
{
   int value = 1; 
    int startRow = 0; 
    int startCol = 0; 
    int endRow = 3; 
    int endCol = 3; 
    while (startRow <= endRow && startCol <= endCol) 
    {
        for (int i = startCol; i <= endCol; i++) 
        {
             matrix[startRow, i] = value++;
        }
        startRow++;
        for (int i = startRow; i <= endRow; i++) 
        {
            matrix[i, endCol] = value++; 
        }
        endCol--;
        if (startRow <= endRow) 
        {
            for (int i = endCol; i >= startCol; i--) 
            {
                matrix[endRow, i] = value++; 
            }
            endRow--;
        }
        if (startCol <= endCol) 
        {
            for (int i = endRow; i >= startRow; i--) 
            {
                matrix[i, startCol] = value++; 
            }
            startCol++;
        }
}
}
void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] Matrix = GetMatrix(4, 4);

SpiralMatrix(Matrix);

PrintMatrix(Matrix);
