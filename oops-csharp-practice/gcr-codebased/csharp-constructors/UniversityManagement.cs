using System;
class Student{
   public int rollNumber;
   protected string name;
   private double CGPA;
   
   public Student(int rollNumber,string name,double cgpa){
     this.rollNumber = rollNumber;
	 this.name = name;
	 this.CGPA = cgpa;
   }
   
   public double GetCGPA(){
      return CGPA;
   }
   public void SetCGPA(double cgpa){
     if(cgpa >= 0 && cgpa <=10){
	   CGPA=cgpa;
	 }
	 else{
	   Console.WriteLine("Invalid CGPA");
	 }
   }
}
class PostgraduateStudent : Student{
  public string specialization;
  public PostgraduateStudent(int rollNumber,string name,double cgpa,string specialization) : base(rollNumber, name, cgpa){
     this.specialization = specialization;
  }
  public void DisplayDetails(){
        Console.WriteLine("Roll Number: " + rollNumber);   
        Console.WriteLine("Name: " + name);                
        Console.WriteLine("CGPA: " + GetCGPA());      
        Console.WriteLine("Specialization: " + specialization);
}}
class UniversityManagement{
   static void Main(){
     PostgraduateStudent pg = new PostgraduateStudent(101,"Aryan",8.6,"Computer Science");
	 pg.DisplayDetails();
	 pg.SetCGPA(9.0);
	 Console.WriteLine("Updated CGPA:" + pg.GetCGPA());
   }
}