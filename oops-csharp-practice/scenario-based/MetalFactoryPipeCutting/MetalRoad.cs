using System;
class MetalRod
{
    public int Length{get;set;}
    public int[] Price{get;set;}
    public MetalRod(int length)
    {
        Length=length;
        Price=new int[length+1];
    }
    public void InputPrices()
    {
        for(int i = 1; i <=Length; i++)
        {
            Console.Write("Enter price for length " + i + " :");
            Price[i]=int.Parse(Console.ReadLine());
        }   
    }
}