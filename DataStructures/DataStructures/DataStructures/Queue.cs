using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class Queue<T>
    {
        public Node<T> first;
        public Node<T> last;
        public int count;

        public void Enqueue(T value)
        {
            var node = new Node<T>();
            node.value = value;

            if (first == null)
            {
                first = last = node;
            }
            else
            {
                last.previous = node;
                last = node;
            }
            count++;
        }

        public Node<T> Dequeue()
        {
            Node<T> retNode;
            if (count == 0)
            {
                throw new Exception("Queue is empty");
            }
            else
            {
                retNode = first;
                first = first.previous;
            }

            count--;
            return retNode;
        }
    }
}