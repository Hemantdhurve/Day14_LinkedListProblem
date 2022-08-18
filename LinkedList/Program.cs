using LinkedList;
using System;

namespace LinkList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problems");

            //creating Simple Linked List

            List<int> link = new List<int>();
            Console.WriteLine("Elements added in the LinkedList are :");
            link.Add(56);
            link.Add(30);
            link.Add(70);

            //foreach loop to check each elements 
            foreach (int item in link)
            {
                Console.WriteLine(item);
            }
        } 
    }
}