void PrintArray(int[,] matr) // метод вывод на экран
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
        {
            Console.Write($"{matr[rows, col]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // заполнение масива случайными числами от 1 до 10
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);