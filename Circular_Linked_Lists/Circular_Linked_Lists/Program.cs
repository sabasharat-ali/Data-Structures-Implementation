using System;

namespace Circular_Linked_Lists
{

    class node
    {

        public int data;
        public node Nlink;
        public node(int val)
        {
            data = val; Nlink = null;
        }
    }
    public class SLL
    {
        node head;
        node tail;
        public SLL()
        {
            head = null;
            tail = null;
        }
        public void add(int data)
        {
            node n = new node(data);
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
            node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Nlink;
            }
        }
        void search(int val)
        {
            node temp = head;
            while (temp != null)
            {
                if (temp.data == val)
                {
                    Console.WriteLine("FOUND");
                    break;

                    temp = temp.Nlink;
                }
            }
        }
        void update(int old_val, int new_val)
        {
            node temp = head;
            while (temp != null)
            {
                if (temp.data == old_val)
                {
                    Console.WriteLine(temp.data = new_val);
                    break;
                }
                temp = temp.Nlink;
            }

        }



        class Program
        {
            static void Main(string[] args)
            {
                SLL sll = new SLL();
                sll.add(6);
                sll.add(9);
                sll.print();
                sll.search(6);
                sll.update(6, 12);

            }
        }
    }
}
