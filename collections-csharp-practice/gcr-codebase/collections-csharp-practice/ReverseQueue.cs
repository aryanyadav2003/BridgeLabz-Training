using System;
class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue=new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        ReverseQueue(queue);
        foreach (int item in queue)
            Console.Write(item + " ");
    }
    static void ReverseQueue(Queue<int> q)
    {
        int n=q.Count;
        for(int i = 0; i < n; i++)
        {
            int last=q.Dequeue();
            for(int j = 0; j < n - i - 1; j++)
            {
                q.Enqueue(q.Dequeue());
            }
            q.Enqueue(last);
        }
    }
}