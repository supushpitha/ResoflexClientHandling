using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Common
{
    class Validation
    {
        public static bool isValidEmail(string email, out string errorMsg)
        {
            errorMsg = "";

            if (email.Length == 0)
            {
                errorMsg = "e-mail address is required!";

                return false;
            }

            if (email.IndexOf('@') > -1)
            {
                if (email.IndexOf('.', email.IndexOf('@')) > email.IndexOf('@'))
                {
                    errorMsg = "";

                    return true;
                }
            }

            errorMsg = "e-mail address is invalid!";

            return false;
        }

        public static bool isValidPhoneNumber(string number, out string errorMsg)
        {
            if (Regex.IsMatch(number, "^[0-9 ]+$"))
            {
                errorMsg = "";

                return true;
            }
            else
            {
                errorMsg = "Phone number is invalid!";

                return false;
            }
        }
    }
}
