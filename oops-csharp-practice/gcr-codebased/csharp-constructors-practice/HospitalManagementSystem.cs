using System;
class Patient{
    public static string HospitalName = "City Care Hospital";
    private static int totalPatients = 0;
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int PatientID, string Name, int Age, string Ailment){
        this.PatientID = PatientID;   
        this.Name = Name;            
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }
    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }
    public void DisplayPatientDetails(){
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Ailment: " + Ailment);
    }
}

class HospitalManagementSystem{
    static void Main(){
        Patient p1 = new Patient(1, "Aryan", 21, "fever");
        Patient p2 = new Patient(2, "Rohit", 30, "fracture");
		Patient p3 = new Patient(3, "Rishab", 30, "acidity");
        Patient.GetTotalPatients();
        if (p1 is Patient)
        {
            Console.WriteLine("\nPatient 1 Details:");
            p1.DisplayPatientDetails();
        }

        if (p2 is Patient)
        {
            Console.WriteLine("\nPatient 2 Details:");
            p2.DisplayPatientDetails();
        }
    }
}
