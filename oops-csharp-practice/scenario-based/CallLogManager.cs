using System;
class CallLog
{
    public string phoneNumber;
    public string message;
    public DateTime timeStamp;
    public void Display()
    {
        Console.WriteLine("Phone number : " + phoneNumber);
        Console.WriteLine("Message : " + message);
        Console.WriteLine("Time stamp : " + timeStamp);
    }
}
class CallLogManager
{
    CallLog[] logs=new CallLog[5];
    int count=0;
    public void AddCallLog()
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Log storage full");
            return;
        }
        CallLog log = new CallLog();
        
        Console.Write("Enter phone number: ");
        log.phoneNumber = Console.ReadLine();

        Console.Write("Enter message: ");
        log.message = Console.ReadLine();

        log.timeStamp = DateTime.Now;
        logs[count]=log;
        count++;
        Console.WriteLine("Call log added");
   }
   public void SearchByKeyword()
    {
        Console.Write("Enter keyword to search: ");
        string keyword = Console.ReadLine();
        bool found=false;
        for(int i=0 ;i < count; i++)
        {
            if (logs[i].message.Contains(keyword))
            {
                logs[i].Display();
                found=true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No logs found with given keyword");
        }
    }
    public void FilterByTime()
    {
        Console.Write("Enter start time (yyyy-MM-dd HH:mm): ");
        DateTime start = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter end time (yyyy-MM-dd HH:mm): ");
        DateTime end = DateTime.Parse(Console.ReadLine());
         
        bool found = false;
        for(int i = 0; i < count; i++)
        {
            if(logs[i].timeStamp>=start && logs[i].timeStamp <= end)
            {
                logs[i].Display();
                found=true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No logs found in this time range");
        }
    }
}
class Program
{
    static void Main()
    {
        CallLogManager m=new CallLogManager();
        m.AddCallLog();
        m.AddCallLog();
        m.SearchByKeyword();
        m.FilterByTime();
    }
}