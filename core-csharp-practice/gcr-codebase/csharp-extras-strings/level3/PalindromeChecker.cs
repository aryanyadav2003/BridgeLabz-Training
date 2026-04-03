using System;
class PalindromeChecker{
    static bool IsPalindrome(string text){
        text=text.ToLower();
        int left=0;
        int right=text.Length-1;
        while(left<right){
            if(text[left]!=text[right]){
                return false;
    }
            left++;
            right--;
        }
        return true;
    }
    static void Main(){
        Console.Write("Enter a string: ");
        string input=Console.ReadLine();
        bool result=IsPalindrome(input);
        if (result){
            Console.WriteLine("Palindrome");
		}
        else
            Console.WriteLine("Not a Palindrome");
    }
}
