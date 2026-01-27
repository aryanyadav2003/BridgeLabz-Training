using System;
public class LegacyAPI
{
    [Obsolete("OldFeature is deprecated.Use New feature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Executing old feature...");
    }
    public void NewFeature()
    {
        Console.WriteLine("Executing new feature...");
    }
}
class Feature
{
    static void Main(string[] args)
    {
        LegacyAPI api=new LegacyAPI();
        api.OldFeature();
        api.NewFeature();
    }
}