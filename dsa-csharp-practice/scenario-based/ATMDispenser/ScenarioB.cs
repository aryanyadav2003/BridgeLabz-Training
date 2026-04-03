using System;
class ScenarioB
{
    public static void Run()
    {
        int[] notes = { 200, 100, 50, 20, 10, 5, 2, 1 };
        ATMDispenser atm = new ATMDispenser(notes);
        atm.Dispense(880);
        Console.WriteLine("--------------------------");
    }
}
