using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Problems
{
    class FirstRepeatingCharacter
    {
        public string FirstRepeatingCharacter_V0(string strInput)
        {
            
            HashSet<char> HA = new HashSet<char>();
            foreach(char c in strInput.ToCharArray())
            {
                if (HA.Contains(c)) 
                    return "First Repeating Character: " + c.ToString();
                HA.Add(c);
            }

            return "No Repeating Character found";
        }

        //Time Complexity = O(N)
        //Space Complexity = O(N)
    }
}
