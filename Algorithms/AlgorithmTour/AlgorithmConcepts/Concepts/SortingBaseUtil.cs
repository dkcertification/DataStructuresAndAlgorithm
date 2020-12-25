namespace AlgorithmConcepts.Concepts.Util
{
    public class SortingBaseUtil
    {

        public static void swap(int[] array, int i, int j)
        {
            if (i == j) return;
            int Temp = array[i];
            array[i] = array[j];
            array[j] = Temp;
        }
    }
}