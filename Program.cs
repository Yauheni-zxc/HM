
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами. m = 3, n = 4.*/

/*double[,] GetArrRandEvenNum(int rows, int rowsLenght, int genRangeEvenNumber,int probabilityNegativ=3)
{
    double[,] arr = new double[rows, rowsLenght];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rowsLenght; j++)
        {

            arr[i, j] = Math.Round(random.NextDouble() * genRangeEvenNumber, 2, MidpointRounding.ToZero);


            if (random.Next(0, probabilityNegativ) == 0)
            {
                arr[i, j] *= -1;
            }
        }
    }
    return arr;
}
void PrintArr(double[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
PrintArr(GetArrRandEvenNum(3, 4, 10));*/
/* Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает 
 значение этого элемента или же указание, что такого элемента нет.*/

/*void SearchNumImArForIndex(int[,] arr, int indexRows, int indexNumInRow)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    if(indexRows < 0 || indexRows >= rows || indexNumInRow < 0 || indexNumInRow >= rowsLenght)
    {
        Console.WriteLine($"Введены неверные индексы");
    }
    else
    {
        Console.WriteLine($"Введены индексы {indexRows} и {indexNumInRow} число по индексу = {arr[indexRows, indexNumInRow]}");
    }
}
void StartProg(int[,] arrIndex, int[,] arr)
{
    int rows = arrIndex.GetLength(0);
    int rowsLenght = arrIndex.GetLength(1);
    PrintArr(arr);
    Console.WriteLine($" ");
    int spamFirstIndex = 0;
    int spamSecondIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        spamFirstIndex = arrIndex[i, 0];
        spamSecondIndex = arrIndex[i, 1];
        SearchNumImArForIndex(arr, spamFirstIndex, spamSecondIndex);
    }
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] arrSearch = new int[,] {{0, 2}, {1, 1}, {1, 7}};
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
StartProg(arrSearch, arr);
*/

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

double[] GetArithmeticMeanColum(int[,] arr)
{
    double result = 0.0;
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    double[] resultArr = new double[rowsLenght];
    for(int i = 0; i < rowsLenght; i++)
    {
        result = 0.0;
        for(int j = 0; j < rows; j++)
        {
            result += Convert.ToDouble(arr[j, i]);
        }
        result /= Convert.ToDouble(rows);
        resultArr[i] = Math.Round(result, 1, MidpointRounding.ToZero);
    }
    return resultArr;
}
void PrintArr(int[,] arr)
{
    int rows = arr.GetLength(0);
    int rowsLenght = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($" ");
        for (int j = 0; j < rowsLenght; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine($"");
    }
}
int[,] arr = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintArr(arr);
Console.WriteLine($"");
Console.WriteLine($"Средние арифметическое = [{string.Join(", ",GetArithmeticMeanColum(arr))}].");