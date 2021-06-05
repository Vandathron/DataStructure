using System;
namespace DataStructure.Leetcode
{
    public class MyLinkedList
    {
        public Node head = null;
        public Node tail = null;

        int Size = 0;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if(index >= Size)
            {
                return -1;
            }

            int staringPoint = 0;

            Node n = head;

            while(staringPoint <= index)
            {
                n = n.Next;
                staringPoint++;
            }

            return n.Val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node headToAdd = new Node(val, head);
            head = headToAdd;
            Size++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node t = new Node(val, null);
            tail.Next = t;
            tail = t;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if(index == Size)
            {
                AddAtTail(val);
            } else if (index < Size)
            {
                Node nodeToAdd = new Node(val, null);

                int startingPoint = 0;
                Node t = head;

                while (startingPoint < index)
                {
                    t = t.Next;
                    startingPoint++;
                }
                nodeToAdd.Next = t.Next;
                t = nodeToAdd;
            }

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            int startingPoint = 0;

            Node t = head;
            while (startingPoint < index)
            {
                t = t.Next;
                startingPoint++;
            }

            t.Next = t.Next.Next;
        }
    }

    public class Node
    {
        public int Val { get; }
        public Node Next { get; set; }

        public Node(int val, Node next)
        {
            this.Val = val;
            this.Next = next;
        }
        
    }
}
