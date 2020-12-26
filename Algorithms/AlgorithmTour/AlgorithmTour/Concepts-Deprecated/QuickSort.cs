using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.ConceptsDeprecated
{
    class QuickSortPOC
    {
        //QuickSort Routine
        public void QuickSort(int[] A, int start, int end)
        {

            Console.WriteLine("start = " + start + " End = " + end);
            if (start >= end) return;

            // rearrange the elements across pivot
            int pivot = Partition(A, start, end);
            Console.WriteLine("selected Pivot : " + A[pivot]);
            // recur on sub-array containing elements less than pivot
            QuickSort(A, start, pivot - 1);

            // recur on sub-array containing elements that are more than pivot
            QuickSort(A, pivot + 1, end);

        }

        // Partition using Lomuto partition scheme
        private int Partition(int[] a, int start, int end)
        {
            
            // Pick rightmost element as pivot from the array
            int pivot = a[end];

            // elements less than pivot will be pushed to the left of pIndex
            // elements more than pivot will be pushed to the right of pIndex
            // equal elements can go either way
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
               
                if (a[i] <= pivot)
                {
                    Swap(a, i, pIndex);
                    pIndex++;
                }
            }
            // swap pIndex with Pivot
            Swap(a, end, pIndex);

            // return pIndex (index of pivot element)
            return pIndex;


        }
        //Swap the values
        private void Swap(int[] a, int i, int pIndex)
        {
            int temp = a[i];
            a[i] = a[pIndex];
            a[pIndex] = temp;
        }
    }
}
