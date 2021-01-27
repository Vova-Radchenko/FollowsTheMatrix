using System;

namespace FollowsTheMatrix
{
    public class Matrix
    {
        private readonly int[,] _mas;

        public Matrix(int rows, int colomns)
        {
            ValidationData(rows, colomns);
            
            _mas = new int[rows, colomns];

            FillArray(_mas);
        }
        public Matrix(int [,] mas)
        {
            _mas = mas ?? throw new Exception("Your array is null!!!");

            ValidationData(mas.GetLength(0), mas.GetLength(1));            
        }

        public void ShowMatrixTrace()
        {                        
            for (int i = 0; i < _mas.GetLength(0); i++)
            {
                for (int k = 0; k < _mas.GetLength(1); k++)
                {
                    if (i == k)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(_mas[i, k].ToString() + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix's trale: {0}", GetMatrixTrace());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public int GetMatrixTrace()
        {
            int matrixTrace = 0;

            for (int i = 0; i < _mas.GetLength(0); i++)
            {
                for (int k = 0; k < _mas.GetLength(1); k++)
                {
                    if (i == k)
                    {
                        matrixTrace += _mas[i, k];
                    }
                }
            }
            return matrixTrace;
        }
        private void FillArray(int[,] mas)
        {
            var random = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int k = 0; k < mas.GetLength(1); k++)
                {
                    mas[i, k] = random.Next(101);
                }
            }
        }
        private void ValidationData(int rows, int colomns)
        {
            if (rows <= 0 || colomns <= 0)
            {
                throw new Exception("Rows or coloms < 0!!!");
            }
        }
    }
}
