using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Problems
{
    class FindDuplicates
    {
        public int FindDuplicates_V0(int[] arr)
        {
            //BRUTE FORCE
            for (int i = 0; i < arr.Length - 1; i++) //N
            {
                for (int j = i + 1; j < arr.Length; j++) //N
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }
            return 0;

            //Time Complexity = O(N^2)
            //Space Complexity = O(1)
        }
    }
}
