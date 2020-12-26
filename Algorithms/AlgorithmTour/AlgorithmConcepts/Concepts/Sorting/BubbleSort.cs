using AlgorithmConcepts.Concepts.Util;
using System;

namespace AlgorithmConcepts.Concepts
{
    /*
     * In place algorithm 
     * O(N^2) time complexity (qudratic)
     * Degrades quickly
     * 
     * Stable VS Unstable Sorting
     * Stable:
     * - Relative Index is preserved
     * Un-Stable:
     * - Relative Index is not preserved
     * Sort Algorithm is always said to be stable when relative order of duplicate Items is preserved for all such elements of an array 
     * 
    */
    public class BubbleSort : SortingBaseUtil
    {
 
        public static void Sort(int[] array)
        {
            int size = array.Length-1;
            for (int intPartIndex = size; intPartIndex > 0 ; intPartIndex--)
            {
                for (int i = 0; i < intPartIndex; i++)
                {
                    if(array[i] > array[i+1])
                    {
                        swap(array, i, i+1);
                    }    
                }
            }
            Console.WriteLine("Sorted Array : " + string.Join(" ", array));
        }
    }
}
