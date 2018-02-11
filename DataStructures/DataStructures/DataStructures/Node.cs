using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataStructures.DataStructures
{
    public class Node<T>
    {
        public T value;
        public Node<T> previous;
        public Node<T> next;
    }
}