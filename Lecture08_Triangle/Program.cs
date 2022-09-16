
int row = 15;

double[,] pascalTriangle = new double[row + 1, 2 * row + 1];

FillTriangle(pascalTriangle);

Console.WriteLine();
FillArray(pascalTriangle);

IsoscelesTriangle(pascalTriangle);

Console.WriteLine();
FillArray(pascalTriangle);

Console.WriteLine();


void IsoscelesTriangle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillTriangle(double[,] pascalTriangle)
{
  for (int k = 0; k < pascalTriangle.GetLength(0); k++)
  {
    pascalTriangle[k, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}

void FillArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

