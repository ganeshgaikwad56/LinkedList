using System;

namespace LinkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Welcome to linked list program.");


            Console.WriteLine("Welcome to the Linked List Operations");
            //UseCase 1
            Operation obj = new Operation();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("Insertion at Last");
            obj.Display();
            Console.ReadLine();
        }
    }
}