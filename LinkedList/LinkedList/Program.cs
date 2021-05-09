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
            //list.Appending(56);// Adding data in list //UC3
            //list.Appending(30);// Adding data in list //UC3
            //list.Appending(70);// Adding data in list //UC3

            //list.Add(56); // Adding data in list //UC4            
            //list.Add(70); // Adding data in list //UC4
            //list.InsertAtParticularPosition(2, 30);//UC4

            //Deleting a Node 
            //list.Add(56); // Adding data in list //UC5
            //list.Add(30); // Adding data in list //UC5
            //list.Add(70); // Adding data in list //UC5
            //list.Display(); //call Display method to print data
            //list.DeleteFirstNode(); // Adding data in list //UC5

            //list.Add(56); // Adding data in list //UC6
            //list.Add(30); // Adding data in list //UC6
            //list.Add(70); // Adding data in list //UC6
            //list.Display(); //call Display method to print data
            //list.DeleteLastNode(); // Adding data in list //UC6

            //Search Operation
            //list.Add(56); // Adding data in list //UC7
            //list.Add(30); // Adding data in list //UC7
            //list.Add(70); // Adding data in list //UC7
            //list.Display(); //call Display method to print data//UC7
            //list.Search(56); //Search Element in Linked List //UC7


            list.Add(56); // Adding data in list //UC8
            list.Add(30); // Adding data in list //UC8
            list.Add(70); // Adding data in list //UC8
            list.Display(); //call Display method to print data//UC8
            list.InsertAtAfterValue(30, 40); //Call InsertAtAfterValue pass value //UC8

            list.Display();
            Console.ReadLine();
        }
    }
}
