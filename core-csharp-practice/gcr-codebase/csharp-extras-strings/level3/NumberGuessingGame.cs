using System;
class NumberGuessingGame{
   static int GenetateGuess(int low,int high){
     return (low+high)/2;
   }
   static char UserFeedback(){
     Console.Write("Is the guess High (H),Low (L),or Correct (C)? ");
	 return char.ToUpper(Console.ReadLine()[0]);
   }
   static void Main(){
     int low=1,high=100,guess;
	 char feedback;
	 int attempts=0;
	 Console.WriteLine("Think of a number between 1 and 100.");
	 while(true){
	   guess=GenetateGuess(low,high);
	   attempts++;
	   Console.WriteLine($"My guess is:{guess}");
       feedback=UserFeedback();
	   if(feedback=='C'){
	     Console.WriteLine("I guesses your number in {attempts} attempts");
		 break;
	   }
	   else if(feedback=='H'){
	    high=guess-1;
	   }
	   else if(feedback=='L'){
	     low=guess+1;
	   }
	   else{
	     Console.WriteLine("Invalid input! Please enter H,L,or C.");
	   }
	 }
   }
}