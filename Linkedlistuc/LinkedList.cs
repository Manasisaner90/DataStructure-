﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistuc
{
 class LinkedList
  {
    public Node head;
   //  public void Add(int data)
   //{
   //   Node node = new Node(data);
   //         if (this.head == null)
   //          this.head = node;
   //      else
   //      {
   //           Node temp = head;
   //           while (temp.next != null)
   //           {
   //               temp = temp.next;
   //           }
   //           temp.next = node;
   //       }
   //         Console.WriteLine("{0} inserted into the linked list",node.data);
   //  }

   //     public void Append(int data)
   //    {
   //        Node node = new Node(data);
   //    Node temp = head;
   //         while (temp.next != null)
   //         {
   //             temp = temp.next;
   //         }
   //       temp.next = node;
   //         Console.WriteLine(node.data + " " + "Appended into Linked List ");

   //     }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Empty Linked list");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }

}

