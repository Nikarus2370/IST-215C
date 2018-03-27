using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab100_2_RegExPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string input = @"(603) 555-1212";
            Console.WriteLine("Input string: {0}", input);

            Match match = PhoneNumberReg(input);
            GroupCollection gc = null;

            if (!match.Success)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Single Match: {match.Value}");
                Console.WriteLine();

                gc = match.Groups;
                Console.WriteLine($"Count for the match: {gc.Count}, Original number: {match.Groups[0]}");
                string str = string.Format("{0}.{1}.{2}", match.Groups[1], match.Groups[2], match.Groups[3]);
                Console.WriteLine(str);

                input = "603-555-1212";
                Console.WriteLine("\n\nInput string: {0}", input);
                str = ConvertPhoneNumber(input);
                Console.WriteLine($"{str}");
            }
        }

        public static Match PhoneNumberReg(string input)
        {
            return Regex.Match(input, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
        }

        public static string ConvertPhoneNumber(string input)
        {
            try
            {
                return Regex.Replace(input,"\\b(?<areaCode>\\d{1,3})-(?<first>\\d{1,3})-(?<second>\\d{1,4})\\b"
                    , "${areaCode}.${first}.${second}", RegexOptions.None, TimeSpan.FromMilliseconds(150));
            }
            catch (RegexMatchTimeoutException)
            {

                return input;
            }
        }
    }
}
