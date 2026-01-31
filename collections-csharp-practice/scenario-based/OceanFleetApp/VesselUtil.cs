using System.Collections.Generic;
public class VesselUtil
{
    private List<Vessel> vesselList = new List<Vessel>();
    public List<Vessel> getVesselList()
    {
        return vesselList;
    }
    public void setVesselList(List<Vessel> vesselList)
    {
        this.vesselList = vesselList;
    }

    // Requirement 1
    public void addVesselPerformance(Vessel vessel)
    {
        vesselList.Add(vessel);
    }

    // Requirement 2
    public Vessel getVesselById(string vesselId)
    {
        foreach (Vessel v in vesselList)
        {
            if (v.vesselId == vesselId)
            {
                return v;
            }
        }
        return null;
    }

    // Requirement 3
    public List<Vessel> getHighPerformanceVessels()
    {
        List<Vessel> result = new List<Vessel>();
        double maxSpeed = 0;

        // Find highest speed
        foreach (Vessel v in vesselList)
        {
            if (v.averageSpeed > maxSpeed)
            {
                maxSpeed = v.averageSpeed;
            }
        }

        // Collect vessels with highest speed
        foreach (Vessel v in vesselList)
        {
            if (v.averageSpeed == maxSpeed)
            {
                result.Add(v);
            }
        }

        return result;
    }
}

