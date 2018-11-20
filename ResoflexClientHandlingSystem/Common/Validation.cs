using System;
using System.Collections.Generic;
using System.Data;
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
            if ((Regex.IsMatch(number, "^[0-9 ]+$")) && (number.Length == 10))
            {
                errorMsg = "";

                return true;
            }
            else if (number.Length != 10)
            {
                errorMsg = "phone number must only have 10 digits!";

                return false;
            }
            else
            {
                errorMsg = "Phone number can only have numbers!";

                return false;
            }
        }

        public static bool isNumber(string text)
        {
            return Regex.IsMatch(text, "^[0-9 ]+$");
        }

        public static bool isDouble(string text)
        {
            double result;

            if (double.TryParse(text, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isFuture(DateTime date)
        {
            return (date > DateTime.Now);
        }

        public static bool isValidPassword(string pass, out string errorMsg)
        {
            if ((pass.Length >= 6))
            {
                errorMsg = "";

                return true;
            }
            else
            {
                errorMsg = "Password is not valid!";

                return false;
            }
        }

        public static bool isValidUsername(string uname, out string errorMsg)
        {
            if ((uname.Length >= 6))
            {
                errorMsg = "";

                return true;
            }
            else
            {
                errorMsg = "Username is not valid!";

                return false;
            }
        }

        public static Boolean isEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static Boolean isDataTableEmpty(DataTable dt)
        {
            return (dt.Rows.Count <= 0);
        }

        public static bool isValidNic(string nic, out string errorMsg)
        {
            errorMsg = "";

            if (nic.Length == 0)
            {
                errorMsg = "NIC number is required!";

                return false;
            }

            if (nic.Length > 10)
            {
                errorMsg = "NIC number is invalid!";

                return false;
            }

            if (nic.IndexOf('v') == 9)
            {
                errorMsg = "";

                return true;
            }
            else
            {
                errorMsg = "NIC number is invalid!";

                return false;
            }
        }
    }
}
