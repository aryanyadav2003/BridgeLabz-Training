using System;
class MostFrequent{
  static void Main(){
    string input=Console.ReadLine();
	int[] freq=new int[256];
	for(int i=0;i<input.Length;i++){
	  freq[input[i]]++;
	}
	char mostFreq='\0';
	int cnt=0;
	for(int i=0;i<input.Length;i++){
	 if(freq[input[i]]>cnt){
	   cnt=freq[input[i]];
	   mostFreq=input[i];
	 }
	}
	Console.WriteLine($"Most frequent character: {mostFreq}");
    Console.WriteLine($"Frequency: {cnt}");
  }
}