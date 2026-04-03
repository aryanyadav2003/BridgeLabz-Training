using System;
public class BrowserBuddyUtility
{
    private BrowserTab activeTab;
    private Stack<BrowserTab> closedTabs;
    public BrowserBuddyUtility()
    {
        activeTab=new BrowserTab("home.com");
        closedTabs=new Stack<BrowserTab>();
    }
    public void Visit(string url)
    {
        activeTab.Visit(url);
    }
    public void Back()
    {
        activeTab.Back();
    }
    public void Forward()
    {
        activeTab.Forward();
    }
    public void CloseTab()
    {
        closedTabs.Push(activeTab);
        activeTab=new BrowserTab("home.com");
        Console.WriteLine("Tab closed");

    }
    public void RestoreTab()
    {
        if (closedTabs.Count > 0)
        {
            activeTab=closedTabs.Pop();
            Console.WriteLine("Tabs restored");
        }
        else
        {
            Console.WriteLine("No tabs to restore");
        }
    }
    public void ShowCurrentPage()
    {
        Console.WriteLine("Current Tab : " + activeTab.GetCurrentPage());
    }
}