using System;
class CountVowelConsonant{
  static void helper(string text){
   int v=0,c=0;
   text=text.ToLower();
   for(int i=0;i<text.Length;i++){
     char ch=text[i];
	 if(ch>='a' && ch <='z'){
	   if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u'){
	    v++;
	   }
	   else{
	    c++;
	   }
	 }
   }
   Console.WriteLine("Vowels: "+ v);
   Console.WriteLine("Consonants: "+ c);
}
  static void Main(){
    string input=Console.ReadLine();
	CountVowelConsonant(input);
  }
}