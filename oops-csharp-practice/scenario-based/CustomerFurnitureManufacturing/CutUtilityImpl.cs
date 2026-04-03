using System;
class CutUtilityImpl
{
    public int MaxRevenue(int[] price,int length)
    {
        if (length == 0)
        {
            return 0;
        }
        int max=-1;
        for(int i = 1; i <= length; i++)
        {
            int revenue=price[i]+MaxRevenue(price,length-i);
            if (revenue > max)
            {
                max=revenue;
            }
        }
        return max;
    }
    public int RevenueWithFixedCut(int[] price,int totalLength,int fixedCut)
    {
        if (fixedCut > totalLength)
        {
            return 0;
        }
        int remainingLength=totalLength-fixedCut;
        int fixedRevenue=price[fixedCut];
        int remainingRevenue=MaxRevenue(price,remainingLength);
        return fixedRevenue+remainingRevenue;
    }
    public int MaxRevenueWithWaste(int[] price,int totalLength,int maxWaste)
    {
        int bestRevenue=0;
        for(int usedLength = totalLength; usedLength >= totalLength - maxWaste; usedLength--)
        {
            int revenue=MaxRevenue(price,usedLength);
            if (revenue > bestRevenue)
            {
                bestRevenue=revenue;
            }
        }
        return bestRevenue;
    }
}