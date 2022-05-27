using System;
namespace StackandQueue
{
    public class Stack
    {
        internal node top;

        //For initializing top to null
        public Stack()
        {
            top = null;
        }

        //For pushing/(adding node at first position) the node onto the stack
        internal void Push(int data)
        {
            node newNode = new node(data);

            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(newNode.data + " is pushed/inserted onto the stack");

        }



        //For peeking stack
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top of the stack is : " + top.data);
        }

        //For popping/(deleting first) node from the stack
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty : nothing to pop");
                return;
            }
            Console.WriteLine(top.data + " is popped/deleted from the stack");
            top = top.next;
        }



        //For displaying theh stack
        internal void display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("The Stack is :\n");
            Console.Write(" top ->");
            node tempNode = top;

            while (tempNode != null)
            {
                Console.WriteLine("\t| " + tempNode.data + " |");
                tempNode = tempNode.next;
            }
            Console.WriteLine();
        }
    }
}
