using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.Queue
{
    public class ArrayQueue<T> : IEnumerable<T>
    {

        private T[] _Items;
        private int _Head;
        private int _Tail;

        public ArrayQueue()
        {
            const int defaultCapacity = 4;
            _Items = new T[defaultCapacity];
        }

        public ArrayQueue(int capcity)
        {
            _Items = new T[capcity];
        }

        public int Count => _Tail - _Head;
        public bool IsEmpty => Count == 0;

        public void Enqueue(T item)
        {
            if(_Items.Length == _Tail)
            {

                T[] largerArray = new T[Count * 2];
                Array.Copy(_Items, largerArray, Count);
                _Items = largerArray;
            }

            _Items[_Tail++] = item;
        }
        

        public void Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            _Items[_Head++] = default(T);

            if (IsEmpty)
                _Head = _Tail = 0;
        }

        public T PEEK()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return _Items[_Head];
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int iCounter = 0; iCounter < _Tail; iCounter++)
            {
                yield return _Items[iCounter];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
