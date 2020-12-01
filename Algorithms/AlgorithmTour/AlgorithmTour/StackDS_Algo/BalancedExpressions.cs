using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.StackDS_Algo
{
    class BalancedExpressions
    {
        public bool balParenthesis(string exp)
        {
            // base case: length of the expression must be even
            if (exp.Length % 2 == 1)
            {
                return false;
            }
            Stack<char> c = new Stack<char>();

            foreach(char CH in exp.ToCharArray())
            {
                if(CH == '{' || CH == '[' || CH == '(')
                {
                    c.Push(CH);
                }

                if (CH == '}' || CH == ']' || CH == ')')
                {
                    if(c.Count <= 0)
                    {
                        return false;
                    }

                    char top = c.Pop();

                    // if the popped character if not an opening brace or does not pair
                    // with current character of the expression
                    if ((top == '(' && CH != ')') || (top == '{' && CH != '}')
                            || (top == '[' && CH != ']'))
                    {
                        return false;
                    }

                }
            }

            return c.Count <= 0;
        }

        public bool balParanthesis(string exp)
        {
            //TO BE Implemented 
            return true;
        }
    }
}
