using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINKED LIST");

            LinkedList list = new LinkedList();
            //Inserted node at the end
            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);

            //Inserting node at the beginning
            //list.InsertFront(70); // Adding data in list //UC2
            //list.InsertFront(30);// Adding data in list //UC2
            //list.InsertFront(56);// Adding data in list //UC2

            //Appending Operation
            list.Appending(56);// Adding data in list //UC3
            list.Appending(30);// Adding data in list //UC3
            list.Appending(70);// Adding data in list //UC3
            
            list.Display();
            Console.ReadLine();
        }
    }
}
