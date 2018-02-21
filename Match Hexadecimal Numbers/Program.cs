using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var regex = new Regex(pattern);
            var hexidecimalNumbers = regex.Matches(Console.ReadLine());

            foreach (var match in hexidecimalNumbers)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
