namespace AlgorithmConcepts.Concepts.List
{
    public class SinglyLinkedNode<T>
    {
        private T value;

        public T Value { get; set; }
        public SinglyLinkedNode<T> Next { get; set; }

        public SinglyLinkedNode(T _value)
        {
            Value = _value;
        }


    }
}
