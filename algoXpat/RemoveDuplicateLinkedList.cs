using System;

namespace DataStructure.algoXpat
{
    public class RemoveDuplicateLinkedList
    {
        public class LinkedList
        {
            public int Value;
            public LinkedList Next;

            public LinkedList(int value)
            {
                this.Value = value;
                this.Next = null;
            }
        }

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // Write your code here.
            LinkedList currentNode = linkedList;

            while (currentNode.Next != null)
            {
                if (currentNode.Value == currentNode.Next.Value)
                {
                    currentNode.Next = currentNode.Next.Next;
                }
                else currentNode = currentNode.Next;
            }

            return linkedList;
        }
    }
}
