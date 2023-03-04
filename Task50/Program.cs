// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] CreatingMatrix(int numberRows, int numberColumns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}
int InputData(string text)
{
    System.Console.Write(text);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int[] InputMatrix(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
void CheckInput(int[,] matrix, int[] matrixXY)
{
    int x = 0;
    if (matrixXY[0] <= matrix.GetLength(0) && matrixXY[1] <= matrix.GetLength(1))
    {
        x = matrix[matrixXY[0] - 1, matrixXY[1] - 1];
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }
}
int numberRows = InputData("Введите необходимое количество строк матрицы: ");
int numberColumns = InputData("Введите необходимое количество столбцов матрицы: ");
int leftBorder = InputData("Введите левую границу для формирования матрицы: ");
int rightBorder = InputData("Введите правую границудля формирования матрицы: ");

int[,] myMatrix = CreatingMatrix(numberRows, numberColumns, leftBorder, rightBorder);
PrintMatrix(myMatrix);
int[] myMatrixXY = InputMatrix("Введите положение элемента матрицы (номер строки и номер столбца) через пробел");
CheckInput(myMatrix, myMatrixXY);
