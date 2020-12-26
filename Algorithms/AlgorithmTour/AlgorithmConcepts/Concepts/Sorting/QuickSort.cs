using AlgorithmConcepts.Concepts.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts
{
    /*
      Strategy in use is Divide and Conquer
    It is a recursive algorithm as well as mergesort as it divides the problem into sub problems and solving each problem
    It automatically solves the whole
    Splitting based on Pivot Elements || Elements < Pivot go to its left and Elements > Pivot go to its right
    Pivot get into its place at the end of each pass

    Characterstics:
    In place algorithm 
    Time Complexity : O(nlogn) => linearithmic
    Extremely rare case, time complexity go to O(n^2)
    Unstable

    */
    public class QuickSort : SortingBaseUtil
    {

        public static void Sort(int[] array)
        {
            sort(0, array.Length - 1);

            //Recursive Function
            void sort(int low, int high)
            {
                //Base case::
                if (high <= low)
                    return;
                int j = partition(low, high);
                sort(low, j - 1);
                sort(j + 1, high);
            }

            //Partitioning Logic
            int partition(int low, int high)
            {
                int i = low;
                int j = high + 1;
                int pivot = array[low];


                //Sorting at Left and Right Of the Pivot
                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high)
                            break;
                    }

                    while (pivot < array[--j])
                    {
                        if (j == low)
                            break;
                    }
                    if (i >= j)
                        break;
                    swap(array, i, j);

                }
                swap(array, low, j);
                return j;
            }
        }
    }
}
