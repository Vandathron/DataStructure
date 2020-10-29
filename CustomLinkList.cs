using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace DataStructure
{
    public class CustomLinkList<T> : IEnumerable<T>
    {
        private Node<T> head = null;
        private Node<T> tail = null;
        private int size = 0;

        public CustomLinkList()
        {

        }

        //add element
        public void AddFirst(T item)
        {
            var element = new Node<T>(item, null);
            if (isEmpty())
            {
                head = tail = element;
            }
            else
            {
                //if the head has no next node. set the tail is the next
                if(head.next == null)
                {
                    tail = element;
                } else
                tail.next = element;
            }
            size++;
        }

        public void AddLast(T item)
        {
            if (isEmpty())
            {
                head = tail = new Node<T>(item, null);
            } else
            {
                tail = new Node<T>(item, null);
            }

            size++;
        }

        public T PeekFirst()
        {
            if (isEmpty()) throw new Exception("Empty list");

            return head.data;
        }

        public T PeekLast()
        {
            if (isEmpty()) throw new Exception("Empty list");
            return tail.data;
        }

        public T RemoveFirst()
        {
            if (isEmpty()) throw new Exception("Empty list");

            T data = head.data;
            head = head.next;
            --size;

            if (isEmpty()) tail = null;
            return data;
        }

        public T RemoveLast()
        {
            if (isEmpty()) throw new Exception("Empty list, cannot remove");

            T data = tail.data;
            int i = 1;
            Node<T> trav = new Node<T>(head.data, head.next);
            while(i < size)
            {
                if (i == (size - 1))
                {
                    tail = new Node<T>(trav.data, null);
                }
                else
                {
                    trav = trav.next;
                }

                i++;
            }
            size--;
            return data;
        }

        private void remove(Node<T> node)
        {
            
        }


        //Return the size of this linked list
        public int Size()
        {
            return size;
        }

        //checks if list is empty
        public bool isEmpty()
        {
            return Size() == 0;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T data, Node<T> next)
            {
                this.data = data;
                this.next = next;
            }


        }
    }
}
