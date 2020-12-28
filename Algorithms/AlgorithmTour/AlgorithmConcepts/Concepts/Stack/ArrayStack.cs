using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.Stack
{
    public class ArrayQueue<T> : IEnumerable<T>
    {

        private T[] _items;

        public ArrayQueue()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public ArrayQueue(int capacity)
        {
            _items = new T[capacity];

        }

        public void PUSH(T item)
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;

            }
            _items[Count++] = item;

        }

        public void POP()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _items[--Count] = default(T);

        }


        public T PEEK()
        {

            if (IsEmpty)
                throw new InvalidOperationException();
            return _items[Count - 1];

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int iterator = 0; iterator < _items.Length; iterator++)
            {
                yield return _items[iterator];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }
    }
}
