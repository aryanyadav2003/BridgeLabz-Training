using System;
class MovieManager : IMovie
{
    private string[] titles=new string[0];
    private string[] times=new string[0];
    private int count=0;
    public void AddMovie(string title,string time)
    {
        if (!IsValidTime(time))
        {
            Console.WriteLine("Invalid time format (HH:MM)");
            return;
        }
        string[] newTitles=new string[count+1];
        string[] newTimes=new string[count+1];
         for (int i = 0; i < count; i++)
        {
            newTitles[i] = titles[i];
            newTimes[i] = times[i];
        }
        newTitles[count] = title;
        newTimes[count] = time;
        titles = newTitles;
        times = newTimes;
        count++;
        Console.WriteLine("Movie added");
    }
    public void SearchMovie(string keyword)
    {
        bool found=false;
        for(int i = 0; i <count; i++)
        {
            if (titles[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Movie : " + titles[i] + " Time : " + times[i]);
                found=true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No movie found");
        }
    }
    public void DisplayAllMovies()
    {
        if (count == 0)
        {
            Console.WriteLine("No movies available");
            return;
        }
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine($"{titles[i]} at {times[i]}");
        }
    }
    public void GenerateReport()
    {
        Console.WriteLine("--- Movie Report ---");
        for(int i = 0; i <count; i++)
        {
            Console.WriteLine(titles[i] + " at " + times[i]);
        }
    }
    public bool IsValidTime(string time)
    {
        if(time.Length!=5 || time[2] != ':')
        {
            return false;
        }
        int hour=int.Parse(time.Substring(0,2));
        int minute=int.Parse(time.Substring(3,2));
        return hour>=0 && hour <24 && minute >=0 &&minute<60;
    }
}