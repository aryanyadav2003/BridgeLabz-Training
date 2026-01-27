using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace class_library
{
    public class PassWordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
