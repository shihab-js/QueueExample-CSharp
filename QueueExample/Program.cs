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
        }
    }
}
