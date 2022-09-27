// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

void PrintArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(-99, 100);
            arg[i, j] = arg[i, j] / 10;
        }
    }
}

Console.Write("Введите длину строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину строк: ");
int colums = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[rows, colums];

FillArray(arr);
PrintArray(arr);