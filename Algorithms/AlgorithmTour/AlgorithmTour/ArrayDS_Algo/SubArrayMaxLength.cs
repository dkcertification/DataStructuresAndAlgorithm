using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.ArrayDS_Algo
{
    class SubArrayMaxLength
    {
        //Find maximum length sub-array having given sum
        //Given an array of integers, find maximum length sub-array having given sum
        //For example 
        //A[] = {5,6,-5,5,3,5,3,-2,0}
        //Sum = 8

        public void subArrayMaxLength(int[] A, int expectedValue)
        {

            // len stores the maximum length of sub-array with sum S
            int len = 0;

            // stores ending index of maximum length sub-array having sum S
            int ending_index = -1;

            for (int i = 0; i < A.Length; i++)
            {
                int sum = 0;

                //consider all subarrays are ending at j
                for (int j = i; j < A.Length; j++)
                {
                    // sum of elements in current sub-array
                    sum += A[j];

                    // if we have found a sub-array with sum S
                    if (sum == expectedValue)
                    {
                        // update length & ending index of max length subarray
                        if (len < j - i + 1)
                        {
                            len = j - i + 1;
                            ending_index = j;
                        }
                    }
                }

            }

            // print the sub-array
            Console.WriteLine("[" + (ending_index - len + 1)
                                + ", " + ending_index + "]");


        }


    }
}
