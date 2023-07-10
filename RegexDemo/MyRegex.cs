using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void LastName(string name)
        {
            string lastname = "^[A-Z][a-z 0-9]{3,}$";
            if (Regex.IsMatch(name, lastname))
            {
                Console.WriteLine("STRING IS MATCH");
            }
            else
            {
                Console.WriteLine("String is NOT Match");
            }
        }
        public void Number()
        {
            //long number = Convert.ToInt32(Console.WriteLine(^[A-Z][a-z]{3,}$);
            //String number= "^{0-10}$";
            Console.WriteLine("Enter the NUMBER");
            string num = Console.ReadLine();
            string number = "^[0-9]{2}( ){1}[0-9]{10}$";
            if (Regex.IsMatch(num,number))
            {
                Console.WriteLine("Number is Match");
            }
            else
            {
                Console.WriteLine("Number is NOT Match");
            }
        }
    }
    
}
