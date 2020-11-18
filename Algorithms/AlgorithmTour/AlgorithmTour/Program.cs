using System;

namespace AlgorithmTour
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort _BS = new BubbleSort();
            int[] values = { 7, 4, 5, 2 };
            _BS.Sort(values);
        }
    }
}
