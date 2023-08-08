using MyLib;
namespace tasks;

class Program
{
    static void Main(string[] args)
    {

        void Task47()
        {
            //         Задача 47: Задайте двумерный массив размером m×n,
            // заполненный случайными вещественными числами,
            // округлёнными до одного знака.
            // m = 3, n = 4.
            // 0,5 7 -2 -0,2
            // 1 -3,3 8 -9,9
            // 8 7,8 -7,1 9

            int rows = MyLibClass.Input("Введите количество строк (M): ");
            int columns = MyLibClass.Input("Введите количество столбцов (N): ");
            double[,] Matrix = new double[rows, columns];
            MyLibClass.FillMatrix(Matrix, -10, 10);
            MyLibClass.PrintMatrix(Matrix);
        }
        Task47();


        void Task50()
        {
            // Задача 50: Напишите программу, которая на вход
            // принимает индексы элемента в двумерном массиве, и
            // возвращает значение этого элемента или же указание,
            // что такого элемента нет.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 1, 3 -> 3

            int rows = MyLibClass.Input("Введите количество строк (M): ");
            int columns = MyLibClass.Input("Введите количество столбцов (N): ");
            int[,] Matrix = new int[rows, columns];
            MyLibClass.FillMatrix(Matrix, -10, 10);
            MyLibClass.PrintMatrix(Matrix);
            int indexOfMatrixRows = MyLibClass.Input("Введите строку элемента: ") - 1;
            int indexOfMatrixColumns = MyLibClass.Input("Введите столбец элемента: ") - 1;
            if (indexOfMatrixRows >= 0 && indexOfMatrixRows < rows && indexOfMatrixColumns >= 0 && indexOfMatrixColumns < columns)
            {
                Console.Write($" Элемент = {Matrix[indexOfMatrixRows, indexOfMatrixColumns]}");
            }
            else Console.Write("Такого элемента нет!");

        }
        Task50();


        void Task52()
        {
            // Задача 52: Задайте двумерный массив из целых чисел.
            // Найдите среднее арифметическое элементов в каждом
            // столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 5 3
            // 8 4 6 4
            // Среднее арифметическое
            // каждого столбца: 4,6; 5,6; 6; 3.


            int rows = MyLibClass.Input("Введите количество строк (M): ");
            int columns = MyLibClass.Input("Введите количество столбцов (N): ");
            int[,] Matrix = new int[rows, columns];
            double sum = 0;
            MyLibClass.FillMatrix(Matrix, -10, 10);
            MyLibClass.PrintMatrix(Matrix);
            Console.WriteLine();
            for (int j = 0; j < columns; j++)
            {
                
                for (int i = 0; i < rows; i++)
                {
                    sum += Matrix[i, j];
                }
                double result = sum / rows;
                Console.WriteLine($" среднее арифметическое {j + 1} столбца = {Math.Round(result, 2)}");
            }
        }
        Task52();

    }
}
