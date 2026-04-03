using System;
class AC : Appliance
{
    public AC() : base("Air Conditioner") { }
    public override void TurnOn()
    {
        Console.WriteLine("AC is turned ON at 24°C cooling mode.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("AC is turned OFF.");
    }
}
