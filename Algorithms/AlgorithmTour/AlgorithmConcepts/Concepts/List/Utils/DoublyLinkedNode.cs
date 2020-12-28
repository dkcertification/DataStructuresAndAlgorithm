namespace AlgorithmConcepts.Concepts.List
{
    public class DoublyLinkedNode <T>
    {
        private T value;

        public DoublyLinkedNode<T> Next { get; internal set; }
        public DoublyLinkedNode<T> Previous { get; internal set; }
        public T Value{ get; private set; }

        public DoublyLinkedNode(T _value)
        {
            Value = _value;
        }

       
    }


}
