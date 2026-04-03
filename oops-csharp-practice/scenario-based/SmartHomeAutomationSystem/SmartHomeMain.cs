using System;
class SmartHomeMain
{
    static void Main()
    {
        ApplianceUtilityImpl utility = new ApplianceUtilityImpl();

        utility.ControlLight();
        Console.WriteLine();

        utility.ControlFan();
        Console.WriteLine();

        utility.ControlAC();
    }
}
