using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class LinkedList
    {

        public Node head; //first node head
        /* UC1:- Lets create a simple Linked List of 56, 30 and 70
          */
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data); //create object Node  
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.next = new_node; //add new node

            }
            Console.WriteLine($"Inserted into List {new_node.data}");
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        /*UC2:- Ability to create Linked List by adding 30 and 56 to 70
                - Node with data 70 is First Created- Next 30 is added to 70
                - Finally 56 is added to 30
                - LinkedList Sequence: 56->30->70
        */
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);//create new node then new node point to the head of the linked list
            new_node.next = this.head;// add any node at the front point head 
            this.head = new_node; // The Previous Head is now the second node of linked List the new node is added at the
            Console.WriteLine($"Inserted into list {new_node.data}"); //print

        }


        public void Display() //create Display Method
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine($" {temp.data} ");//print Node
                    temp = temp.next; //point to next node
                }
            }

        }
    }
}
