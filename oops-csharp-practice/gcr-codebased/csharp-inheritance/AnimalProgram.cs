using System;
class Animal{
  public string Name;
  public int Age;
  
  public virtual void MakeSound(){
    Console.WriteLine("Animal makes sound");
  }
}
class Dog:Animal{
  public override void MakeSound(){
    Console.WriteLine("Dogs barks");
  }
}
class Cat:Animal{
  public override void MakeSound(){
    Console.WriteLine("Cat meows");
  }
}
class Bird:Animal{
  public override void MakeSound(){
    Console.WriteLine("Bird chirps");
  }
}
class AnimalProgram{
   static void Main(){
     Animal a1=new Dog();
	 Animal a2=new Cat();
	 Animal a3=new Bird();
	 
	 a1.MakeSound();
	 a2.MakeSound();
	 a3.MakeSound();
   }
}
