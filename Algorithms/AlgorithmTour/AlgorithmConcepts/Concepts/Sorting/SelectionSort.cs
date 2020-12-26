using AlgorithmConcepts.Concepts.Util;

namespace AlgorithmConcepts.Concepts
{
    /*
    Selection of Largest element or the smallest element in each pass depending on the implementation
    In Place algorithm : Uses a small amount of extra memory (doesnt depend on n)
    Unstable : Original element will be mixed up with relative index standpoint
    Time Complexity : O(N^2) quadratic
    Degrades quickly (though usually faster than Bubble Sort) : Good as compared to bubble sort as there were very few swaps during the iteration



     */
    public class SelectionSort : SortingBaseUtil
    {
        public static void Sort(int[] array)
        {
            for (int WallIndex = array.Length - 1; WallIndex > 0; WallIndex--)
            {
                int intTracker = 0;
                for (int i = 1; i <= WallIndex; i++)
                {
                    if (array[i] > array[intTracker])
                    {
                        intTracker = i;
                    }
                }
                swap(array, intTracker, WallIndex);
            }

        }
    }
}
