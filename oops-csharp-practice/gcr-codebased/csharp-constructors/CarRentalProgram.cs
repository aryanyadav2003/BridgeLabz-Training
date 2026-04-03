using System;
class CarRental{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;
    public double CostPerDay;
    public double TotalCost;
	
    public CarRental(){
        CustomerName = "abc";
        CarModel = "Standard";
        RentalDays = 1;
        CostPerDay = 1000;
        CalculateTotalCost();
    }

    public CarRental(string customerName, string carModel, int rentalDays){
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;

        if (carModel == "SUV")
            CostPerDay = 2000;
        else if (carModel == "Sedan")
            CostPerDay = 1500;
        else
            CostPerDay = 1000;

        CalculateTotalCost();
    }

    public void CalculateTotalCost(){
        TotalCost = RentalDays * CostPerDay;
    }

    public void ShowRentalDetails(){
        Console.WriteLine("Customer Name: " + CustomerName);
        Console.WriteLine("Car Model: " + CarModel);
        Console.WriteLine("Rental Days: " + RentalDays);
        Console.WriteLine("Cost per Day: " + CostPerDay);
        Console.WriteLine("Total Cost: " + TotalCost);
    }
}

class CarRentalProgram{
    static void Main(){
        CarRental r1 = new CarRental();
        r1.ShowRentalDetails();

        Console.WriteLine();
		
        CarRental r2 = new CarRental("Aryan", "SUV", 3);
        r2.ShowRentalDetails();
    }
}
