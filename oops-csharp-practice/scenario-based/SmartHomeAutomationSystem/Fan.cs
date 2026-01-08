using System;
class Fan : Appliance
{
    public Fan() : base("Fan") { }
    public override void TurnOn()
    {
        Console.WriteLine("Fan is turned ON at medium speed.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Fan is turned OFF.");
    }
}
