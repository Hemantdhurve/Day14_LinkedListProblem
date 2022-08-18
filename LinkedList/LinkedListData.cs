using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListData
    {
        //head is used as node start point
        Node head;
        public void Add(int data)
        {
            Node node=new Node(data);
            if (this.head == null)
            {
                head=node;
            }
            else
            {
                Node temp=head;
                while (temp.Next != null)
                {
                    temp=temp.Next;
                }
                temp.Next=node;
            }
            Console.WriteLine("Element added in linkedlist is : {0} ",+ node.data);

        }

        //Display Method is Used to Display elements

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Console.WriteLine("Linked List contains :");

                Node temp=head;
                while(temp!= null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp=temp.Next;
                }
            }
         
        }
    }
}
