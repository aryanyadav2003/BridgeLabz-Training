using System;

namespace TrafficManager
{
    class VehicleQueue
    {
        private string[] queue;
        private int front, rear, capacity;

        public VehicleQueue(int size)
        {
            capacity = size;
            queue = new string[capacity];
            front = rear = -1;
        }

        public void Enqueue(string vehicle)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Queue Overflow! Waiting area full.");
                return;
            }

            if (front == -1)
                front = 0;

            queue[++rear] = vehicle;
            Console.WriteLine("Vehicle added to waiting queue.");
        }

        public string Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow! No vehicles waiting.");
                return null;
            }

            return queue[front++];
        }

        public void Display()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Waiting queue is empty.");
                return;
            }

            Console.Write("Waiting Queue: ");
            for (int i = front; i <= rear; i++)
                Console.Write(queue[i] + " ");

            Console.WriteLine();
        }
    }
}
