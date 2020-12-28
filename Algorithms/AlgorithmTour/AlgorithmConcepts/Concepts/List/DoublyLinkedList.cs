using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.List
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get; private set; }
        public DoublyLinkedNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddFirst(T Value)
        {
            AddFirst(new DoublyLinkedNode<T>(Value));
        }

        private void AddFirst(DoublyLinkedNode<T> doublyLinkedNode)
        {
            DoublyLinkedNode<T> temp = Head;

            Head = doublyLinkedNode;
            Head.Next = temp;
            if (isEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;

        }

        public void AddLast(T Value)
        {
            AddLast(new DoublyLinkedNode<T>(Value));
        }

        private void AddLast(DoublyLinkedNode<T> doublyLinkedNode)
        {
            if (isEmpty)
                Head = doublyLinkedNode;
            else
            {
                Tail.Next = doublyLinkedNode;
                doublyLinkedNode.Previous = Tail;
            }
            Tail = doublyLinkedNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (isEmpty)
                throw new InvalidOperationException();
            Head = Head.Next;

            Count--;

            if (isEmpty)
                Tail = null;
            else
                Head.Previous = null;
        }

        public void RemoveLast()
        {
            if (isEmpty)
                throw new InvalidOperationException();
            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            Count--;

        }
        public bool isEmpty => Count == 0;
    }

}