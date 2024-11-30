using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models.LinkedList
{
    internal class Node
    {
        public readonly object data;
        public Node next = null;
        public Node(object data,Node next)
        {
            this.data = data;
            this.next = next;
        }
        public Node(object data)
        {
            this.data = data;
        }
    }
}
