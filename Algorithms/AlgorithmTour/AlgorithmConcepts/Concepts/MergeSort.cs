using AlgorithmConcepts.Concepts.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts
{
    /*
     * To Be Reviewed
     Fastest Algorithm 
    Based on Divide and Conquer
    Two Phase : Splitting & Merging 
    Splitting is logical => Provides a way to sequence the merges
    
    Not an In Place algorithm. Use much Memory (amount depends on n)
    Drawback : [TBU]
    This is stable in classic implementation 
    Worst case Time complexity = O(nlogn)[Linearithmic]
     */
    public class MergeSort : SortingBaseUtil
    {
        public static void Sort(int[] array)
        {
            int[] aux = new int[array.Length];

            sort(0, array.Length - 1);
            void sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = (high + low) / 2;
                sort(low, mid);
                sort(mid + 1, high);
                Merge(low, mid, high);
            }
            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                    return;
                int i = low;
                int j = mid + 1;
                Array.Copy(array, low, aux, low, high - low - 1);
                for (int k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
            }
        }

    }
}
