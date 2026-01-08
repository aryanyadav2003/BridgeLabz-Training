using System;

class ApplianceUtilityImpl
{
    public void ControlAppliance(Appliance appliance)
    {
        appliance.GetApplianceDetails();
        appliance.TurnOn();
        appliance.TurnOff();
    }
    public void ControlLight()
    {
        Appliance light = new Light();
        ControlAppliance(light);
    }
    public void ControlFan()
    {
        Appliance fan = new Fan();
        ControlAppliance(fan);
    }
    public void ControlAC()
    {
        Appliance ac = new AC();
        ControlAppliance(ac);
    }
}
