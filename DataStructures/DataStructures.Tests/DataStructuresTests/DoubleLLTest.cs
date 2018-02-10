using System;
using DataStructures.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests.DataStructuresTests
{
    [TestClass]
    public class DoubleLLTest
    {
        [TestMethod]
        public void DoubleLLAdd()
        {
            DoubleLL<int> list = new DoubleLL<int>();

            list.AddLast(1);

            Assert.AreEqual(list.head.value, 1);
            Assert.AreEqual(list.count, 1);
        }

        [TestMethod]
        public void DoubleLLRemove()
        {
            DoubleLL<int> list = new DoubleLL<int>();

            list.AddLast(145);
            list.AddLast(168);
            list.AddLast(193);

            var node = list.head;

            list.Remove(node);

            Assert.AreEqual(list.head.value, 168);
            Assert.AreEqual(list.head.next.value, 193);

            node = list.head.next;
            
            Assert.AreEqual(node.value, 193);
            Assert.AreEqual(list.count, 2);

            list.Remove(node);

            Assert.AreEqual(list.head.value, 168);
            Assert.AreEqual(list.count, 1);
        }

        [TestMethod]
        public void IteratingTest()
        {
            DoubleLL<int> list = new DoubleLL<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            int i = 1;
            foreach(var node in list)
            {
                Assert.AreEqual(node, i);
                i++;
            }
        }

        [TestMethod]
        public void IteratingReverseTest()
        {
            DoubleLL<int> list = new DoubleLL<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            var nodeEnumerator = list.GetEnumeratorLastToFirst();

            int node = nodeEnumerator.Current;

            int j = 5;
            while(nodeEnumerator.MoveNext())
            {
                node = nodeEnumerator.Current;
                Assert.AreEqual(node, j);
                j--;
            }
        }
    }
}
