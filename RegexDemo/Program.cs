using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyRegex myregex = new MyRegex();
            while (true)
            {
                Console.WriteLine("1. for check satic string is match or not");
                Console.WriteLine("2. for check FIRST NAME is match or not");
                Console.WriteLine("3. for check LAST  NAME is match or not");
                Console.WriteLine("4. for check Number");
                Console.WriteLine("ENTER OPTION");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        myregex.Check();
                        break;
                    case 2:
                        myregex.FirstName("Hemant");
                        break;
                    case 3:
                        myregex.LastName("Saini1");
                        break;
                    case 4:
                        //long num_one = 9999568624;
                        myregex.Number();
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }


        }
    }
}
