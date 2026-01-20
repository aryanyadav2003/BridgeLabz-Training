using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.PasswordCrackerSimulator
{
    internal class PasswordCracker:IPassword
    {
        private string secretPassword;
        private Boolean isCracked;
        public void GenerateString(int length)
        {
            char[] current=new char[length];
            BackTrackGenerate(0, length, current);
        }
        private void BackTrackGenerate(int index, int length, char[] current)
        {
            if (index == length)
            {
                Console.WriteLine(new string(current));
                return;
            }
            for(char ch='a';ch <= 'z'; ch++)
            {
                current[index] = ch;
                BackTrackGenerate(index + 1, length, current);
            }
        }
        public void SetPassword(string password)
        {
            secretPassword= password;
            isCracked = false;
            Console.WriteLine("Password set successfully");

        }
        public void DecodePassword()
        {
            if (string.IsNullOrEmpty(secretPassword))
            {
                Console.WriteLine("Password not set.");
                return;
            }
            char[] attempt = new char[secretPassword.Length];
            CrackBacktrack(0, attempt);
            if(!isCracked){
                Console.WriteLine("Password not cracked");
            }
        }
        private void CrackBacktrack(int index, char[] attempt)
        {
            if (isCracked)
                return;
            if (index == secretPassword.Length)
            {
                string guess = new string(attempt);
                Console.WriteLine("Trying : " + guess);
                if (guess == secretPassword)
                {
                    Console.WriteLine(" Password Cracked!");
                    isCracked = true;
                }
                return;
            }
            for(char ch = 'a'; ch <= 'z'; ch++)
            {
                attempt[index] = ch;
                CrackBacktrack(index + 1, attempt);
            }
        }
    }
}
