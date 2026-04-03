using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.PasswordCrackerSimulator
{
    internal interface IPassword
    {
        public void DecodePassword();
        public void SetPassword(string password);
        public void GenerateString(int length);
       
    }
}
