using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdvancedCSharpTopics
{
    // RegEx IsMatch example : The Regex.IsMatch method returns true if the string matches the pattern, or false if it does not. 
    // The IsMatch method is often used to validate string input. 
    public class RegularExpressions_Example1
    {
        public static void Main()
        {
            string[] values = { "111-22-3334", "111-2-3333" };
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                    Console.WriteLine($"{value} is a valid SSN.");
                else
                    Console.WriteLine($"{value} is an invalid SSN");
            }
        }
        
    }
}

//Pattern Description
//     ^ - Match the beginning of the input string.
//  \d{3} - Match three decimal digits.
//    -	Match a hyphen.
//     \d{ 2} - Match two decimal digits.
//    -	Match a hyphen.
//  \d{4} Match four decimal digits.
//    $	Match the end of the input string.