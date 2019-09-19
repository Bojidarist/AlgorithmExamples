namespace AEI.Sorting
{
    public static class SelectionSort
    {
        /// <summary>
        /// Sort an array of integers in ascending order
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <returns>Sorted array of integers</returns>
        public static int[] SortIntArrayAscending(int[] numbers)
        {
            // Get the length of the array
            int n = numbers.Length;

            // One by one move the boundary of the unsorted sub-array 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int currentMinimumIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[currentMinimumIndex])
                    {
                        currentMinimumIndex = j;
                    }
                }

                // Swap the found minimum element
                int temp = numbers[currentMinimumIndex];
                numbers[currentMinimumIndex] = numbers[i];
                numbers[i] = temp;
            }

            return numbers;
        }

        /// <summary>
        /// Sort an array of integers in descending order
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <returns>Sorted array of integers</returns>
        public static int[] SortIntArrayDescending(int[] numbers)
        {
            // Get the length of the array
            int n = numbers.Length;

            // One by one move boundary of unsorted sub-array 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the maximum element in the unsorted array
                int currentMaximumIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[currentMaximumIndex])
                    {
                        currentMaximumIndex = j;
                    }
                }

                // Swap the found maximum element
                int temp = numbers[currentMaximumIndex];
                numbers[currentMaximumIndex] = numbers[i];
                numbers[i] = temp;
            }

            return numbers;
        }
    }
}
