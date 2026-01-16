public class HistoryNode
{
    public string Url;
    public HistoryNode prev;
    public HistoryNode next;
    public HistoryNode(string url)
    {
        Url=url;
        prev=null;
        next=null;
    }
}