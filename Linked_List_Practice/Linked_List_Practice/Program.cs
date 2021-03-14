using System;

namespace Linked_List_Practice
{
    public class Node
    {
        public int data;
        public Node Nlink;
        public Node(int val)
        {
            data = val; Nlink = null;
        }

    }
    public class SLL
    {
        Node head;
        Node tail;
        public SLL()
        {
            head = null;
            tail = null;
        }
        public void add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                tail = n;

            }
            else
            {
                tail.Nlink = n;
                tail = n;
            }
        }
        public void print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Nlink;
            }
        }
        public void search(int val)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == val)
                {
                    Console.WriteLine("FOUND YOUR VALUE {0}", val);
                    break;

                    temp = temp.Nlink;
                }
            }
        }
        void update(int old_val, int new_val)
        {
            Node temp = head;
            while (temp != null)
            {
                if(temp.data==old_val)
                {
                    Console.WriteLine(temp.data=new_val);
                    break;
                }
                temp = temp.Nlink;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SLL sll = new SLL();
            sll.add(5);
            sll.add(8);
            sll.print();
            sll.search(8);
        }
    }
}
