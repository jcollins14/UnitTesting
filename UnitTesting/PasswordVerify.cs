using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UnitTesting
{
    class PasswordVerify
    {
        public string Verify(string pw)
        {
            if (pw.Any(char.IsDigit))
            {
                if (pw.Any(char.IsLower))
                {
                    if (pw.Any(char.IsUpper))
                    {
                        if (pw != null)
                        {
                            if (pw.Length > 8)
                            {
                                return "Valid";
                            }
                            //throw new Exception("Password must have 8 characters or more.");
                        }
                       // throw new Exception("Password cannot be null.");
                    }
                    //throw new Exception("Password must contain an upperchase character.");
                }
                //throw new Exception("Password must contain a lowercase character.");
            }
            //throw new Exception("Password must contain a number.");
            return "Invalid";
        }
    }
}
