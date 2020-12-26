using AlgorithmConcepts.Concepts.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts
{
    /*
     Named after Donal Shell who enhanced the Insertion Sort Algorithm and came up with a pretty fast sort Algorithm in 1959
    This algorithm is named as Shell Algorithm
    - Based on Insertion Sort
    While Insertion Sort falls under Quadratic time complexity where as Shell Sort does not 
    Insertion sort shifts only neighbour Elements which leads to a large number of Shifts
    Insertion Sort is fast on pre-sorted arrays 
    Basic Idea is to [Pre-Sort] Input and switch to Insertion Sort
    InPlace Algorithm 
    Unstable
    Complexity lies on the identification of GAP Values
    Worst Completxity = O(N^3) if sequence is (1/2 (X^3-1))
    can even be O(N^6/5) = Optimize the Algorithm by 40%
    - Low Memory device 

     */
    public class ShellSort : SortingBaseUtil
    {
        public static void Sort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - 1]; j -= gap)
                    {
                        swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }
    }
}
