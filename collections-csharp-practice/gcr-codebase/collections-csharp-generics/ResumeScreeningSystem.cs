using System;
using System.Collections.Generic;
abstract class JobRole
{
    public string CandidateName{get;set;}
    public abstract void Screen();
}
class SoftwareEngineer : JobRole
{
    public override void Screen()=> Console.WriteLine($"{CandidateName} screened for Software Engineer");
}
class DataScientist : JobRole
{
    public override void Screen() =>
        Console.WriteLine($"{CandidateName} screened for Data Scientist");
}
class Resume<T> where T : JobRole
{
     private List<T> candidates = new List<T>();

    public void AddCandidate(T candidate) => candidates.Add(candidate);

    public void ProcessResumes()
    {
        foreach (var candidate in candidates)
            candidate.Screen();
    }
}
class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        seResumes.AddCandidate(new SoftwareEngineer { CandidateName = "Aryan" });

        seResumes.ProcessResumes();
    }
}