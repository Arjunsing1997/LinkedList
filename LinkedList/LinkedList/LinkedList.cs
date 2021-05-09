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
        public void Add(int new_data)
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

        /* UC3:- Ability to create Linked List by appending 30 and 70 to 56.
                 - Node with data 56 is First Created.
                 - Next Append 30 to 56. 
                 - Finally Append 70 to 30.
                 - LinkedList Sequence: 56->30->70.
        */

        public void Appending(int value)
        {
            Add(value);
        }


        /* UC4:- Ability to insert 30 between 56 and 70.
                 - Final Sequence: 56->30->70.
         */
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine($"Invalid Position{ position}");
            }
            if (position == 1)
            {
                var newNode = new Node(data); //create object and passing data
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine($"Position Out Of Range{ position}");
                }
            }
            Console.WriteLine($"Successfully added Position of Element {position},{data}");
            return head;
        }

        /* UC5:- Ability to delete the first element in the LinkedList of sequence 56->30->70.
                 - Write pop method. 
                 - Note there is new head.
                 - Final Sequence: 30->70.
          */

        public void DeleteFirstNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            head = temp.next;
            Console.WriteLine($"Successfully Delete First Element {temp.data}");

        }
        /// <summary>
        /// Deletes the last node.
        /// </summary>
        public void DeleteLastNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine($"Successfully Delete Last Element {temp.next.data}");
                temp.next = null;
            }

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
                    Console.WriteLine($"Linked List Element:- {temp.data} ");//print Node
                    temp = temp.next; //point to next node
                }
            }

        }

    }
}
