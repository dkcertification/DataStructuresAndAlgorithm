using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.List
{

    /*
     List<T>.Sort() eventually calls Array.Sort<T>()
    if T is primitive => TrySZSort() - Native Implementation from compiler is executed
    if T is reference Type => 
        if(platform = .NET Core || platform >= .Net Framework 4.5)
            ---IntroSort() // Combination of Insertion Sort, Heap Sort and QuickSort
            //If number of element is <= 16 :: Insertion Sort
            //If number of partitions exceeds [2*N] where N = length of the input Array :: Heap Sort
            //Otherwise it uses a QuickSort
        else
            //IntroSort()
            //QSort with 32-max recursion depth, if exceeds switched to HeapSort
            ---DepthLimitedQuickSort() // ~/List/ListImportantPoints.docx

    
    Characterstic: 
    --Worst Time Complexity = O(nlogn);
    --Extreme Rare Case :: O(n^2)

    For More Information on Complexity please refer to 
     */
    public class listDemo
    {

        class Customer
        {
            public string FirstName { get; set; }
            public DateTime BirthDate { get; set; }

        }

        public static void ApiMembers()
        {
            var list = new List<int>(){ 1,4,5,2,4};

            var index = list.BinarySearch(4);
            Console.WriteLine(index);
            
            list.Sort();

            Console.WriteLine(string.Join(", ", list));
            var count = list.FindAll(x => x.Equals(4)).Count;
            Console.WriteLine(count);

            var listCustomers = new List<Customer>()
            {
                new Customer(){ FirstName = "Dilip", BirthDate = new DateTime(1981, 08, 12) },
                new Customer(){ FirstName = "Edrian", BirthDate = new DateTime(1980, 06, 09) },
                new Customer(){ FirstName = "Victor", BirthDate = new DateTime(1976, 03, 12) }
            };

            listCustomers.Sort((left, right) => {
                if (left.BirthDate > right.BirthDate)
                    return 1;
                if (right.BirthDate > left.BirthDate)
                    return -1;
                return 0;
            });

        }

        public static void Run()
        {
            List<int> lst = new List<int>();

            LogCountAndCapacity(lst);
            Console.WriteLine("**********Add***********************");
            
            for (int i = 0; i <= 16; i++)
            {
                lst.Add(i);
                LogCountAndCapacity(lst);
            }

            Console.WriteLine("***********Rem**********************");

            for (int i = 4; i >0; i--)
            {
                lst.RemoveAt(i - 1);
                LogCountAndCapacity(lst);

            }
            Console.WriteLine("***************Trim******************");

            lst.TrimExcess(); //Trims access only when 90% of the capacity is used;
            LogCountAndCapacity(lst);

            lst.Add(1);
            LogCountAndCapacity(lst);
            Console.Read();
        }

        private static void LogCountAndCapacity(List<int> lst)
        {
            Console.WriteLine($"Count = {lst.Count}. Capacity = {lst.Capacity}");
        }
    }
}
