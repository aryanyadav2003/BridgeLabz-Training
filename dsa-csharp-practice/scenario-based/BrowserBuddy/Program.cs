// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        BrowserBuddyUtility browser=new BrowserBuddyUtility();
        browser.Visit("google.com");
        browser.Visit("github.com");
        browser.ShowCurrentPage();
        browser.Back();
        browser.Visit("youtube.com");
        browser.ShowCurrentPage();
        browser.Visit("linkedIn.com");
        browser.Back();
        browser.ShowCurrentPage();
        browser.Forward();
        browser.ShowCurrentPage();
        browser.CloseTab();
        browser.RestoreTab();
        browser.ShowCurrentPage();
        
    }
}