/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] Matrix1 = new Int32[3, 3];
int[,] Matrix2 = new Int32[3, 3];
int[,] MatrixS = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];

randomFilling(Matrix1, 1, 5);
randomFilling(Matrix2, 1, 5);

Console.WriteLine();
Console.WriteLine("Первая матрица: ");
arrayOutput(Matrix1);
Console.WriteLine(" ");

Console.WriteLine("Вторая матрица: ");
arrayOutput(Matrix2);
Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Сумма матриц: ");
arrayOutput(matrixMultiplication(Matrix1, Matrix2));
Console.ResetColor();

int[,] matrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            MatrixS[i, j] = 0;

            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                MatrixS[i, j] += Matrix1[i, k] * Matrix2[k, j];
            }
        }
    }
    return MatrixS;
}

void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
       
        }
    }
}
//   Console.WriteLine("Summa");
void arrayOutput(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}