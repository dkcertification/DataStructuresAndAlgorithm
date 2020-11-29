using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmTour.ArrayDS_Algo
{


    /*
     Check if subarray with 0 sum is exists or not
    Given an Array of numbers, check if array contains a sub-array having 0 Sum
    for example 
    Input : {3,4,-7, 3,1, 3,1, -4, -2, -2}
    OUput : Subarray with 0 Exists
    {3,4,-7}
    {3,1,-4}
    {4,-7, 3}

     */

    class Pair
    {
        public int first;
        public int second;
        public Pair(int _first, int _second)
        {
            first = _first;
            second = _second;
        }
    }

    class CheckZeroInSubArray
    {
       

        public bool CheckZeroInSubArray_V0(int[] A)
        {

            HashSet<int> Set = new HashSet<int>();  //1
            Set.Add(0);                             //1

            int sum = 0;                            //3

            foreach (var v in A)                     //N
            {
                sum += v;
                if (Set.Contains(sum))
                {
                    return true;
                }

                Set.Add(sum);
            }

            return false;
            /*
             Time Complexity : O(N)

             */
        }
        public void CheckZeroInSubArrayAndPrint_V1(int[] A)
        {
            // consider all sub-arrays starting from i
            for (int i = 0; i < A.Length - 1; i++) //N
            {
                int sum = 0;
                // consider all sub-arrays ending at j
                for (int j = 0; j < A.Length - 1; j++) //N 
                {
                    sum += A[j]; //N
                    // if sum is seen before, we have found a subarray with 0 sum
                    if (sum == 0)
                    {
                        Console.WriteLine("Subarray [" + i + ".." + j + "]");
                    }
                }

            }
            /*
             Time Complexity : O(N^2)

             */
        }

        public void PrintAllSubArrayWithZeroSum(int[] A)
        {

            Console.WriteLine("  { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 }");
            Console.WriteLine();

           
            for (int i = 0; i < A.Length; i++)
            {
                int sum = 0;
                
                for (int j = i; j < A.Length; j++)
                {
                    sum = sum + A[j];
                    if (sum == 0)
                    {
                        List<int> values = new List<int>();
                        for (int k = i; k <= j; k++)
                        {
                            values.Add(k);
                        }
                        Console.WriteLine("{" + string.Join(",", values) + "}");
                    }

                }

            }
        }

        public void PrintAllSubArrayWithZeroSum_V1(int[] A)
        {

            Console.WriteLine("  { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 }");
            Console.WriteLine();
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int key = 0;

            for (int i = 0; i < A.Length; i++) //N
            {
                int sum = 0;

                for (int j = i; j < A.Length; j++) //N
                {
                    sum = sum + A[j];
                    if (sum == 0)
                    {
                        List<int> values = new List<int>();
                        for (int k = i; k <= j; k++) //N
                        {
                            values.Add(k);
                        }
                        

                        map.Add(key, values);
                        key += 1;
                    }

                }
            }

            foreach(KeyValuePair<int, List<int>> entry in map)
            {
                Console.WriteLine("{" + string.Join(",", entry.Value) + "}"); 

            }
        }



        public void PrintAllSubArrayWithZeroSum_V2(int[] A)
        {

            Console.WriteLine("  { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 }");
            Console.WriteLine();
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            // create an empty vector of pairs to store  
            // subarray starting and ending index  
            List<Pair> outt = new List<Pair>();

            int sum = 0;
            for (int i = 0; i < A.Length; i++) //N
            {

                sum += A[i];
                if (sum == 0)
                {
                    outt.Add(new Pair(0, i));
                }

                List<int> al = new List<int>();
                if (map.ContainsKey(sum))
                {
                    al = map[sum];
                    
                    for (int it = 0; it < al.Count; it++)
                    {
                        outt.Add(new Pair(al[it] + 1, i));
                    }
                }

                al.Add(i);
                if (map.ContainsKey(sum))
                {
                    map[sum] = al;
                }
                else
                {
                    map.Add(sum, al);
                }
            }
            Console.WriteLine("Print From Output...");
            Console.WriteLine();
            foreach (Pair p in outt)
            {
                //Console.WriteLine("Subarray From " + p.first + " To " + p.second);
                List<int> outcome = new List<int>();
                for (int i = p.first; i <= p.second; i++)
                {
                    outcome.Add(A[i]);

                }
                Console.WriteLine("{" + string.Join(",", outcome) + "}");
                //}
                //Console.WriteLine("**************************************");
                //Console.WriteLine("Print From Dictionary <MAP>...");
                //Console.WriteLine();

                //foreach (KeyValuePair<int, List<int>> entry in map)
                //{
                //    Console.WriteLine("{ DICT Key["+ entry.Key + "] :: " + string.Join(",", entry.Value) + "}");

                //}
            }
        }
    }
}