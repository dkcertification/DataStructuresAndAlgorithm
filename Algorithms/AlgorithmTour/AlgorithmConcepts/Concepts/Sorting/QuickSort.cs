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
            void sort(int lowIndex, int highIndex)
            {
                //Base case::
                if (highIndex <= lowIndex)
                    return;
                int partitionIndex = derivePartition(lowIndex, highIndex);
                sort(lowIndex, partitionIndex - 1); // Left Side of Pivot Recursion
                sort(partitionIndex + 1, highIndex); //Right Side Of Pivot Recursion
            }

            //Partitioning Logic
            int derivePartition(int lowIndex, int highIndex)
            {
                int iterator = lowIndex;
                int neighbhour = highIndex + 1;
                int pivot = array[lowIndex];
                 
                //Sorting at Left and Right Of the Pivot
                while (true)
                {
                    while (array[++iterator] < pivot)
                    {
                        if (iterator == highIndex)
                            break;
                    }

                    while (pivot < array[--neighbhour])
                    {
                        if (neighbhour == lowIndex)
                            break;
                    }
                    if (iterator >= neighbhour)
                        break;
                    swap(array, iterator, neighbhour);

                }
                swap(array, lowIndex, neighbhour);
                return neighbhour;
            }
        }
    }
}
