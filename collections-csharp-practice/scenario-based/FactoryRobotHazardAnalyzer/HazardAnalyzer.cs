using System;
using System.Diagnostics.Contracts;

public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
        
    }
}
class HazardAnalyzer
{
    public double CalculateRisk(double armPrecision,int workDensity,string machinaryState)
    {
        if(armPrecision<0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error:Arm precision must be 0.0-1.0");
        }
        if(workDensity<1 || workDensity > 20)
        {
            throw new RobotSafetyException("Error:Worker density musst be 1-20");
        }
        double riskFactor;
        if (string.Equals(machinaryState, "Worn", StringComparison.OrdinalIgnoreCase))
        {
            riskFactor=1.3;
        }
        else if (string.Equals(machinaryState, "Faulty", StringComparison.OrdinalIgnoreCase))
        {
            riskFactor=2.0;
        }
        else if (string.Equals(machinaryState, "Critical", StringComparison.OrdinalIgnoreCase))
        {
            riskFactor=3.0;
        }
        else
        {
            throw new RobotSafetyException("Error:Unsupported machinary state");
        }
        double answer=((1.0 - armPrecision) * 15.0) + (workDensity * riskFactor);
        return answer;
    }
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter arm precision (0.0 - 1.0): ");
            double armPrecision=double.Parse(Console.ReadLine());
            Console.Write("Enter workDensity (1-20): ");
            int workDensity=int.Parse(Console.ReadLine());  
            Console.Write("Enter Machinary State (Worn/Faulty/Critical): ");
            string machinaryState=Console.ReadLine();
            HazardAnalyzer rh=new HazardAnalyzer();
            double risk=rh.CalculateRisk(armPrecision,workDensity,machinaryState);
            Console.WriteLine("Robot hazard risk score : " + risk);
        }
        catch(RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}