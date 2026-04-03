using System;
class Device{
    public int DeviceId;
    public string Status;

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}
class Thermostat : Device{
    public int TemperatureSetting;
    public override void DisplayStatus(){
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("Temperature Setting: " + TemperatureSetting +"°C");
    }
}
class SmartHomeSystem{
    static void Main(){
        Thermostat t = new Thermostat();
        t.DeviceId = 11;
        t.Status = "ON";
        t.TemperatureSetting =30;
 		t.DisplayStatus();
    }
}
