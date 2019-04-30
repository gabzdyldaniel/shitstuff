using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = "12345";
            string hexToAscii = "31323341";

            string substring = "12345678";
            string swap = "123456";


            Console.WriteLine(ReverseArray(reverse));
            Console.WriteLine(ConvertHexToAscii(hexToAscii));

            Console.WriteLine(SubstringCode(substring));
            Console.WriteLine(SwapEachTwoChars(swap));

            Console.ReadKey();
        }

        public static string ReverseArray(string codeToReverse)
        {
            char[] arrayToReverse = codeToReverse.ToCharArray();
            Array.Reverse(arrayToReverse);

            return new string(arrayToReverse);
        }

        public static string ConvertHexToAscii(string hexString)
        {
            try
            {
                string asciiCode = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    asciiCode += character;

                }

                return asciiCode;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        public decimal ConvertDecToHex(decimal dec)
        {
            decimal decNumber = 0;

            return decNumber;
        }

        public static string SubstringCode(string code)
        {
            return code.Substring(0, 5);
        }

        public static string SwapEachTwoChars(string toSwap)
        {
            char[] charArrayToSwap = toSwap.ToCharArray();

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
