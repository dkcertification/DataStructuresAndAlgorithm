namespace AlgorithmConcepts.Concepts.List
{
    public class Node<T>
    {
        private T value;

        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T _value)
        {
            Value = _value;
        }


    }
}
