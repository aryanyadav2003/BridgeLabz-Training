using System;
abstract class Appliance : IControllable
{
    protected string applianceName;
    public Appliance(string name)
    {
        applianceName = name;
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
    public void GetApplianceDetails()
    {
        Console.WriteLine("Appliance : " + applianceName);
    }
}
