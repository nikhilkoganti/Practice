using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class LLGenericNode<T>
    {
        public T value;
        public LLGenericNode<T> next;
    }

    public class LLGeneric<T> : IEnumerable<T>
    {

        public LLGenericNode<T> head;
        public LLGenericNode<T> tail;
        public int count;

        public void Add(T value)
        {
            LLGenericNode<T> node = new LLGenericNode<T>();
            node.value = value;

            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                tail = tail.next;
            }
            count++;
        }

        public void Remove(LLGenericNode<T> node)
        {
            if (count == 0)
            {
                throw new Exception("List is empty");
            }

            if (head == node)
            {
                if (head.next == null)
                {
                    head = tail = null;
                }
                else
                {
                    head = head.next;
                }
                count--;
            }
            else
            {
                LLGenericNode<T> prevNode = head;
                LLGenericNode<T> currNode = head.next;

                while (currNode.next != null)
                {
                    if (currNode == node)
                    {
                        prevNode.next = currNode.next;
                        count--;
                        break;
                    }
                    prevNode = prevNode.next;
                    currNode = currNode.next;
                }
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            LLGenericNode<T> node = head;
            while (node.next != null)
            {
                yield return node.value;
                node = node.next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}