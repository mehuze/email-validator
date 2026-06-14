using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidator
{
  public class Validator
    {
        public bool IsValid(string email)
        {
            
         return email.Contains("@");
        }

    }
}
