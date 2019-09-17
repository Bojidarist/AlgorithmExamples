namespace AEI.Sorting
{
    /// <summary>
    /// Bubble Sort is the simplest sorting algorithm that works by 
    /// repeatedly swapping the adjacent elements if they are in wrong order.
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Sort an array of integers in ascending order
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <returns>Sorted array of integers</returns>
        public static int[] SortIntArrayAscending(int[] numbers)
        {
            // Indicates if elements are swapped
            bool swapped;

            // The index of the left element we are comparing in the array
            int leftElementIndex;

            // The index of the right element we are comparing in the array
            int rightElementIndex;

            // While there is something to swap --> loop
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    // Get the index of the left and right elements we are comparing
                    leftElementIndex = i;
                    rightElementIndex = i + 1;

                    // Swap the elements if the left one is bigger than the right one
                    if (numbers[leftElementIndex] > numbers[rightElementIndex])
                    {
                        int temp = numbers[leftElementIndex];
                        numbers[leftElementIndex] = numbers[rightElementIndex];
                        numbers[rightElementIndex] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            return numbers;
        }

        /// <summary>
        /// Sort an array of integers in descending order
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <returns>Sorted array of integers</returns>
        public static int[] SortIntArrayDescending(int[] numbers)
        {
            // Indicates if elements are swapped
            bool swapped;

            // The index of the left element we are comparing in the array
            int leftElementIndex;

            // The index of the right element we are comparing in the array
            int rightElementIndex;

            // While there is something to swap --> loop
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    // Get the index of the left and right elements we are comparing
                    leftElementIndex = i;
                    rightElementIndex = i + 1;

                    // Swap the elements if the right one is bigger than the left one
                    if (numbers[leftElementIndex] < numbers[rightElementIndex])
                    {
                        int temp = numbers[leftElementIndex];
                        numbers[leftElementIndex] = numbers[rightElementIndex];
                        numbers[rightElementIndex] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            return numbers;
        }
    }
}
