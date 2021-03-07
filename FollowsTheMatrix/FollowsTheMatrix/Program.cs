using System;
using FollowsTheMatrix;

namespace FollowsTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 0;
            int colomns = 0;
            // test commit
            Console.Write("Enter the number of rows: ");
            rows = Int32.Parse(Console.ReadLine());

            while (rows <= 0)
            {
                Console.Write("Try again: ");
                rows = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number of columns: ");
            colomns = Int32.Parse(Console.ReadLine());

            while (colomns <= 0)
            {
                Console.Write("Try again: ");
                colomns = Int32.Parse(Console.ReadLine());
            }

            try
            {
                var matrix = new Matrix(rows, colomns);
                matrix.ShowMatrixTrace();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
