using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GALinkedListSingly_princeM
{
    public class LinkedList<T>
    {
        public class LinkedListNode<T>
        {
            public T Value { get; set; }
            public LinkedListNode<T> Next { get; set; }

            public LinkedListNode(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private LinkedListNode<T> head;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public LinkedList()
        {
            head = null;
            count = 0;
        }

      
        public void Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public void Display()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public void InsertAtIndex(int index, T value)
        {
            if (index < 0 || index > count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            if (index == 0)
            {
                InsertAtFront(value);
                return;
            }

            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            LinkedListNode<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void InsertAtFront(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void InsertAtEnd(T value)
        {
            Add(value);
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            if (index == 0)
            {
                RemoveAtFront();
                return;
            }

            LinkedListNode<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            count--;
        }

        public void RemoveAtFront()
        {
            if (head == null)
                return;

            head = head.Next;
            count--;
        }

        public void RemoveAtEnd()
        {
            if (head == null)
                return;

            if (head.Next == null)
            {
                head = null;
                count--;
                return;
            }

            LinkedListNode<T> current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
            count--;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

    }
}
