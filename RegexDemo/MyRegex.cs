using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class MyRegex
    {
        static string pattern = "^HEMANT$";
        public void Check()
        {
            
            Regex regex = new Regex(pattern);

            if (regex.IsMatch("HEMANTa"))
            { 
                Console.WriteLine("String is match");
            }
            else
            {
                Console.WriteLine("String is not match");
            }
        }
    }
}
