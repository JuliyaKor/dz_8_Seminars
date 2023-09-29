/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write($"{matrix[i, l]} ");
        }
        System.Console.WriteLine();
    }
}
int[] SumElementRows(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            sum += matrix[i, l];
        }
        result[i] = sum;
    }
    return result;
}
int FindIndexMinElement(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}
int rows = SetNumber("Enter number of rows");
int columns = SetNumber("Enter number of columns");
if (rows != columns )
{
    int[,] array = GetMatrix(rows, columns);
    PrintMatrix(array);
    int[]arraySumRows = SumElementRows(array);
    System.Console.WriteLine(string.Join(' ', arraySumRows));
    System.Console.WriteLine($"Тндекс строки с наименьшей суммой элементов {FindIndexMinElement(arraySumRows)}");
}
else
{
    System.Console.WriteLine("Колличество строк не должно совпадать с колличеством столбцов");
}
