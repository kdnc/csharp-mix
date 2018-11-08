using System;

namespace Kdnc.App.Arrays
{
    public class JaggedArray
    {
        public static void Run()
        {
            // A jagged array is merely an array of arrays and is called a jagged array 
            // because it doesn’t have to be rectangular.

            // --- Creating a multi jagged array
            int[][] matrix = { new int[5], new int[4], new int[2] };

            // --- Initializing a jagged array
            matrix[0][3] = 4;
            matrix[1][1] = 8;
            matrix[2][0] = 5;

            // --- Accessing values of a jagged array
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine("matrix[{0}, {1}] = {2}", i, j, matrix[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
