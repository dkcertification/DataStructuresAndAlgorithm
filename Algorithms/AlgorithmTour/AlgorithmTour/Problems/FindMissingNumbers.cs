using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Problems
{
    class FindMissingNumbers
    {
        public void FindMissingNumber(int[] numbers)
        {
            //3,7,1,2,8,4,5 :: O(N^3)
            for (int i = 0; i < numbers.Length - 1; i++) //N
            {
                for (int j = 0; j < numbers.Length - 1; j++) //N
                {
                    if (numbers[j] > numbers[j + 1]) //N
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));


            //O(N^2)
            for (int i = 0; i < numbers.Length - 1; i++) //N
            {
                if (!(numbers[i + 1] == ++(numbers[i]))) //N
                {
                    Console.WriteLine("Mising Number : " + ((numbers[i])));
                    return;
                }
            }

        }


        public void FindMissingNumber_V1(int[] numbers)
        {
            //GET MAX (A) //Recursive Function MAX
            //GET MIN (B) //Recursive Function Min

            //SUM UP ALL VALUES BETWEEN MIN AND MAX (C)
            //SUM UP ALL VALUES IN THE ARRAY (D)

            //Missing Number is :: C-D
        }

        public void FindMissingNumber_V2(int[] number)
        {
            //NEW THOUGHTS???
            //LINEAR SCAN O(n) :: Summing up all the numbers in the int Array :: B
            // Find Expected Sum of First n numbers using Arithmetic series sum formula :: A
            //Missing Number is :: A-B
        }
    }
}