using System;
using System.Text.RegularExpressions;
public class FlightUtil
{
    public bool ValidateFlightNumber(string flightNumber){
    string pattern=@"^FL-[1-9][0-9]{3}";
    if(!Regex.IsMatch(flightNumber,pattern)){
        throw new InvalidFlightException("The flight number" + flightNumber + "is invalid");
    }
    return true;
    }
    public bool ValidateFlightName(string flightName)
    {
        if(!(flightName.Equals("SpiceJet") || flightName.Equals("Vistara") || flightName.Equals("IndiGo") || flightName.Equals("Air Arabia"))){
            throw new InvalidFlightException("The flight name " + flightName + " is invalid");
        }
        return true;
    }
    public bool ValidatePassengerCount(int passengerCount,string flightName)
    {
        int maxCapacity=0;
        if (flightName.Equals("SpiceJet"))
        {
            maxCapacity=396;
        }
        else if (flightName.Equals("Vistara"))
            maxCapacity = 615;
        else if (flightName.Equals("IndiGo"))
            maxCapacity = 230;
        else if (flightName.Equals("Air Arabia"))
            maxCapacity = 130;
        if(passengerCount<=0 || passengerCount > maxCapacity)
        {
            throw new InvalidFlightException("The passenger count " + passengerCount + " is invalid for " + flightName);
        }
        return true;
    }
    public double CalculateFuelToFillTank(string flightName,double currentFuelLevel)
    {
        double maxFuelCapacity=0;
        if (flightName.Equals("SpiceJet"))
            maxFuelCapacity = 200000;
        else if (flightName.Equals("Vistara"))
            maxFuelCapacity = 300000;
        else if (flightName.Equals("IndiGo"))
            maxFuelCapacity = 250000;
        else if (flightName.Equals("Air Arabia"))
            maxFuelCapacity = 150000;
            if(currentFuelLevel<0 || currentFuelLevel > maxFuelCapacity)
        {
            throw new InvalidFlightException("Invalid fuel level for " + flightName);
        }
        return maxFuelCapacity-currentFuelLevel;
    }
}