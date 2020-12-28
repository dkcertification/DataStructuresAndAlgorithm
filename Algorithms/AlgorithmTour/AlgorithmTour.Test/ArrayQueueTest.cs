
using AlgorithmConcepts.Concepts.Queue;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Test
{
    [TestFixture]
    public class ArrayQueueTest
    {

        [Test]
        public void IsEmpty_EmptyQueue_ReturnTrue()
        {
            var _Queue = new ArrayQueue<int>();
            Assert.True(_Queue.IsEmpty);
        }


        [Test]
        public void Count_EnqueueOneItem_ReturnOne()
        {
            var _Queue = new ArrayQueue<int>();
            _Queue.Enqueue(1);
        
            Assert.AreEqual(1,_Queue.Count);
            Assert.IsFalse(_Queue.IsEmpty);
        }

        [Test]
        public void Dequeu_EmptyQueue_ThrowsException()
        {
            var _Queue = new ArrayQueue<int>();
            Assert.Throws<InvalidOperationException>(
                () => _Queue.Dequeue()
                );
        }

        [Test]
        public void Peek_EnqueueTwoItems_ReturnsHeadItem()
        {
            var _Queue = new ArrayQueue<int>();
            _Queue.Enqueue(1);
            _Queue.Enqueue(2);

            Assert.AreEqual(1, _Queue.PEEK());
        }

        [Test]
        public void Peek_EnqueueTwoItemsAndDequeue_ReturnsHeadElement()
        {
            var _Queue = new ArrayQueue<int>();
            _Queue.Enqueue(1);
            _Queue.Enqueue(2);
            _Queue.Dequeue();
            
            Assert.AreEqual(2, _Queue.PEEK());

        }


    }
}
