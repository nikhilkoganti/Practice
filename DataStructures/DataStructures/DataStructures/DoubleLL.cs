using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class DoubleLL<T> : IEnumerable<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int count = 0;

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>();
            node.value = value;

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.previous = tail;
                tail.next = node;
                tail = node;
            }
            count++;
        }

        public void Remove(Node<T> node)
        {
            if (count == 0)
            {
                throw new Exception("List is empty");
            }
            else
            {
                var tempNode = head;

                while(tempNode != null)
                {
                    if (tempNode == node)
                    {
                        if (tempNode.previous != null && tempNode.next != null)
                        {
                            tempNode.previous.next = tempNode.next;
                            tempNode.next.previous = tempNode.previous;
                        }
                        else if (tempNode.previous == null && tempNode.next == null)
                        {
                            head = tail = null;
                        }
                        else if (tempNode.next == null)
                        {
                            tail = tempNode.previous;
                            tempNode.previous.next = null;
                        }
                        else if (tempNode.previous == null)
                        {
                            head = tempNode.next;
                            tempNode.next.previous = null;
                        }
                        count--;
                        return;
                    }
                    tempNode = tempNode.next;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = head;

            while(node != null)
            {
                yield return node.value;
                node = node.next;
            }
        }

        public IEnumerator<T> GetEnumeratorLastToFirst()
        {
            var node = tail;

            while (node != null)
            {
                yield return node.value;
                node = node.previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}