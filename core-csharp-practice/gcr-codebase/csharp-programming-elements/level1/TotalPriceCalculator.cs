using System;

class TotalPriceCalculator{
    static void Main(){
        int unitPrice = Convert.ToInt32(Console.ReadLine());
        int quantity = Convert.ToInt32(Console.ReadLine());
        int totalPrice = unitPrice * quantity;
        Console.WriteLine(
            "The total purchase price is INR " + totalPrice +
            " if the quantity " + quantity +
            " and unit price is INR " + unitPrice
        );
    }
}
