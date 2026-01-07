using System;
abstract class Patient{
    public string patientId;
    public string name;
    public int age;
    private string diagnosis;
    private string medicalHistory;

    public abstract double CalculateBill();
    public virtual void ViewRecords()
    {
        Console.WriteLine("Diagnosis : " + diagnosis);
        Console.WriteLine("Medical History : " + medicalHistory);
    }
    protected void SetMedicalRecord(string d, string h)
    {
        diagnosis = d;
        medicalHistory = h;
    }
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + patientId);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}
class InPatient : Patient
{
    public int numberOfDays;
    public int dailyCharge;

    public InPatient(string id, string name, int age, int days, int charge, string diagnosis, string history)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
        this.numberOfDays = days;
        this.dailyCharge = charge;
        SetMedicalRecord(diagnosis, history);
    }
    public override double CalculateBill()
    {
        return numberOfDays * dailyCharge;
    }
}
class OutPatient : Patient
{
    public int consultationFee;

    public OutPatient(string id, string name, int age, int fee, string diagnosis, string history)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
        this.consultationFee = fee;
        SetMedicalRecord(diagnosis, history);
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }
}
class HospitalPatientManagement
{
    static void Main()
    {
        Patient p1 = new InPatient("101", "Kartik", 20, 3, 2000, "Fever", "Admitted for observation");
        Patient p2 = new OutPatient("102", "Rahul", 22, 500, "Cold", "Prescribed medication");
        DisplayPatient(p1);
        Console.WriteLine();
        DisplayPatient(p2);
        Console.WriteLine("Medical Records:");
        p1.ViewRecords();
        Console.WriteLine();
        p2.ViewRecords();
    }

    static void DisplayPatient(Patient patient)
    {
        patient.GetPatientDetails();
        Console.WriteLine("Total Bill : " + patient.CalculateBill());
    }
}
