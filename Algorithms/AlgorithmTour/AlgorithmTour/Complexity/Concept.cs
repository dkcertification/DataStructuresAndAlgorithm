using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmTour.Complexity
{
    class Concept
    {
        public static IEnumerable<int> ReadInt(string filePath)
        {
            using(TextReader reader = File.OpenText(filePath))
            {
                string lastline;
                while((lastline = reader.ReadLine()) != null)
                {
                    yield return int.Parse(lastline);
                }
            }
        }
    }
}
