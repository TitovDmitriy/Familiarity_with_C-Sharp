string[,] table = new string[2, 5]; //2 строчки, 5 столбцов
//String.Empty - инициализация строк
//table[0,0] table[0, 1] table[0, 2] table[0,3] table[0, 4]
//table[1,0] table[1, 1] table[1, 2] table[1,3] table[1, 4]
table[1, 2] = "слово"; //индекс строки и столбца

/*for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-"); //интерполяция!
    }
}*/


void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) //вместо тройки
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) //вместо четвёрки
        {
            Console.Write($"{matr[rows, columns]} "); //интерполяция!
        }
    Console.WriteLine(); //чтобы был красивый вывод
    }
}
void FillArray(int[,] matr) //метод заполняющий матрицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 9] 
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);