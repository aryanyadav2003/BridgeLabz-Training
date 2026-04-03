class RevenueCalculator
{
    public int CalculateMaxRevenue(int[] price,int length)
    {
        if (length == 0)
        {
            return 0;
        }
        int maxRevenue=-1;
        for(int i = 1; i <= length; i++)
        {
            int revenue=price[i]+CalculateMaxRevenue(price,length-i);
            if (revenue > maxRevenue)
            {
                maxRevenue=revenue;
            }
        }
        return maxRevenue;
    }
}