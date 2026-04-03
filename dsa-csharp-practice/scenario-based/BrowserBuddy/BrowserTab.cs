public class BrowserTab
{
    private HistoryNode current;
    public BrowserTab(string homepage)
    {
        current=new HistoryNode(homepage);

    }
    public void Visit(string url)
    {
        HistoryNode newNode=new HistoryNode(url);
        current.next=newNode;
        newNode.prev=current;
        current=newNode;
    }
    public void Back()
    {
        if (current.prev != null)
        {
            current=current.prev;
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }
    public void Forward()
    {
        if (current.next != null)
        {
            current=current.next;
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }
    public string GetCurrentPage()
    {
        return current.Url;
    }

}