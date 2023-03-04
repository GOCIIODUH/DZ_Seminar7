// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreatingMatrix(int numberRows, int numberColumns, int leftBorder, int rightBorder)
{
    double[,] matrix = new double[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().Next(leftBorder, rightBorder + 1)+ new Random().NextDouble()), 2);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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
int numberRows = InputData("Введите необходимое количество строк матрицы: ");
int numberColumns = InputData("Введите необходимое количество столбцов матрицы: ");
int leftBorder = InputData("Введите левую границу для формирования матрицы: ");
int rightBorder  = InputData("Введите правую границудля формирования матрицы: ");
PrintMatrix(CreatingMatrix(numberRows, numberColumns, leftBorder, rightBorder));
