using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.ArrayDS_Algo
{
    /*
        Problem Statement :: Given a binary array, sort it in linear time and constant space. Output should print contain all zeroes 
        followed by all ones.
        For example :
        input   = {1,0,1,0,1,0,0,1}
        output  = {0,0,0,0,1,1,1,1} 
     */
    class SortBinary
    {
        public void Sort_Binary(int[] A)
        {
            int zero = 0;
            foreach (int value in A)
            {
                if(value == 0)
                {
                    zero++;
                }
            }

            //put '0' in the begining
            int k = 0;
            while(zero-- != 0)
            {
                A[k++] = 0;
            }

            while (k < A.Length)
            {
                A[k++] = 1;
            }

        }


        public void Sort_Binary_V1(int[] A)
        {
            int k = 0;
            foreach (int value in A)
            {
                if (value == 0)
                {
                    A[k++] = 0;
                }
            }

            while (k < A.Length)
            {
                A[k++] = 1;
            }

        }

        //Using Linear time by using partitioning logic of QuickSort
        public void Sort_Binary_V2(int[] A)
        {
            int pivot = 1;
            int j = 0;
            for(int i=0; i<A.Length; i++)
            {
                if(A[i] < pivot)
                {
                    swap(A, i, j);
                    j++;
                }
            }
        }

        private void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
