using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.DataStructures;

namespace DataStructures.Tests.DataStructuresTests
{
    [TestClass]
    public class LLTest
    {
        [TestMethod]
        public void AddingToLL()
        {
            LLInt list = new LLInt();

            list.Add(1);
            Assert.AreEqual(list.count, 1);

            list.Add(10);
            list.Add(25);
            list.Add(36);
            list.Add(41);
            Assert.AreEqual(list.count, 5);

            list.Remove(5);
            Assert.AreEqual(list.count, 5);

            list.Remove(25);
            Assert.AreEqual(list.count, 4);

            Assert.AreEqual(list.head.value, 1);
            Assert.AreEqual(list.tail.value, 41);

            LLIntNode node = list.head;
            for (int i = 0; i < list.count; i++)
            {
                Assert.AreEqual(node.value, GetIIndexVal(i));
                node = node.next;
            }
        }

        [TestMethod]
        public void AddingToLLGeneric()
        {
            LLGeneric<int> list = new LLGeneric<int>();

            list.Add(1);
            Assert.AreEqual(list.count, 1);

            list.Add(10);
            list.Add(25);
            list.Add(36);
            list.Add(41);
            Assert.AreEqual(list.count, 5);

            var removingNode = list.head.next.next;
            list.Remove(removingNode);
            Assert.AreEqual(list.count, 4);

            Assert.AreEqual(list.head.value, 1);
            Assert.AreEqual(list.tail.value, 41);

            LLGenericNode<int> node = list.head;
            for (int i = 0; i < list.count; i++)
            {
                Assert.AreEqual(node.value, GetIIndexVal(i));
                node = node.next;
            }
        }

        private int GetIIndexVal(int i)
        {
            int retVal = 0;
            switch (i)
            {
                case 0:
                    retVal =  1;
                    break;
                case 1:
                    retVal = 10;
                    break;
                case 2:
                    retVal = 36;
                    break;
                case 3:
                    retVal = 41;
                    break; 
            }

            return retVal;
        }
    }
}
