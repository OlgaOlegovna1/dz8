/* 
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Console.Clear();

int[,] firstMartrix = new int[2, 2];
NewArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[2, 2];
NewArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[2, 2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firsMartrix, int[,] secomMartrix, int[,] resulMatrix)
{
  for (int i = 0; i < resulMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resulMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firsMartrix.GetLength(1); k++)
      {
        sum += firsMartrix[i,k] * secomMartrix[k,j];
      }
      resulMatrix[i,j] = sum;
    }
  }
}



void NewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 7);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}