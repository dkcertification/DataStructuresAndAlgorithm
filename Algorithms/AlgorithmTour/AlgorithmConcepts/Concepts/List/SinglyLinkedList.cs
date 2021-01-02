using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.List
{
    public class SinglyLinkedList<T>: IEnumerable<T>
    {
        public SinglyLinkedNode<T> Head { get; private set; }
        public SinglyLinkedNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new SinglyLinkedNode<T>(value));
        }

        private void AddFirst(SinglyLinkedNode<T> node)
        {
            //Save of the current node
            SinglyLinkedNode<T> temp = Head;
            Head = node;

            //Shifting the former Head
            Head.Next = temp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }


        public void AddLast(T value)
        {
            AddLast(new SinglyLinkedNode<T>(value));
        }

        private void AddLast(SinglyLinkedNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;

            if (Count == 1)
                Tail = null;

            Count--;
        }


        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            SinglyLinkedNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty => Count == 0;
        
    }
}
