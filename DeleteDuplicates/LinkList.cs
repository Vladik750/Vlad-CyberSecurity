using System;
using System.Collections.Generic;

namespace DeleteDuplicates
{
    public class LinkList
    {
        public LinkedList<int> DeleteDuplicates(LinkedList<int> head)
        {
            int size = head.Count;
            if (size == 0)
            {
                throw new ArgumentException("Wrong input: empty list");
            }
            int counter = 0;
            LinkedListNode<int> tempNode = head.First;
            while (counter <= size)
            {
                if (tempNode.Next == null)
                {
                    break;
                }
                if (tempNode.Value == tempNode.Next.Value)
                {
                    head.Remove(tempNode.Next);
                    counter++;
                }
                else
                {
                    tempNode = tempNode.Next;
                    counter++;
                }
            }

            return head;
        }
        static void Main(string[] args)
        {
            LinkList link = new LinkList();
            int[] arr = new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 3 };
            LinkedList<int> list = new LinkedList<int>(arr);
            link.DeleteDuplicates(list);
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
