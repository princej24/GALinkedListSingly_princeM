using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// prince jeff muturi 
// 2/12/24




namespace GALinkedListSingly_princeM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("Elements in the list:");
            list.Display();
            Console.WriteLine();

            list.InsertAtIndex(2, 89);
            Console.WriteLine("After inserting 89 at index 2:");
            list.Display();
            Console.WriteLine();

            list.InsertAtFront(0);
            Console.WriteLine("After inserting 0 at the beginning:");
            list.Display();
            Console.WriteLine();

            list.InsertAtEnd(5);
            Console.WriteLine("After inserting 5 at the end:");
            list.Display();
            Console.WriteLine();

          //  list.RemoveAtFront(2);
            Console.WriteLine("After removing element 2:");
            list.Display();
            Console.WriteLine();

            list.RemoveAtEnd();
            Console.WriteLine("After removing last element:");
            list.Display();
            Console.WriteLine();

            list.Clear();
            Console.WriteLine("After clearing the list:");
            list.Display();
            Console.WriteLine();
        }
    }
}
