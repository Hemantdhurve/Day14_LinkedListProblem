using LinkedList;
using System;

namespace LinkList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problems");

            bool check=true;

            Start:
            while (check)
            {
                Console.WriteLine("Please Select options :\n" +
                    "1)Elements Added in the Linked List using Add Method\n");

                int option=Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list=new LinkedListData();
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    default:
                        Console.WriteLine("Please select proper option");
                        break ;
                        goto Start;


                }
                
            }
            
        } 
    }
}