﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}";
            var regex = new Regex(pattern);
            var phoneNumbers = regex.Matches(Console.ReadLine());

            var isFirst = true;
            foreach (var number in phoneNumbers)
            {
                if (isFirst)
                {
                    Console.Write(number);
                    isFirst = false;
                    continue;
                }
                Console.Write($", {number}");
            }
            Console.WriteLine();
        }
    }
}
