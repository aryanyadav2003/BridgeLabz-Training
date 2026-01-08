using System;
class Light : Appliance
{
    public Light() : base("Light") { }
    public override void TurnOn()
    {
        Console.WriteLine("Light is turned ON with normal brightness.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Light is turned OFF.");
    }
}
