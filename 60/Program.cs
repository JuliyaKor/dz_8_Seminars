/*Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,,] Get3DMatrix(int rows, int columns, int depth, int minValue = 10, int maxValue = 100)
{
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = minValue + new Random().Next(maxValue - minValue);
            }
        }
    }
    return matrix;
}
void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        
    }
}
int rows = SetNumber("rows: ");
int columns = SetNumber("columns: ");
int depth = SetNumber("depth: ");

int[,,] matrix = Get3DMatrix(rows, columns, depth);

Print3DMatrix(matrix);
