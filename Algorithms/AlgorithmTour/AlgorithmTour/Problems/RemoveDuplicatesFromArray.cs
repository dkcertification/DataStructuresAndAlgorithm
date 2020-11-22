using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Problems
{
    class RemoveDuplicatesFromArray
    {

        public void RemoveDuplicatesFromArray_V0(int[] arr)
        {
            Console.WriteLine("Original String = " + string.Join(" ", arr));
            int[] _retArray = new int[arr.Length - 1];
            // your code here

            HashSet<int> _v = new HashSet<int>();
            foreach (int value in arr)
            {
                //if (!_v.Contains(value))
                _v.Add(value);
            }
            _v.CopyTo(_retArray);
            Console.WriteLine("Post Duplicate Removal = " + string.Join(" ", _retArray));

            //Time Complexity : O(N)
            //Space Complexity : O(N)
        }


    }
}
