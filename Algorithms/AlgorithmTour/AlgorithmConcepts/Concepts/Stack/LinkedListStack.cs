using AlgorithmConcepts.Concepts.List;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.Stack
{
    public class LinkedListStack<T>
    {

        readonly SinglyLinkedList<T> _List = new SinglyLinkedList<T>();

        public bool IsEmpty => Count == 0;
        public double Count => _List.Count;

        public void PUSH(T item)
        {
            _List.AddFirst(item);
        }


        public T PEEK()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _List.Head.Value;
        }

        public void POP()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            _List.RemoveFirst();
        }

       
    }
}
