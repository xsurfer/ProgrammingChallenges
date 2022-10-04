using System;

namespace FIFOQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue q = new Queue(3);
            q.add(1);
            q.add(2);
            q.add(3);
            Console.WriteLine(q.poll());
            Console.WriteLine(q.poll());
            Console.WriteLine(q.poll());
            q.add(4);
            q.add(5);
            q.add(6);
            Console.WriteLine(q.poll());
            Console.WriteLine(q.poll());
            Console.WriteLine(q.poll());
        }
    }
}
