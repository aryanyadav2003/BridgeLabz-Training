using System;
using System.Text.RegularExpressions;
class ValidateCreditCard
{
    static void Main()
    {
        string[] cards =
        {
            "4111111111111111", // Visa
            "5111111111111111", // MasterCard
            "6111111111111111", // Invalid
            "41234"             // Invalid
        };
        string pattern = @"^(4\d{15}|5\d{15})$";
        foreach (string card in cards)
        {
            if (Regex.IsMatch(card, pattern))
                Console.WriteLine($"{card} → Valid");
            else
                Console.WriteLine($"{card} → Invalid");
        }
    }
}
