using System;
using DataStructures.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests.DataStructuresTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Assert.AreEqual(stack.count, 5);
        }

        [TestMethod]
        public void PopTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Assert.AreEqual(stack.Peek().value, 5);
            Assert.AreEqual(stack.Peek().value, 5);

            Assert.AreEqual(stack.Pop().value, 5);
            Assert.AreEqual(stack.Pop().value, 4);
            Assert.AreEqual(stack.Pop().value, 3);
            Assert.AreEqual(stack.Pop().value, 2);
            Assert.AreEqual(stack.Pop().value, 1);
        }
    }
}
