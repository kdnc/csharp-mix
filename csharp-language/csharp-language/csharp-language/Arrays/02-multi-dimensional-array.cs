using System;

namespace Kdnc.App.Arrays
{
    public class MultiDimensionalArray
    {
        public static void Run()
        {
            // Multidimensional arrays have more than one dimension.

            // --- Creating a multi dimensional array
            int[,] matrix1 = new int[4, 2];

            // --- Initializing a multi dimensional array
            matrix1[0, 0] = 5;
            matrix1[3, 1] = 10;

            // --- Initializing a multi dimensional array when declaring
            int[,] matrix2 = { { 1, 1 }, { 2, 2 }, { 3, 5 }, { 4, 5 }, { 134, 44 } };

            // --- Accessing values of multi dimensional array
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.WriteLine("matrix2[{0}, {1}] = {2}", i, j, matrix2[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
