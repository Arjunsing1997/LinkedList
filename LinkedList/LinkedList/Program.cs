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
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
