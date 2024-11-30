using DataStructures.Models.LinkedList;
using System;

namespace DataStructures.LinkedList
{
    internal class SingleLinkedList
    {
        private Node head;
        private Node tail;

        public void Add(object data)
        {
            if(head == null)
            {
                head=new Node(data);
                tail = head;
            }
            else
            {
                tail.next=new Node(data);
                tail=tail.next;
            }
        }
        public void AddFirst(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                tail = head;
            }
            else
            {
                head=new Node(data,head);
            }
        }
        public void ReadAll()
        {
            var current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
    }
}
