/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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
int[,] BubbleSort(int[,] matrix) 
{ 
     for (int k = 0; k < matrix.GetLength(0); k++)  
    { 
        for (int m = 0; m < matrix.GetLength(1); m++) 
        { 
              for (int i = 0; i < matrix.GetLength(1) - 1; i++) 
            { 
                if (matrix[k, i] < matrix[k, i + 1]) 
                { 
                    int temp = matrix[i, k + 1];
                    matrix[k, i + 1] = matrix[k, i];
                    matrix[k, i] = temp;                                                
                } 
            } 
 
        } 
    }
    return matrix;
} 
   
int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetMatrix(rows, columns);
BubbleSort(matrix);
PrintMatrix(matrix);
