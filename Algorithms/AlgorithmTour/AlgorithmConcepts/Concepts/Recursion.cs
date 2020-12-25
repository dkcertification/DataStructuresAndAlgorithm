using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts
{
    /*
    Recursive function is a function which calls itself 
    If a function calls itself unconditionally, it will never finish executing and CLR terminates such execution 
    To manage the above mentioned issue, a recursive function define [BASE CASE]
    [BASE CASE] is a condition, makes sure that recursion reached a most trivial level of the problem that should be solved
        - returns a result for that trivial
    Iterations get allocates on the stack
    Very much vulnerable and it can cause long chaining calls and may result into stack overflow exception

     */
    class Recursion
    {
        private static int IterativeFactorial(int number)
        {
            if (number == 0) 
                return 1;
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
