using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Concepts
{
    class Sub_Array
    {

        public void PrintSubArray(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i; j < arr.Count; j++)
                {
                    for (int k = i; k <= j; k++)
                        Console.Write(arr[k] + " ");
                    Console.WriteLine("");
                }
            }
        }
    }
}
