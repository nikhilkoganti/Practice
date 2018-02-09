using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class LLInt : IEnumerable
    {
        public LLInt()
        {
            count = 0;
        }
        public LLIntNode head;
        public LLIntNode tail;
        public int count;

        public void Add(int value)
        {
            LLIntNode node = new LLIntNode();
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

        public void Remove(int value)
        {
            if (count == 0)
            {
                throw new Exception("List is empty");
            }

            if (head.value == value)
            {
                head = head.next;
                count--;
            }
            else
            {
                LLIntNode prevNode = head;
                LLIntNode currNode = head.next;

                while (currNode.next != null)
                {
                    if (currNode.value == value)
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

        public IEnumerator GetEnumerator()
        {
            LLIntNode node = head;
            while(node.next != null)
            {
                yield return node;
                node = node.next;
            }
        }
    }
}