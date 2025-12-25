using System;
class OTPGenerator{
  public static int GenerateOTP(){
  Random r=new Random();
  return r.Next(100000,1000000);
  }
  public static bool AreUnique(int[] otp){
   for(int i=0;i<otp.Length;i++){
    for(int j=i+1;j<otp.Length;j++){
	  if(otp[i]==otp[j]){
	    return false;
	  }
	}
   }
   return true;
  }
  static void Main(){
   int[] otp=new int[10];
   for(int i=0;i<10;i++){
     otp[i]=GenerateOTP();
   }   
   foreach(int o in otp){
     Console.WriteLine(o);
   }
   bool unique=AreUnique(otp);
   Console.WriteLine(unique);
   }
}