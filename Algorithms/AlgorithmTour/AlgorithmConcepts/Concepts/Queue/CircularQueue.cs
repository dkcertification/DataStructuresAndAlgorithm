using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmConcepts.Concepts.Queue
{
    public class CircularQueue<T> : IEnumerable<T>
    {

        private T[] _Items;

        public int Count => _Head <= _Tail 
            ? _Tail - _Head 
            : _Tail - _Head + _Items.Length;


        public bool IsEmpty => Count == 0;

        public double Capacity => _Items.Length;

        private int _Head;
        private int _Tail;

        public CircularQueue(int capacity)
        {
            _Items = new T[capacity];
        }

        public CircularQueue()
        {
            const int defaultCapacity = 4;
            _Items = new T[defaultCapacity];
        }

        public void Enqueue(T Item)
        {
            if(Count == _Items.Length - 1)
            {
                int countPriorResize = Count;
                T[] LargerArray = new T[2 * _Items.Length];
                Array.Copy(_Items, _Head, LargerArray, 0, _Items.Length - _Head);
                Array.Copy(_Items, 0, LargerArray, _Items.Length - _Head, _Tail);

                _Items = LargerArray;
                _Head = 0;
                _Tail = countPriorResize;
            }


            _Items[_Tail] = Item;
            if(_Tail < _Items.Length - 1)
            {
                _Tail++;
            }
            else
            {
                _Tail = 0;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            _Items[_Head++] = default(T);
            if(IsEmpty)
            {
                _Head = _Tail = 0;
            }else if(_Head == _Items.Length)
            {
                _Head = 0;
            }
        }


        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _Items[_Head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            if(_Head <= _Tail) //UnWrapped
            {
                for(int i = _Head; i< _Tail; i++)
                {
                    yield return _Items[i];
                }
            }
            else //Wrapped
            {
                for(int i = _Head; i<_Items.Length; i++)
                {
                    yield return _Items[i];
                }

                for(int i = 0; i<_Tail; i++)
                {
                    yield return _Items[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
