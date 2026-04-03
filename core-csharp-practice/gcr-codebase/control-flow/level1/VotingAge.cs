using System;
class VotingAge{
  static void Main(){
    Console.WriteLine("Enter age: ");
	int age=Convert.ToInt32(Console.ReadLine());
	if(age>=18){
	 Console.WriteLine($"The person age is {age} and can vote");
	}
	else{
	 Console.WriteLine($"The person age is {age} and cannot vote");
	}
  }
}