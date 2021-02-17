using System;
using System.Collections.Generic;

//Creating a linked list and reversing it (using recursion)

namespace Recursion_ReverseLinkedList
{
    class Program
    {
        public class Node 
        {
            public int data;
            public Node next;
            public Node(int NodeData) 
            {
                this.data = NodeData;
                this.next = null;
            }
        }
        public class LinkedList
        {
            public Node head;
            public LinkedList() 
            {
                this.head = null;
            }

            // pushing a linked list
            public void PushNewNode(int NodeData) 
            {
                Node node = new Node(NodeData);
                if (this.head != null) 
                {
                    node.next = head;
                }
                this.head = node;
            }
        }
        
        // printing a linked list
        public static void PrintLinkedList(Node node ,String Seperator)        {
            while (node != null)
            {
                Console.Write(node.data+Seperator);
                node = node.next;
            }
        }

        //Reversing 
        public static Node ReverseNode(Node head) 
        {
            if ((head == null) || head.next == null ) 
            {
                return head;
            }
            Node ReversedListHead = ReverseNode(head.next);

            // adding the node to the new list
            head.next.next = head; 
            head.next = null;

            return ReversedListHead;
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.PushNewNode(5);
            list.PushNewNode(10);
            list.PushNewNode(18);
            list.PushNewNode(40);
            Console.WriteLine("Original List : ");
            PrintLinkedList(list.head, " ");
            Console.WriteLine("\n\nReversed List : ");
            Node NewList = ReverseNode(list.head);
            PrintLinkedList(NewList," ");
        }
    }
}
