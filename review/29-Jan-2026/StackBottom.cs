using System;
class CustomStack
{
    private int[] stack;
    private int top;
    private int size;

    public CustomStack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }
    public void Push(int value)
    {
        if (top == size - 1)
            return;
        stack[++top] = value;
    }
    public int Pop()
    {
        if (IsEmpty()){
            return -1;
        }
        return stack[top--];
    }
    public int Peek()
    {
        if (IsEmpty())
            return -1;
        return stack[top];
    }
    public bool IsEmpty()
    {
        return top == -1;
    }
    public void Display()
    {
        if (IsEmpty())
            return;

        for (int i = top; i >= 0; i--){
            Console.Write(stack[i] + " ");
        }
        Console.WriteLine();
    }
    public void InsertAtBottom(int value)
    {
        CustomStack temp = new CustomStack(size);
        while (!IsEmpty()){
            temp.Push(Pop());
        }
        Push(value);
        while (!temp.IsEmpty()){
            Push(temp.Pop());
        }
    }
}
class StackBottom
{
    static void Main()
    {
        CustomStack s = new CustomStack(5);
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Display();
        s.InsertAtBottom(6);
        s.Display();
    }
}