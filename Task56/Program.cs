/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = new int[5,3];
Generate2DArray(matrix);
Print2DArray(matrix);
var arr = SumLineElements(matrix); 
Console.WriteLine();
Console.WriteLine("Сумма элементов каждой строки:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Индекс строки с минимальной суммой - " + IndexMinSumLine(arr));

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}

int IndexMinSumLine(int[] arr)
{
    int minSumLine = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSumLine)
        {
            minSumLine = i;
        }
    }
    return minSumLine;
}

int[] SumLineElements(int[,] matrix)
{
    int[] sumLine = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = (sum + matrix[i, j]);
        }
        sumLine[i] = sum;
    }
    return sumLine;
}

void Generate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(1, 10);
        }   
    }
    return;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }   
        Console.WriteLine(); 
    }
}