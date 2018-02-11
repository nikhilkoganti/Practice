using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class Stack<T>
    {
        public Node<T> top;
        public int count;

        public void Push(T value)
        {
            var node = new Node<T>();
            node.value = value;

            if (top == null)
            {
                top = node;
            }
            else
            {
                node.previous = top;
                top = node;
            }

            count++;
        }

        public Node<T> Pop()
        {
            Node<T> node = null;
            if (top == null)
            {
                throw new Exception("stack empty");
            }
            else
            {
                node = top;

                top = top.previous;
            }
            count--;

            return node;
        }

        public Node<T> Peek()
        {
            return top;
        }
    }
}