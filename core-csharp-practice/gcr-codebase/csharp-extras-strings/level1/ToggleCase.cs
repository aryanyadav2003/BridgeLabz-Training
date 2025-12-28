using System;
class ToggleCase{
  static void Main(){
    string input=Console.ReadLine(); 
    string res="";
	foreach(char c in input){
	  if(char.IsUpper(c)){
	    res+=char.ToLower(c);
	  }
	  else{
         res+=char.ToUpper(c);
		 }
	}
     Console.Write(res);	
  }
}