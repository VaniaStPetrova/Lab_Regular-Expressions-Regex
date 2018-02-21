using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            var currentNumbers = regex.Matches(Console.ReadLine());

            foreach (var number in currentNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
