using System;
class Person{
   private int age=22;
   protected string name="Aryan";
   public string city="Lucknow";
   
   public void show(){
      Console.WriteLine(age);
	  Console.WriteLine(name);
	  Console.WriteLine(city);
   } 
}
class Student{
   public void display(){
     Person p=new Person();
	  // Console.WriteLine(p.age);
	  //Console.WriteLine(p.name);
	   Console.WriteLine(p.city);
   }
}
class AccessModifier{
    static void Main(){
	  Person p=new Person();
	  //Console.WriteLine(p.age);
	  //Console.WriteLine(p.name);
	  Console.WriteLine(p.city);
	  
	  Student s=new Student();
	  s.display();
	}
}