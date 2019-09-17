using AEI.Sorting;
using System;

namespace ConsolePlaygroundCore
{
    /// <summary>
    /// Tests for the bubble sort algorithm
    /// </summary>
    class BubbleSortTest
    {
        /// <summary>
        /// Test with integer array
        /// </summary>
        public static void IntTest()
        {
            // Make array
            int[] bubbleArray = new int[10]
            {
                5, 2, 1, 5, 7, 55, 3, 23, 14, 6
            };

            // Print array
            Console.WriteLine("Original");
            foreach (int number in bubbleArray)
            {
                if (number != bubbleArray[bubbleArray.Length - 1])
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }

            // Sort and print array in ascending order
            bubbleArray = BubbleSort.SortIntArrayAscending(bubbleArray);
            Console.WriteLine("\nSorted Ascending");
            foreach (int number in bubbleArray)
            {
                if (number != bubbleArray[bubbleArray.Length - 1])
                {
                    Console.Write(number + ", ");
                }
                else
                {
                    Console.Write(number);
                }
            }

            // Sort and print array in descending order
            bubbleArray = BubbleSort.SortIntArrayDescending(bubbleArray);
            Console.WriteLine("\nSorted Descending");
            foreach (int number in bubbleArray)
            {
                if (number != bubbleArray[bubbleArray.Length - 1])
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
