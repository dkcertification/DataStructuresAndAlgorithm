using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.ArrayDS_Algo
{
    class FindDuplicateInArray
    {

        //Given a limited range array of size n where array contains elements between 1 to n-1 with one element repeating, find the duplicate number in it 
        //Input: {1, 1, 3, 4, 4}
        //Output: the duplicate element is at 4

        public void FindDuplicate(int[] A)
        {
            HashSet<int> Set = new HashSet<int>();

            foreach (int value in A) // O(N)
            {
                if (Set.Contains(value))
                {
                    Console.WriteLine("The Duplicate element is " + value);
                    return;
                }
                Set.Add(value);

            }
            Console.WriteLine("No Duplicate Found !!!");
        }

        public void FindDuplicate_V1(int[] A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            //travers the Array
            for (int i = 0; i < A.Length; i++) //ON(N)
            {
                // update the frequency
                if (!map.ContainsKey(A[i])) // O(N) //space
                    map[A[i]] = 0;
                map[A[i]]++;
            }

            // traverse the hashmap
            foreach (KeyValuePair<int,
                                 int> kvp in map) //ON(N)
                Console.WriteLine("Element " + kvp.Key +
                                  " occurs " + kvp.Value +
                                  " times");

            //O(N) + O(N) = O(N)
        }



        private void FindDuplicate_V2(int[] A, int low, int high, int[] frequency)
        {
            if (A[low] == A[high])
            {
                frequency[A[low]] += high - low + 1;
            }
            else
            {
                int mid = (low + high) / 2;
                FindDuplicate_V2(A, low, mid, frequency);
                FindDuplicate_V2(A, mid + 1, high, frequency);

            }
        }

        public void FindFrequency(int[] A, int n)
        {
            // create a empty vector to store frequencies
            // and initialize it by 0. Size of vector is
            // maximum value (which is last value in sorted
            // array) plus 1.
            int[] freq = new int[A[n - 1] + 1];

            //fill the vector with frequency
            FindDuplicate_V2(A, 0, n-1, freq);

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                    Console.WriteLine("Element " + i + "Occurs " + freq[i] + "times");
            }


        }


        public int isSorted(int[] collection, int end)
        {
            if (end == 0 || end == 1)
            {
                return 1;
            }

            if (collection[end - 1] < collection[end - 2])
                return 0;

            return isSorted(collection, end - 1);
        }
    }
}
