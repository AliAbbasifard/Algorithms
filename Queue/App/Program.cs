using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<string> queue = new Queue_LinkList<string>();

            queue.Enqueue("S");
            queue.Dequeue();
            queue.Enqueue("S");

        }
    }
}
