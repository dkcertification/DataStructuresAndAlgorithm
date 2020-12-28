using AlgorithmConcepts.Concepts.Stack;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTour.Test
{
    [TestFixture]
    public class StackTest
    {

        [Test]
        public void IsEmpty_EmptyStack_ReturnTrue()
        {
            var stack = new ArrayQueue<int>();
            Assert.True(stack.IsEmpty);
        }


        [Test]
        public void Count_PushOneItem_ReturnOne()
        {
            var stack = new ArrayQueue<int>();
            stack.PUSH(1);
        
            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new ArrayQueue<int>();
            Assert.Throws<InvalidOperationException>(
                () => stack.POP()
                );
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new ArrayQueue<int>();
            stack.PUSH(1);
            stack.PUSH(2);

            Assert.AreEqual(2, stack.PEEK());
        }

        [Test]
        public void Peek_PushToItemsAndPop_ReturnsHeadElement()
        {
            var stack = new ArrayQueue<int>();
            stack.PUSH(1);
            stack.PUSH(2);
            stack.POP();

            Assert.AreEqual(1, stack.PEEK());

        }


    }
}
