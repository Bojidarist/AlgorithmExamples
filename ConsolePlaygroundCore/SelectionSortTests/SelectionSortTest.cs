using AEI.Sorting;
using System;

namespace ConsolePlaygroundCore.SelectionSortTests
{
    /// <summary>
    /// Tests for the selection sort algorithm
    /// </summary>
    class SelectionSortTest
    {
        /// <summary>
        /// Test with integer array
        /// </summary>
        public static void IntTest()
        {
            // Make array
            int[] selectionArray = new int[10]
            {
                5, 2, 1, 5, 7, 55, 3, 23, 14, 6
            };

            // Print array
            Console.WriteLine("Original");
            foreach (int number in selectionArray)
            {
                if (number != selectionArray[selectionArray.Length - 1])
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }

            // Sort and print array in ascending order
            selectionArray = SelectionSort.SortIntArrayAscending(selectionArray);
            Console.WriteLine("\nSorted Ascending");
            foreach (int number in selectionArray)
            {
                if (number != selectionArray[selectionArray.Length - 1])
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }

            // Sort and print array in descending order
            selectionArray = SelectionSort.SortIntArrayDescending(selectionArray);
            Console.WriteLine("\nSorted Descending");
            foreach (int number in selectionArray)
            {
                if (number != selectionArray[selectionArray.Length - 1])
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }

            Console.WriteLine();
        }
    }
}
