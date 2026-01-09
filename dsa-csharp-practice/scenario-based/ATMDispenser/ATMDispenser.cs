using System;
class ATMDispenser : IDispenser
{
    private int[] notes;
    public ATMDispenser(int[] availableNotes)
    {
        notes=availableNotes;
    }
    public void Dispense(int amount)
    {
        int remaining=amount;
        for(int i = 0; i < notes.Length; i++)
        {
            int count=remaining/notes[i];
            if (count > 0)
            {
                Console.WriteLine($"{notes[i]} * {count}");
                remaining=remaining%notes[i];
            }
            }
        if (remaining > 0)
        {
            Console.WriteLine("Exchange change is not possible");
            Console.WriteLine($"Remaining amount: {remaining}");
        }
        else
        {
            Console.WriteLine("Amount dispensed successfully");
        }
    }
}