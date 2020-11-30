using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Problems
{
    class SumOfNumberInArray
    {

        public bool SumOfNumberInArray_V0(int[] values, int _expectedValue)
        {
            //BRUTE FORCE LOGIC
            for (int i = 0; i < values.Length - 1; i++) //=N
            {
                for (int j = i + 1; j < values.Length - 1; j++) //=N
                {
                    if (values[i] + values[j] == _expectedValue) // GENERATE AND TEST
                    {
                        return true;
                    }
                }
            }
            return false;

            /*
            Time Complexity = O(N*N) = O(N^2)
            Space Complexity = O(1)
             */

        }

        public void SumOfNumberInArray_V1(int[] values, int _expectedValue)
        {

            for (int i = 0; i < values.Length - 1; i++)
            {
                var valuetoSearch = _expectedValue - values[i];
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] == valuetoSearch)
                    {
                        Console.WriteLine("Pair : [" + values[i] + ", " + values[j] + "]"); ;
                    }

                }

            }
        }

        /*
         * Find frequency of each element in a limited range array in less than O(n) time
            Given a sorted array of positive integers, the count number of occurrences for each element in the array. 
            Assume all elements in the array are less than some constant M.
            Do this without traversing the complete array. i.e. expected time complexity is less than O(n). 
        */
        public bool SumOfNumberInArray_V2(int[] values, int _expectedValue)
        {
            HashSet<int> visitedValue = new HashSet<int>();
            foreach (int v in values)
            {
                if (visitedValue.Contains(_expectedValue - v)) // O(1) :: Lookup
                {
                    return true;
                }
                visitedValue.Add(v); // O(1) :: Insertion
            }
            return false;
            /*
                Time Complexity = O(n)
                Space Complexity = O(n)
                Tool Used :: HashSet / lookup insertion             
             */

    }

    public bool SumOfNumberInArray_V3(int[] values, int _expectedValue)
        {
            //pseudo
            /*
             * values = {1,2,3,4,5,7,8}
            1. Sort the array
            2. assign Left pointer = 0
            3. assign Right pointer to end of sorted array
            4. loop while Left < Right
            5. check for values[Left] + values[Right] == _expectedValue?return true;
            6. check for values[left] + values[Right] < k
            7. increment Left pointer to 1
            8. check for values[Left] + values[Right] > k // only for psuedo
            9. decrement Right pointer to 1
             */

            /*
            Time Complexity = O(nlogn)
            Space Complexity = O(1) if allowed to modify the Input
            O(n) if not allowed to modify the input. 
            Can be acheived by using Sorting
             */
            return false;
        }
    }
}