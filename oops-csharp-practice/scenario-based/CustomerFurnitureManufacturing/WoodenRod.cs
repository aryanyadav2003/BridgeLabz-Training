using System;
class WoodenRod
{
    public int Length{get;set;}
    public int[] Price{get;set;}
    public WoodenRod(int length)
    {
        Length=length;
        Price=new int[length+1];
    }
    public void InputPrices()
    {
        Console.WriteLine("Enter price for each length : ");
        for(int i = 1; i <= Length; i++)
        {
            Console.Write("Price for " + i + "ft : ");
            Price[i]=int.Parse(Console.ReadLine());
        }
    }
}