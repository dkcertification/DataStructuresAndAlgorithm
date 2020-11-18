using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour
{
    class BubbleSort
    {
        public void Sort(int[] num)
        {

            Console.WriteLine("Input Array : " + string.Join(" ", num));
            Console.WriteLine("========================================");
            int Iteration = 1;
            int size = num.Length - 1;
            for (int i=0; i< size; i++)
            {
                Console.WriteLine("Pass : " + Iteration);
                for (int j=0; j< size-i-1; j++)
                {
                    if(num[j] > num[j + 1])
                    {
                        int Temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = Temp;

                    }
                    //Console.WriteLine("-- Sorted : " + string.Join(" ", num));

                }
                //Console.WriteLine("Pass [" + Iteration++ + "] Sorted : " + string.Join(" ", num));
                Iteration++;
            }
            //Console.WriteLine("========================================");
            //Console.WriteLine("Sorted : " + string.Join(" ", num));
        }
    }
}
