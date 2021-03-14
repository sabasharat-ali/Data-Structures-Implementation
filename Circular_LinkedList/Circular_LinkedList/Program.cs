using System;

namespace Circular_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List l = new List();
            l.Add(9);
            l.Add(3);
            l.Add(9);
            l.Add(7);
            l.Add(14);
            l.Delete(3);
            l.Print();
            l.ReversePrint();
            l.Search(7);
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node previous;
        public Node(int value)
        {
            data = value;
            next = null;
            previous = null;
        }
    }
    public class List
    {
        Node head;
        Node tail;
        public List()
        {
            head = null;
            tail = null;
        }
        public void Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                tail = n;
                tail.next = head;
                head.previous = tail;
            }
            else
            {
                tail.next = n;
                n.previous = tail;
                tail = n;
                tail.next = head;
                head.previous = tail;
            }
        }
        public void Print()
        {
            Node temp = head;
            do
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            } while (temp != head);
        }
        public void ReversePrint()
        {
            Node temp = tail;
            do
            {
                Console.WriteLine(temp.data);
                temp = temp.previous;
            } while (temp != tail);
        }
        public void Search(int searchValue)
        {
            Node temp = head;
            do
            {
                if (temp.data == searchValue)
                {
                    Console.WriteLine("Found");
                    return;
                }
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("Not Found");
        }
        public void Delete(int deleteValue)
        {
            Node temp = head;
            do
            {
                if (temp.next.data == deleteValue)
                {
                    if (temp == tail)
                        head = head.next;
                    temp.next = temp.next.next;
                    temp.next.previous = temp;
                    return;
                }
                temp = temp.next;
            } while (temp != head);
        }
    }
}
