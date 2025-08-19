using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLDShared
{
    public class clsValidatoin
    {
        public static bool ValidateEmail(string EmailAddress)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var Regex = new Regex(pattern);
            return Regex.IsMatch(EmailAddress);
        }

        public static bool ValidateRequiredField(string password, string passwordConfirm)
        {
            if (password!= passwordConfirm)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
