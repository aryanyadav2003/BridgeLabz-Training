using System;
class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;
    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}
class TextEditor
{
    private TextState head;
    private TextState tail;
    private TextState current;
    private int count;
    private const int MAX = 10;
    public void AddState(string text)
    {
        TextState newNode = new TextState(text);
        if(current != null && current.Next != null)
        {
            current.Next.Prev = null;
            current.Next = null;
            tail = current;
        }
        if(head == null)
        {
            head = tail = current = newNode;
            count = 1;
        }
        else{
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            current = newNode;
            count++;
        }
        if (count > MAX)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo successful");
        }
        else
        {
            Console.WriteLine("Nothing to undo");
        }
    }
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo successful");
        }
        else
        {
            Console.WriteLine("Nothing to redo");
        }
    }
    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Content);
        else
            Console.WriteLine("No text available");
    }
}
class UndoRedoFunctionality{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        editor.Display();
        editor.AddState("Hello World");
        editor.Display();
        editor.AddState("Hello World!");
        editor.Display();
        editor.Undo();
        editor.Display();
        editor.Undo();
        editor.Display();
        editor.Redo();
        editor.Display();
        editor.AddState("Hello C#");
        editor.Display();
        editor.Redo();
    }
}
