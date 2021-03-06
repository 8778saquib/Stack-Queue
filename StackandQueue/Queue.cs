using System;
namespace StackandQueue
{
    public class Queue
    {
        internal node head = null;

        //For inserting the node at the end of the queue
        internal void Enqueue(int data)
        {
            node newNode = new node(data);

            //If queue is empty insert nowNode at first position
            if (head == null)
            {
                head = newNode;
            }
            //else insert at the end of our queue/linkedlist
            else
            {
                node tempHead = head;
                while (tempHead.next != null)
                {
                    tempHead = tempHead.next;
                }
                tempHead.next = newNode;
            }
            Console.WriteLine(newNode.data + " is enqueued/inserted into the queue");
        }
        //For deleting/dequeueing node from the front/head of the queue
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty : nothing to dequeue");
            }
            else
            {
                Console.WriteLine(head.data + " is dequeued/deleted from the queue");

                //Moving head to the next node
                head = head.next;
            }
        }


        //For displaying nodes present in the queue
        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                Console.Write("Queue is : front/head");
                node tempHead = head;
                while (tempHead != null)
                {
                    Console.Write(" -> " + tempHead.data);
                    tempHead = tempHead.next;
                }
                Console.WriteLine(" <- rear/tail\n");
            }
        }
    }
}
