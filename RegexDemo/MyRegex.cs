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

            if (regex.IsMatch("HEMANT"))
            { 
                Console.WriteLine("String is match");
            }
            else
            {
                Console.WriteLine("String is not match");
            }
        }
        public void FirstName(string name)
        {
            string myname = "^[A-Z][a-z]{3,}$"; // 1 word is Capital after than small words and should get more than 3 word
            if (Regex.IsMatch(name, myname))
            {
                Console.WriteLine("STRING IS MATCH");
            }
            else
            {
                Console.WriteLine("String is NOT Match");
            }
        }
    }
    
}
