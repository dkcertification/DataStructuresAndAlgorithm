using AlgorithmConcepts.Concepts;
using AlgorithmConcepts.Concepts.List;
using System;

namespace AlgorithmTour
{
    class Program
    {
        #region "Other Debugs"
        //FOR ARRAYS
        //static void Main(string[] args)
        //{
        //    //FindMissingNumbers _obj = new FindMissingNumbers();
        //    //_obj.FindMissingNumber_V2(new int[] { 7, 3, 6, 2, 1, 4, 10 });


        //    //-==================================================================================

        //    //SumOfNumberInArray _obj1 = new SumOfNumberInArray();
        //    //Console.WriteLine(_obj1.SumOfNumberInArray_V0(new int[] { 5, 7, 1, 2, 8, 4, 3 }, 11));

        //    /*//
        //    int[] values = { 5, 7, 1, 2, 8, 4, 3 };
        //    int[] valueToCheck = { 10, 19 };

        //    foreach (var v1 in valueToCheck)
        //    {
        //        bool output = _obj1.SumOfNumberInArray_V1(values, v1);
        //        Console.WriteLine("findSumOfTwo(v, " + v1 + ") = " + (output ? "true" : "false"));
        //    }
        //    //_obj1.SumOfNumberInArray_V1()*/

        //    //-==================================================================================

        //    /*
        //    FirstRepeatingCharacter FRC = new FirstRepeatingCharacter();
        //    Console.WriteLine(FRC.FirstRepeatingCharacter_V0("Broccoli"));
        //    */


        //    /*RemoveDuplicatesFromArray RDFA = new RemoveDuplicatesFromArray();
        //    RDFA.RemoveDuplicatesFromArray_V0(new int[] { 1,1,1,2,2,3,4,5 });*/

        //    /*
        //    FindDuplicates FD = new FindDuplicates();
        //    Console.WriteLine(FD.FindDuplicates_V0(new int[] { 4, 5, 1, 3, 2, 1 }));
        //    */

        //    /*
        //    int[] intArr = new int[] { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };//{ 4, 2, -3, -1, 0, 4 };
        //    CheckZeroInSubArray CHZ = new CheckZeroInSubArray();
        //    CHZ.PrintAllSubArrayWithZeroSum_V2(intArr);
        //    */

        //    /*
        //    int[] A = { 1, 0, 1, 0, 1, 0, 0, 1 };

        //    SortBinary obj = new SortBinary();
        //    obj.Sort_Binary_V2(A);
        //    Console.WriteLine(string.Join(",", A));
        //    */

        //    /*Quick Sort Implementation*/
        //    //int[] A = { 1, 0, 1, 0, 1, 0, 0, 1 };

        //    /*
        //    int[] A = { 9, -3, 5, 2, 6, 8, -6, 1, 3 };

        //    int n = A.Length-1 / A[0];
        //    Console.WriteLine("n = " + n);
        //    QuickSortPOC _QSP = new QuickSortPOC();
        //    _QSP.QuickSort(A, 0, n - 1);
        //    Console.WriteLine(string.Join(",", A));
        //    */
        //    /*int[] Input = { 2, 1, 2, 3, 4 };
        //    int[] Input = { 1, 2, 2, 3, 4 };
        //    FindDuplicateInArray FDI = new FindDuplicateInArray();
        //    int n = Input.Length;
        //    FDI.FindFrequency(Input, n);
        //    */

        //    int[] A = { 10, 5, 2, 7, 1, 9 };
        //    SubArrayMaxLength SAML = new SubArrayMaxLength();
        //    SAML.subArrayMaxLength_V1(A, 15);



        //}

        //FOR STACKS ...
        //public static void Main (string[] args)
        //{
        //    //StackImplementationUsingArrays SIA = new StackImplementationUsingArrays(5);

        //    //SIA.Push(10);
        //    //SIA.Push(20);
        //    //SIA.Push(30);
        //    //SIA.Push(40);
        //    //SIA.PrintStack();
        //    //SIA.Peek();
        //    //Console.WriteLine("Item popped from Stack : {0}", SIA.Pop());
        //    //SIA.PrintStack();

        //    //StackAsLinkedList sll = new StackAsLinkedList();

        //    //sll.push(10);
        //    //sll.push(20);
        //    //sll.push(30);

        //    //Console.WriteLine(sll.pop() + " popped from stack");

        //    //Console.WriteLine("Top element is " + sll.peek());


        //    String exp = "[()]{}{[()()]()}";//"{()}[{}]";
        //    BalancedExpressions bal = new BalancedExpressions();
        //    if (bal.balParenthesis(exp))
        //    {
        //        Console.WriteLine("The expression is balanced");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The expression is not balanced");
        //    }

        //118 ms = 1kints
        //7 Sec = 4Kints
        //57 Sec for 8kints
        //var ints = Concept.ReadInt("16kints.txt").ToArray();
        //var watch = new Stopwatch();
        //watch.Start();
        //var triplets = ThreeSum.Count(ints);

        //watch.Stop();
        //Console.WriteLine(triplets);
        //Console.WriteLine($"Time Taken : {watch.Elapsed:g}");
        //Console.ReadLine();

        //BubbleSort.BubbleSortImpl(new int[] { 2, 6, 10, 20, 40, 5 });

        //}
        #endregion

        #region "Current Debugger"
        public static void Main(String[] args)
        {
            /*Quick Sort Debugger ::
            int[] array = { 5, 4, 20, 31, 80, 66, 40, 15 };

            Console.WriteLine("Before Sorting : {0}" , string.Join(" , ", array));

            QuickSort.Sort(array);

            Console.WriteLine("After Sorting : {0}", string.Join(" , ", array));*/

            /*listDemo.Run();
            listDemo.ApiMembers();
            */

            NodeBuilder.BuildAndPrintNodes();
        }
        #endregion
    }

}
