using System;
using DataStructures.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests.DataStructuresTests
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void EnqueueTest()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.AreEqual(queue.count, 5);
        }

        [TestMethod]
        public void DequeueTest()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.AreEqual(queue.Dequeue().value, 1);
            Assert.AreEqual(queue.Dequeue().value, 2);
            Assert.AreEqual(queue.Dequeue().value, 3);
            Assert.AreEqual(queue.Dequeue().value, 4);
            Assert.AreEqual(queue.Dequeue().value, 5);
        }
    }
}
