using System;
class LowerCaseConverter{
static string ToLowerCase(string input){
  char[] result=new char[input.Length];
  for(int i=0;i<input.Length;i++){
   char ch=input[i];
   if(ch>='A' && ch<='Z'){
     result[i]=(char)(ch+32);
   }
   else{
    result[i]=ch;
   }
  }
  return new string(result);
}
  static void Main(){
  string text=Console.ReadLine();
  string s1=ToLowerCase(text);
  string s2=text.ToLower();
  Console.WriteLine("Lowercase using ASCII logic : " + s1);
  Console.WriteLine("Lowercase using ToUpper()  : " + s2);
  if(s1==s2){
    Console.WriteLine("Both results are same");
  }
  else{
    Console.WriteLine("Results are different");
  }
  }
}