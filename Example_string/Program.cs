string [,] table = new string [2, 5];
// String.Empty для строк инициализация 
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]
table [1, 2] = "слово"; //обращение к элементу из 1 строки 2го столбца

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}