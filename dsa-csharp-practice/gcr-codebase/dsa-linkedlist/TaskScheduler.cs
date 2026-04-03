using System;
class TaskNode{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;
    public TaskNode(int id, string name, int priority, string dueDate){
        TaskId = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class CircularTaskList{
    private TaskNode head;
    private TaskNode current;
    public void AddAtBeginning(int id, string name, int priority, string dueDate){
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        if (head == null){
            head = current = newNode;
            newNode.Next = head;
            return;
        }
        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        newNode.Next = head;
        temp.Next = newNode;
        head = newNode;
    }
    public void AddAtEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        if (head == null)
        {
            head = current = newNode;
            newNode.Next = head;
            return;
        }
        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }
    public void AddAtPosition(int pos, int id, string name, int priority, string dueDate)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, priority, dueDate);
            return;
        }
        TaskNode temp = head;
        int count = 1;
        while (count < pos - 1 && temp.Next != head)
        {
            temp = temp.Next;
            count++;
        }
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }
    public void RemoveById(int id)
    {
        if (head == null) return;
        TaskNode temp = head;
        TaskNode prev = null;
        while (true)
        {
            if (temp.TaskId == id)
            {
                if (temp == head)
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                Console.WriteLine("Task removed");
                return;
            }
            prev = temp;
            temp = temp.Next;
            if (temp == head)
                break;
        }

        Console.WriteLine("Task not found");
    }
    public void ViewCurrentTask(){
        if (current == null)
        {
            Console.WriteLine("No tasks available");
            return;
        }
        Console.WriteLine("Task: " + current.TaskName + ", Priority: " + current.Priority);
        current = current.Next;
    }
    public void DisplayAll(){
        if (head == null){
            Console.WriteLine("No tasks available");
            return;
        }
        TaskNode temp = head;
        while (true){
            Console.WriteLine("ID: " + temp.TaskId +", Name: " + temp.TaskName +", Priority: " + temp.Priority +", Due: " + temp.DueDate);
            temp = temp.Next;
            if (temp == head)
                break;
        }
    }
    public void SearchByPriority(int priority){
        if (head == null) return;
        TaskNode temp = head;
        bool found = false;
        while (true){
            if (temp.Priority == priority)
            {
                Console.WriteLine("ID: " + temp.TaskId +", Name: " + temp.TaskName +", Due: " + temp.DueDate);
                found = true;
            }
            temp = temp.Next;
            if (temp == head)
                break;
        }
        if (!found)
            Console.WriteLine("No task found with this priority");
    }
}
class TaskScheduler
{
    static void Main()
    {
        CircularTaskList scheduler = new CircularTaskList();
        scheduler.AddAtEnd(1, "Assignment", 1, "10-01-2026");
        scheduler.AddAtEnd(2, "Project", 2, "15-01-2026");
        scheduler.AddAtBeginning(3, "Exam Prep", 1, "08-01-2026");
        Console.WriteLine("All Tasks:");
        scheduler.DisplayAll();
        Console.WriteLine("Current Tasks:");
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        Console.WriteLine("Search Priority 1:");
        scheduler.SearchByPriority(1);
        Console.WriteLine("Remove Task ID 2:");
        scheduler.RemoveById(2);
        Console.WriteLine("Final Tasks:");
        scheduler.DisplayAll();
    }
}
