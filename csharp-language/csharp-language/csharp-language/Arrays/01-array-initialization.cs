using System;

namespace Kdnc.App.Arrays
{
    public class ArrayInitialization
    {
        public static void Run()
        {
            // --- Declaration
            int[] a1;

            // --- Creating an array object
            int[] a2 = new int[50];

            // --- Initializing an array
            a2[0] = 10;
            a2[1] = 24;

            // --- Initializing an array when declaring
            // Method 1
            int[] a3 = { 0, 1, 2, 3, 10, 12 };

            // Method 2
            int[] a4 = new int[6] { 0, 1, 2, 3, 10, 12 };
        }
    }
}
