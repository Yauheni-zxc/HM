double[,] GetArrRandEvenNum(int rows, int rowsLenght, int genRangeEvenNumber, int probabilityNegativ = 3)
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
PrintArr(GetArrRandEvenNum(3, 4, 10));
