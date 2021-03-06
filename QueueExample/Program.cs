using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a queue 
            var names = new Queue<string>();

            //add elements
            names.Enqueue("shihab");
            names.Enqueue("Mishu");
            names.Enqueue("Rayhan");

            //Iterate the queue
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //dequeue a element
            Console.WriteLine(names.Dequeue());

            Console.WriteLine("After dequeue a element: ");

            //after dequeue a element
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
