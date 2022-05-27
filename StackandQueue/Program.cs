using System;

namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues program");

            Console.WriteLine("\n1. Create Stack of 56->30->70");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Stack s1 = new Stack();
                    s1.Push(70);
                    s1.Push(30);
                    s1.Push(56);
                    s1.display();
                    break;
                default:
                    Console.WriteLine("Please choose correct option from the list");
                    break;
            }
        }
    }
}
