using System;
public class Program
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }
    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach (var creator in records)
        {
            int count = 0;
            for (int i = 0; i < creator.WeeklyLikes.Length; i++)
            {
                if (creator.WeeklyLikes[i] >= likeThreshold)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }
        return result;
    }
    public double CalculateAverageLikes()
    {
        if (CreatorStats.EngagementBoard.Count == 0)
            return 0;

        double total = 0;
        int count = 0;

        foreach (var creator in CreatorStats.EngagementBoard)
        {
            foreach (var like in creator.WeeklyLikes)
            {
                total += like;
                count++;
            }
        }

        return total / count;
    }
}

