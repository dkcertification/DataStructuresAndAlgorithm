using AlgorithmTour.Problems;
using System;
using System.Collections.Generic;

namespace AlgorithmTour
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindMissingNumbers _obj = new FindMissingNumbers();
            //_obj.FindMissingNumber_V2(new int[] { 7, 3, 6, 2, 1, 4, 10 });


            //-==================================================================================

            //SumOfNumberInArray _obj1 = new SumOfNumberInArray();
            //Console.WriteLine(_obj1.SumOfNumberInArray_V0(new int[] { 5, 7, 1, 2, 8, 4, 3 }, 11));

            /*//
            int[] values = { 5, 7, 1, 2, 8, 4, 3 };
            int[] valueToCheck = { 10, 19 };

            foreach (var v1 in valueToCheck)
            {
                bool output = _obj1.SumOfNumberInArray_V1(values, v1);
                Console.WriteLine("findSumOfTwo(v, " + v1 + ") = " + (output ? "true" : "false"));
            }
            //_obj1.SumOfNumberInArray_V1()*/

            //-==================================================================================

            /*
            FirstRepeatingCharacter FRC = new FirstRepeatingCharacter();
            Console.WriteLine(FRC.FirstRepeatingCharacter_V0("Broccoli"));
            */


            /*RemoveDuplicatesFromArray RDFA = new RemoveDuplicatesFromArray();
            RDFA.RemoveDuplicatesFromArray_V0(new int[] { 1,1,1,2,2,3,4,5 });*/


            FindDuplicates FD = new FindDuplicates();
            Console.WriteLine(FD.FindDuplicates_V0(new int[] { 4, 5, 1, 3, 2, 1 }));

        }
    }
}
