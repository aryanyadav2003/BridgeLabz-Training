using System;
class ScenarioC
{
    public static void Run()
    {
        int[] notes = { 2, 5, 10 };
        ATMDispenser atm = new ATMDispenser(notes);
        atm.Dispense(3);
        Console.WriteLine("--------------------------");
    }
}
