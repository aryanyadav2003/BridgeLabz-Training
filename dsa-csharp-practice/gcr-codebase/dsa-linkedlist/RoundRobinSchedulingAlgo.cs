using System;
class Process
{
    public int Pid;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnaroundTime;
    public Process Next;
    public Process(int pid, int bt, int priority)
    {
        Pid = pid;
        BurstTime = bt;
        RemainingTime = bt;
        Priority = priority;
        WaitingTime = 0;
        TurnaroundTime = 0;
        Next = null;
    }
}
class RoundRobinScheduler
{
    private Process head;
    public void AddProcess(int pid, int bt, int priority)
    {
        Process newNode = new Process(pid, bt, priority);
        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }
        Process temp = head;
        while (temp.Next != head)
            temp = temp.Next;
        temp.Next = newNode;
        newNode.Next = head;
    }
    private void RemoveProcess(Process prev, Process curr){
        if (curr == head && curr.Next == head)
        {
            head = null;
            return;
        }
        if (curr == head)
            head = head.Next;
        prev.Next = curr.Next;
    }
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes left");
            return;
        }
        Process temp = head;
        while (true)
        {
            Console.WriteLine("PID: " + temp.Pid +", Remaining Time: " + temp.RemainingTime);
            temp = temp.Next;
            if (temp == head)
                break;
        }
    }
    public void Schedule(int timeQuantum)
    {
        int time = 0;
        Process curr = head;
        Process prev = null;
        while (head != null)
        {
            if (curr.RemainingTime > timeQuantum)
            {
                curr.RemainingTime -= timeQuantum;
                time += timeQuantum;
            }
            else
            {
                time += curr.RemainingTime;
                curr.RemainingTime = 0;
                curr.TurnaroundTime = time;
                curr.WaitingTime = curr.TurnaroundTime - curr.BurstTime;
                Console.WriteLine("\nProcess Completed: PID " + curr.Pid);
                RemoveProcess(prev, curr);
            }
            Console.WriteLine("\nProcess Queue After Round:");
            DisplayProcesses();
            if (head == null)
                break;
            prev = curr;
            curr = curr.Next;
        }
    }
    public void CalculateAverages(Process[] processes)
    {
        int totalWT = 0, totalTAT = 0;
        foreach (Process p in processes)
        {
            totalWT += p.WaitingTime;
            totalTAT += p.TurnaroundTime;
        }
        Console.WriteLine("\nAverage Waiting Time: " +
            (double)totalWT / processes.Length);
        Console.WriteLine("Average Turnaround Time: " +
            (double)totalTAT / processes.Length);
    }
}
class RoundRobinSchedulerAlgo
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        Process[] allProcesses = new Process[3];
        allProcesses[0] = new Process(1, 10, 1);
        allProcesses[1] = new Process(2, 5, 2);
        allProcesses[2] = new Process(3, 8, 1);
        foreach (Process p in allProcesses){
            scheduler.AddProcess(p.Pid, p.BurstTime, p.Priority);
            }
        int timeQuantum = 4;
        Console.WriteLine("Initial Process Queue:");
        scheduler.DisplayProcesses();
        scheduler.Schedule(timeQuantum);
        scheduler.CalculateAverages(allProcesses);
    }
}
