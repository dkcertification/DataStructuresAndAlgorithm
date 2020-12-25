using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts
{
    public class InsertionSort
    {
        /*
        In Place algorithm : Uses a small amount of extra memory (doesnt depend on n)
        Stable algorithm 
        
        O(N^2) time complexity (quadratic)
        
        Degrades quite quickly : If Input is almost sorted then the running time will be almost linear
         - since the number of shifts will be very small. This is only the case for Insertion Sort which is not available 
         - in Bubble or SelectionSort. Bubble and Selection sort are always equal to Quadratic Time Complexity


         */
        public static void Sort(int[] array)
        {
            for (int WallIndex = 1; WallIndex < array.Length; WallIndex++)
            {
                int curUnsorted = array[WallIndex];
                int i = 0;
                for(i = WallIndex; i > 0 && array[i-1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = curUnsorted;

            }
        }
    }
}