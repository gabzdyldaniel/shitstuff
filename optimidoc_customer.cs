using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Customer
    {
        private string customerNumber;
        private int validationMethod;
        
        public string CustomerNumber { get => customerNumber; set => customerNumber = value; }
        public int ValidationMethod { get => validationMethod; set => validationMethod = value; }

        public Customer(string customerNumber, int validationMethod)
        {
            this.customerNumber = customerNumber;
            this.validationMethod = validationMethod;
        }

        public static string ValidateCustomer(Customer customer)
        {
            string customerNumber = customer.CustomerNumber;
            string result;

            switch (customer.ValidationMethod)
            {
                case 1:
                    result = ReverseArray(customerNumber);
                    break;
                case 2:
                    result = ConvertHexToAscii(customerNumber);
                    break;
                case 3:
                    result = ConvertDecToHex(customerNumber);
                    break;
                case 4:
                    result = SubstringCode(customerNumber);
                    break;
                case 5:
                    result = SwapEachTwoChars(customerNumber);
                    break;
                case 6:
                    result = ConvertHexToDecAndReverse(customerNumber);
                    break;

                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }

        public static string ReverseArray(string code)
        {
            char[] arrayToReverse = code.ToCharArray();
            Array.Reverse(arrayToReverse);

            return new string(arrayToReverse);
        }

        public static string ConvertHexToAscii(string code)
        {
            try
            {
                string asciiCode = string.Empty;

                for (int i = 0; i < code.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = code.Substring(i, 2);
                    uint decval = Convert.ToUInt32(hs, 16);
                    char charval = Convert.ToChar(decval);
                    asciiCode += charval;
                }

                return asciiCode;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string ConvertHexToDecAndReverse(string code)
        {
            try
            {
                string decValueString = int.Parse(code, System.Globalization.NumberStyles.HexNumber).ToString();
                return ReverseArray(decValueString);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string ConvertDecToHex(string code)
        {
            try
            {
                int decCode = Convert.ToInt32(code);
                return decCode.ToString("X");
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string SubstringCode(string code)
        {
            return code.Substring(0, 6);
        }

        public static string SwapEachTwoChars(string code)
        {
            char[] charArrayToSwap = code.ToCharArray();

            if (charArrayToSwap.Length % 2 == 0)
            {
                for (int i = 0; i < charArrayToSwap.Length; i += 2)
                {
                    char pom = charArrayToSwap[i];
                    charArrayToSwap[i] = charArrayToSwap[i + 1];
                    charArrayToSwap[i + 1] = pom;
                }
            }

            return new string(charArrayToSwap);
        }
    }
}
